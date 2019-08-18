﻿using KindergartenAppService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly KindergarterContext _context;

        public InvoicesController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: Invoices
        public async Task<IActionResult> Index()
        {
            //var kindergartenContext = _context.Invoices.Include(i => i.Kid);
            var kindergartenContext = GenerateInvoices();

            foreach (var invoice in kindergartenContext)
            {
                //foreach (var detail in invoice.InvoiceDetails)
                //{
                //    _context.InvoiceDetails.Add(detail);
                //}
                //_context.Invoices.Add(invoice);

            }
            await _context.SaveChangesAsync();

            var invoices = _context.Invoices.Include(i => i.Kid)
                .Where(i=>i.Date.Month == DateTime.Now.Month);
            //var invoicesModified = ModifieInvoices(kindergartenContext);
            return View(kindergartenContext);
        }

        private async Task<List<Invoice>> ModifieInvoices(List<Invoice> invoices)
        {
            List<Invoice> modifiedInvoices = new List<Invoice>();
            foreach (var invoice in invoices)
            {
                var invoiceFound =  await _context.Invoices
                                        .Include(i=>i.InvoiceDetails)
                                        .SingleOrDefaultAsync(i => i.KidId == invoice.KidId && 
                                                                   i.Date.Month == DateTime.Now.Month);
                //if the invoice is already generated
                //modify it
                if (invoiceFound != null)
                {
                    foreach (var detail in invoice.InvoiceDetails)
                    {
                        var detailFound = invoiceFound.InvoiceDetails
                            .SingleOrDefault(d => d.ItemId == detail.ItemId);
                        //modify
                        if (detailFound != null )
                        {
                            if (detailFound.Amount != detail.Amount)
                            {
                                detailFound.Amount = detail.Amount;
                            }
                        }
                        else//add
                        {
                            detail.InvoiceId = invoiceFound.Id;
                        }
                    }
                    //remove
                    List<InvoiceDetail> detailsToRemove = new List<InvoiceDetail>();
                    foreach (var detail in invoiceFound.InvoiceDetails)
                    {
                        var detailFound = invoice.InvoiceDetails.SingleOrDefault(d => d.ItemId == detail.ItemId);
                        if (detailFound == null)
                        {
                            detailsToRemove.Add(detail);
                        }
                    }
                    foreach (var detail in detailsToRemove)
                    {
                        invoiceFound.InvoiceDetails.Remove(detail);
                    }
                }
                //if the invoice isnt generated return it as created
                //it means is new
                else
                {
                    modifiedInvoices.Add(invoice);
                }
            }
            _context.SaveChanges();
            return modifiedInvoices;
        }

        // GET: Invoices/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoices
                .Include(i => i.Kid)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        // GET: Invoices/Create
        public IActionResult Create()
        {
            ViewData["KidId"] = new SelectList(_context.Kid, "Id", "Id");
            return View();
        }

        // POST: Invoices/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Date,KidId,Id")] Invoice invoice)
        {
            if (ModelState.IsValid)
            {
                invoice.Id = Guid.NewGuid();
                _context.Add(invoice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KidId"] = new SelectList(_context.Kid, "Id", "Id", invoice.KidId);
            return View(invoice);
        }

        // GET: Invoices/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoices.FindAsync(id);
            if (invoice == null)
            {
                return NotFound();
            }
            ViewData["KidId"] = new SelectList(_context.Kid, "Id", "Id", invoice.KidId);
            return View(invoice);
        }

        // POST: Invoices/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Date,KidId,Id")] Invoice invoice)
        {
            if (id != invoice.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(invoice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InvoiceExists(invoice.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["KidId"] = new SelectList(_context.Kid, "Id", "Id", invoice.KidId);
            return View(invoice);
        }

        // GET: Invoices/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var invoice = await _context.Invoices
                .Include(i => i.Kid)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (invoice == null)
            {
                return NotFound();
            }

            return View(invoice);
        }

        // POST: Invoices/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var invoice = await _context.Invoices.FindAsync(id);
            _context.Invoices.Remove(invoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public List<Invoice> GenerateInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            List<InvoiceDetail> details = new List<InvoiceDetail>();
            var enrollActivities = _context.EnrollActivity
                .Include(e=>e.Enrollment.Kid.TutorPrincipal)
                .Include(e=>e.Activity)
                .Include(e=>e.Service)
                .Where(e=>e.EnrollmentId != null &&
                          e.ServiceId != null);
            var enrollActByKid = enrollActivities.GroupBy(e => e.EnrollmentId);
            if (enrollActivities != null)
            {
                foreach (var kidGroup in enrollActByKid)
                {
                    decimal acumulativeAmount = 0;
                    var invoice = new Invoice
                    {
                        Date = DateTime.Now,
                        KidId = kidGroup.First().Enrollment.KidId,
                        Kid= kidGroup.First().Enrollment.Kid,
                        Id = Guid.NewGuid()
                    };
                    foreach (var activity in kidGroup)
                    {
                        acumulativeAmount += activity.Service.Price;
                        var detail = new InvoiceDetail
                        {
                            Amount = activity.Service.Price,
                            ItemId = activity.ServiceId.Value,
                            Quantity = 1,
                            Id = Guid.NewGuid(),
                            InvoiceId = invoice.Id
                        };
                        details.Add(detail);
                        //invoice.InvoiceDetails.Add(detail);
                    }
                    invoice.Price = acumulativeAmount;
                    invoices.Add(invoice);
                }
                
            }

            return invoices;
        }
        public async Task<IActionResult> Edit2(Guid? id)
        {
            Console.WriteLine("####Id from Edit: " + id.ToString());

            Invoice invoice = null;
            List<InvoiceDetail> details = new List<InvoiceDetail>();
            var enrollActivities = await _context.EnrollActivity
                .Include(e => e.Enrollment.Kid.TutorPrincipal)
                .Include(e => e.Activity)
                .Include(e => e.Service)
                .Where(e => e.EnrollmentId != null &&
                          e.ServiceId != null && e.Enrollment.KidId == id).ToListAsync();

            if (enrollActivities != null)
            {
                var kid = await _context.Kid.FindAsync(id);
                decimal acumulativeAmount = 0;
                foreach (var activity in enrollActivities)
                {
                    acumulativeAmount += activity.Service.Price;
                    var detail = new InvoiceDetail
                    {
                        Amount = activity.Service.Price,
                        ItemId = activity.ServiceId.Value,
                        Quantity = 1,
                        Id = Guid.NewGuid(),
                        //InvoiceId = invoice.Id
                    };
                    details.Add(detail);
                }
                invoice = new Invoice
                {
                    Date = DateTime.Now,
                    KidId = id.Value,
                    Id = Guid.NewGuid(),
                    InvoiceDetails = details
                };
                invoice.Price = acumulativeAmount;

                _context.Invoices.Add(invoice);

                //foreach (var detail in details)
                //{
                //    //invoice.InvoiceDetails.Add(detail);

                //    _context.InvoiceDetail.Add(detail);
                    
                //}
                //_context.Attach(invoice.InvoiceDetails);

                //_context.SaveChanges();
                //var invoiceFound = _context.Invoices.Find(invoice.Id);
                //invoiceFound.InvoiceDetails.Add(new InvoiceDetail
                //{
                //    Amount = 100,
                //    Quantity = 1,
                //    ItemId = new Guid("7530F576-CFFA-4CBB-81F8-BDE60C7DFEC0")
                //});
                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index));
        }
            public async Task<IActionResult> GenerateInvoice(Guid? kidId)
        {
            Invoice invoice = null;
            List<InvoiceDetail> details = new List<InvoiceDetail>();
            var enrollActivities = await _context.EnrollActivity
                .Include(e => e.Enrollment.Kid.TutorPrincipal)
                .Include(e => e.Activity)
                .Include(e => e.Service)
                .Where(e => e.EnrollmentId != null &&
                          e.ServiceId != null && e.Enrollment.KidId == kidId).ToListAsync();

            if (enrollActivities != null)
            {
                var kid = await _context.Kid.FindAsync(kidId);
                decimal acumulativeAmount = 0;
                invoice = new Invoice
                {
                    Date = DateTime.Now,
                    KidId = kidId.Value,
                    Id = Guid.NewGuid()
                };
                foreach (var activity in enrollActivities)
                {
                    acumulativeAmount += activity.Service.Price;
                    var detail = new InvoiceDetail
                    {
                        Amount = activity.Service.Price,
                        ItemId = activity.ServiceId.Value,
                        Quantity = 1,
                        Id = Guid.NewGuid(),
                        InvoiceId = invoice.Id
                    };
                    details.Add(detail);
                    //invoice.InvoiceDetails.Add(detail);
                }
                invoice.Price = acumulativeAmount;

                _context.Invoices.Add(invoice);
                _context.SaveChanges();

            }

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Preview(Invoice invoice){
            var _invoice = await _context.Invoices
                .Include(i=>i.Kid)
                .FirstOrDefaultAsync(i=>i.Id == invoice.Id);

            return View(_invoice);
        }

        public async Task<IActionResult> Generate(Invoice invoice)
        {
            invoice.Status = InvoiceStatus.Generated;
            await _context.Invoices.AddAsync(invoice);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool InvoiceExists(Guid id)
        {
            return _context.Invoices.Any(e => e.Id == id);
        }
    }
}

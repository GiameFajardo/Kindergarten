using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KindergartenAppService.Models;

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
            var kindergartenContext = _context.Invoices.Include(i => i.Kid);
            return View(await kindergartenContext.ToListAsync());
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
        public async Task<IActionResult> GenerateInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
            List<InvoiceDetail> details = new List<InvoiceDetail>();
            var enrollActivities =  _context.EnrollActivity;
            var enrollActByKid = enrollActivities.GroupBy(e => e.EnrollmentId);
            foreach (var kidGroup in enrollActByKid)
            {
                var invoice = new Invoice
                {
                    Date = DateTime.Now,
                    KidId = kidGroup.First().Enrollment.KidId,
                    Id = Guid.NewGuid()
                };
                foreach (var activity in kidGroup)
                {

                    details.Add(new InvoiceDetail
                    {
                        Amount = activity.Service.Price,
                        ItemId = activity.ServiceId.Value,
                        Quantity = 1,
                        Id = Guid.NewGuid(),
                        
                    });
                }
            }
            return null;
        }
        private bool InvoiceExists(Guid id)
        {
            return _context.Invoices.Any(e => e.Id == id);
        }
    }
}

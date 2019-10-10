using GrapeCity.Documents.Pdf;
using GrapeCity.Documents.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
using KindergartenAppService.DTO;
using KindergartenAppService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace KindergartenAppService.Controllers
{
    public class InvoicesController : Controller
    {
        private readonly KindergarterContext _context;
        //private List<Invoice> InvoicesShown;
        public InvoicesController(KindergarterContext context)
        {
            _context = context;
            //InvoicesShown = new List<Invoice>();
        }

        public async Task<IActionResult> Index(int? month)
        {

            if (month == null || month <= 0)
            {
                month = DateTime.Now.Month;

            }

            var invoicesGenerated = GenerateInvoices(month.Value);

            var invoices = _context.Invoices.Include(i => i.Kid)
                .Where(i => i.GeneratedDate.Month == month).ToList();

            var invoicesUpdated = await UpdateInvoices(invoicesGenerated, month.Value);

            return View(invoicesUpdated.OrderBy(i => i.Sequence).ToList());
        }
        private async Task<List<Invoice>> UpdateInvoices(List<Invoice> invoicesGenerated, int month)
        {
            foreach (var invoice in invoicesGenerated)
            {
                var invoiceFound = await _context.Invoices
                                        .Include(i => i.InvoiceDetails)
                                        .SingleOrDefaultAsync(i => i.KidId == invoice.KidId &&
                                                                   i.DueDate.Month == month);
                if (invoiceFound != null)
                {
                    invoice.Id = invoiceFound.Id;
                    invoice.Status = invoiceFound.Status;
                    invoice.Price = invoiceFound.Price;
                    invoice.GeneratedDate = invoiceFound.GeneratedDate;
                    invoice.DueDate = invoiceFound.DueDate;
                    invoice.Sequence = invoiceFound.Sequence;
                    invoice.Document = invoiceFound.Document;
                }
            }

            return invoicesGenerated;
        }

        private async Task<List<Invoice>> ModifieInvoices(List<Invoice> invoicesGenerated)
        {
            List<Invoice> modifiedInvoices = new List<Invoice>();
            foreach (var invoiceG in invoicesGenerated)
            {
                var invoiceFound = await _context.Invoices
                                        .Include(i => i.InvoiceDetails)
                                        .SingleOrDefaultAsync(i => i.KidId == invoiceG.KidId &&
                                                                   i.GeneratedDate.Month == DateTime.Now.Month);
                //if the invoice is already generated
                //modify it
                if (invoiceFound != null)
                {
                    foreach (var detail in invoiceG.InvoiceDetails)
                    {
                        var detailFound = invoiceFound.InvoiceDetails
                            .SingleOrDefault(d => d.ItemId == detail.ItemId);
                        //modify
                        if (detailFound != null)
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
                        var detailFound = invoiceG.InvoiceDetails.SingleOrDefault(d => d.ItemId == detail.ItemId);
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
                    modifiedInvoices.Add(invoiceG);
                }
            }
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
        public List<Invoice> GenerateInvoices(int month)
        {
            List<Invoice> invoices = new List<Invoice>();
            List<InvoiceDetail> details = new List<InvoiceDetail>();
            var enrollActivities = _context.EnrollActivity
                .Include(e => e.Enrollment.Kid.TutorPrincipal)
                .Include(e => e.Activity)
                .Include(e => e.Service)
                .Where(e => e.EnrollmentId != null &&
                          e.ServiceId != null && e.Enrollment.EnrollDay.Month == month);
            var enrollActByKid = enrollActivities.GroupBy(e => e.EnrollmentId);
            if (enrollActivities != null)
            {
                foreach (var kidGroup in enrollActByKid)
                {
                    decimal acumulativeAmount = 0;
                    var invoice = new Invoice
                    {
                        Status = InvoiceStatus.Preview,
                        GeneratedDate = DateTime.Now,
                        DueDate = new DateTime(
                        DateTime.Now.Year,
                        month,
                        DateTime.DaysInMonth(
                            DateTime.Now.Year,
                            month
                            )),
                        KidId = kidGroup.First().Enrollment.KidId,
                        Kid = kidGroup.First().Enrollment.Kid,
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
        public List<Invoice> GenerateInvoices2()
        {
            List<Invoice> invoicesMonthly = new List<Invoice>();
            List<Invoice> invoicesBiweekly = new List<Invoice>();

            List<InvoiceDetail> details = new List<InvoiceDetail>();

            var enrollActivities = _context.EnrollActivity
                .Include(e => e.Enrollment.Kid.TutorPrincipal)
                .Include(e => e.Activity)
                .Include(e => e.Service)
                .Where(e => e.EnrollmentId != null &&
                          e.ServiceId != null);

            var enrollActByKid = enrollActivities.GroupBy(e => e.EnrollmentId);

            if (enrollActivities != null)
            {
                foreach (var kidGroup in enrollActByKid)
                {
                    decimal acumulativeMonthlyAmount = 0;
                    decimal acumulativeBiweeklyAmount = 0;
                    bool hasMonthly = false;
                    bool hasBiweekly = false;

                    var invoiceMonth = new Invoice
                    {
                        Status = InvoiceStatus.Preview,
                        DueDate = new DateTime(
                        DateTime.Now.Year,
                        DateTime.Now.Month,
                        DateTime.DaysInMonth(
                            DateTime.Now.Year,
                            DateTime.Now.Month
                            )
                        ),
                        GeneratedDate = DateTime.Now,
                        KidId = kidGroup.First().Enrollment.KidId,
                        Kid = kidGroup.First().Enrollment.Kid,
                        Id = Guid.NewGuid()
                    };
                    var invoiceBiweek = new Invoice
                    {
                        DueDate = new DateTime(
                        DateTime.Now.Year,
                        DateTime.Now.Month,
                        15
                        ),
                        Status = InvoiceStatus.Preview,
                        GeneratedDate = DateTime.Now,
                        KidId = kidGroup.First().Enrollment.KidId,
                        Kid = kidGroup.First().Enrollment.Kid,
                        Id = Guid.NewGuid()
                    };

                    foreach (var activity in kidGroup)
                    {
                        if (activity.Service.ServicePeriod == ServicePeriod.Monthly)
                        {
                            hasMonthly = true;
                            acumulativeMonthlyAmount += activity.Service.Price;

                            var detail = new InvoiceDetail
                            {
                                Amount = activity.Service.Price,
                                ItemId = activity.ServiceId.Value,
                                Quantity = 1,
                                Id = Guid.NewGuid(),
                                InvoiceId = invoiceMonth.Id
                            };
                        }
                        else if (activity.Service.ServicePeriod == ServicePeriod.Biweekly)
                        {
                            hasBiweekly = true;
                            acumulativeBiweeklyAmount += activity.Service.Price;

                            var detail = new InvoiceDetail
                            {
                                Amount = activity.Service.Price,
                                ItemId = activity.ServiceId.Value,
                                Quantity = 1,
                                Id = Guid.NewGuid(),
                                InvoiceId = invoiceBiweek.Id
                            };
                        }
                        //details.Add(detail);
                        //invoice.InvoiceDetails.Add(detail);
                        invoiceMonth.Price = acumulativeMonthlyAmount;
                        invoiceBiweek.Price = acumulativeBiweeklyAmount;

                        if (hasMonthly)
                        {
                            invoicesMonthly.Add(invoiceMonth);

                        }
                        if (hasBiweekly)
                        {
                            invoicesBiweekly.Add(invoiceBiweek);
                        }
                    }


                }

            }

            return invoicesMonthly;
        }
        public async Task<IActionResult> Cancelar(Invoice invoice)
        {
            var invoiceFound = await _context.Invoices
                .Include(i => i.InvoiceDetails)
                .Include(i => i.Payments)
                .SingleOrDefaultAsync(i => i.Id == invoice.Id);
            if (invoiceFound.Payments.Count > 0)
            {
                TempData["CantDelete"] = "Factura presenta pagos.";
                return RedirectToAction(nameof(Index));
            }

            if (invoiceFound != null)
            {

                _context.InvoiceDetail.RemoveRange(invoiceFound.InvoiceDetails);

                _context.Invoices.Remove(invoiceFound);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        [HttpGet("{id}/{month}")]
        public async Task<IActionResult> Generate(Guid? id, int month)
        {
            var prefix = _context.Sequences.SingleOrDefault(s => s.DocumentType == DocumentType.Invoice).Prefix;

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
                var sequence = _context.Sequences.SingleOrDefault(s => s.DocumentType == DocumentType.Invoice);
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

                long nextSequence = sequence.StaringSequence > sequence.CurrentSequence ? sequence.StaringSequence : sequence.CurrentSequence + 1;

                invoice = new Invoice
                {
                    Sequence = nextSequence,
                    Status = InvoiceStatus.Generated,
                    GeneratedDate = DateTime.Now,
                    DueDate = new DateTime(
                        DateTime.Now.Year,
                        month,
                        //DateTime.Now.Month,
                        DateTime.DaysInMonth(
                            DateTime.Now.Year,
                            month
                            )
                        ),
                    KidId = id.Value,
                    Id = Guid.NewGuid(),
                    InvoiceDetails = details
                };
                invoice.Document = prefix + invoice.SequenceString;
                invoice.Price = acumulativeAmount;
                sequence.CurrentSequence = nextSequence;
                _context.Invoices.Add(invoice);


                _context.SaveChanges();
            }

            return RedirectToAction(nameof(Index), new { month = month });
        }
        private async Task GenerateInvoice(Guid? id, int month)
        {
            var prefix = _context.Sequences.SingleOrDefault(s => s.DocumentType == DocumentType.Invoice).Prefix;

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
                var sequence = _context.Sequences.SingleOrDefault(s => s.DocumentType == DocumentType.Invoice);
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

                long nextSequence = sequence.StaringSequence > sequence.CurrentSequence ? sequence.StaringSequence : sequence.CurrentSequence + 1;

                invoice = new Invoice
                {
                    Sequence = nextSequence,
                    Status = InvoiceStatus.Generated,
                    GeneratedDate = DateTime.Now,
                    DueDate = new DateTime(
                        DateTime.Now.Year,
                        month,
                        //DateTime.Now.Month,
                        DateTime.DaysInMonth(
                            DateTime.Now.Year,
                            DateTime.Now.Month
                            )
                        ),
                    KidId = id.Value,
                    Id = Guid.NewGuid(),
                    InvoiceDetails = details
                };
                invoice.Document = prefix + invoice.SequenceString;
                invoice.Price = acumulativeAmount;
                sequence.CurrentSequence = nextSequence;
                _context.Invoices.Add(invoice);


                _context.SaveChanges();
            }

            //return RedirectToAction(nameof(Index), new { month = month });
        }
        public async Task<IActionResult> GenerateAll(int month)
        {

            if (month == null || month <= 0)
            {
                month = DateTime.Now.Month;

            }

            var invoicesGenerated = GenerateInvoices(month);

            var invoices = _context.Invoices.Include(i => i.Kid)
                .Where(i => i.GeneratedDate.Month == month).ToList();

            var InvoicesShown = await UpdateInvoices(invoicesGenerated, month);

            if (InvoicesShown != null && InvoicesShown.Count > 0)
            {
                foreach (Invoice invoice in InvoicesShown)
                {
                    if (invoice.Status == InvoiceStatus.Preview)
                    {

                        await GenerateInvoice(invoice.KidId, month);
                    }
                }
            }
            return RedirectToAction(nameof(Index), new { month = month });
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
                    GeneratedDate = DateTime.Now,
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
        public async Task<IActionResult> Preview(Invoice invoice)
        {
            Invoice invoiceToPreview = null;
            var _invoice = await _context.Invoices
                .Include(i => i.Kid.TutorPrincipal)
                .Include(i => i.Kid.Kindergarter)
                .Include("InvoiceDetails.Item")
                .FirstOrDefaultAsync(i => i.Id == invoice.Id);
            //var invoiceTest = await _context.Invoices
            //    .Include(i => i.Kid.TutorPrincipal)
            //    .Include("InvoiceDetails.Item")
            //    .SingleOrDefaultAsync(i => i.Id == new Guid("2083BC06-40EE-4445-A87C-F57D095E0693"));

            return View(_invoice);
        }

        public async Task<IActionResult> ReceiptPreview(Receipt receipt)
        {
            var _receipt = await _context.Receipt
                //.Include(i => i.Payments.Select(p=>p.Invoice.Kid.Kindergarter))
                .Include("Payments.Invoice.Kid.Kindergarter")
                .Include("Payments.Invoice.InvoiceDetails.Item")
                //.Include("InvoiceDetails.Item")
                .FirstOrDefaultAsync(i => i.Id == receipt.Id);
            //var invoiceTest = await _context.Invoices
            //    .Include(i => i.Kid.TutorPrincipal)
            //    .Include("InvoiceDetails.Item")
            //    .SingleOrDefaultAsync(i => i.Id == new Guid("2083BC06-40EE-4445-A87C-F57D095E0693"));

            return View(_receipt);
        }
        public async Task<IActionResult> Payment(Invoice invoice)
        {
            var payment = new Payment { InvoiceId = invoice.Id };
            var inv = await _context.Invoices
            .Include(i => i.Payments).Include(i => i.Kid.TutorPrincipal)
            .SingleOrDefaultAsync(i => i.Id == invoice.Id);

            decimal totalPaid = 0;
            decimal remaining = 0;
            if (inv.Payments != null && inv.Payments.Count > 0)
            {
                foreach (var pay in inv.Payments)
                {

                    totalPaid += pay.Amount;
                }
            }
            remaining = inv.Price - totalPaid;

            ViewData["doc"] = inv.Document;
            ViewData["remaining"] = remaining;
            ViewData["invoice"] = inv;
            return View(payment);
        }
        public async Task<IActionResult> PendingInvoices(int month)
        {
            List<InvoiceBalanceDTO> invoicesToReport = new List<InvoiceBalanceDTO>();
            var invoicesOfMonth = _context.Invoices
                .Include(i=>i.Kid.TutorPrincipal)
                .Include("InvoiceDetails.Item")
                .Where(i => i.DueDate.Month == month && i.Status != InvoiceStatus.Paid).ToList();
            foreach (var item in invoicesOfMonth)
            {
                if (item.Status == InvoiceStatus.PartialPaid)
                {
                    decimal sum = 0;
                    var receipts = _context.Receipt
                        .Where(r => r.AffectedDocument == item.Document);
                    if (receipts != null && receipts.Count() > 0)
                    {
                        sum = receipts.Sum(r => r.Amount);
                    }
                    var inv = new InvoiceBalanceDTO(item);
                    item.Price -= sum;
                    inv.Pending = item.Price - sum;
                    invoicesToReport.Add(inv);
                }
            }
            ViewData["h1"] = "Facturas pendientes";
            return View(invoicesOfMonth);
        }
        public async Task<IActionResult> MonthlyInvoices(int month)
        {
            List<InvoiceBalanceDTO> invoicesToReport = new List<InvoiceBalanceDTO>();
            var invoicesOfMonth = _context.Invoices
                .Include(i => i.Kid.TutorPrincipal)
                .Include("InvoiceDetails.Item")
                .Where(i => i.DueDate.Month == month).ToList();
            foreach (var item in invoicesOfMonth)
            {
                if (item.Status == InvoiceStatus.PartialPaid)
                {
                    decimal sum = 0;
                    var receipts = _context.Receipt
                        .Where(r => r.AffectedDocument == item.Document);
                    if (receipts != null && receipts.Count() > 0)
                    {
                        sum = receipts.Sum(r => r.Amount);
                    }
                    var inv = new InvoiceBalanceDTO(item);
                    item.Price -= sum;
                    inv.Pending = item.Price - sum;
                    invoicesToReport.Add(inv);
                }
            }
            ViewData["h1"] = "Facturas del mes";

            return View("PendingInvoices",invoicesOfMonth);
        }
        public async Task<IActionResult> InvoicesByActivity(int month)
        {
            List<InvoiceBalanceDTO> invoicesToReport = new List<InvoiceBalanceDTO>();
            var invoicesOfMonth = _context.Invoices
                .Include(i => i.Kid.TutorPrincipal)
                .Include("InvoiceDetails.Item")
                .Where(i => i.DueDate.Month == month).ToList();
            foreach (var item in invoicesOfMonth)
            {
                if (item.Status == InvoiceStatus.PartialPaid)
                {
                    decimal sum = 0;
                    var receipts = _context.Receipt
                        .Where(r => r.AffectedDocument == item.Document);
                    if (receipts != null && receipts.Count() > 0)
                    {
                        sum = receipts.Sum(r => r.Amount);
                    }
                    var inv = new InvoiceBalanceDTO(item);
                    item.Price -= sum;
                    inv.Pending = item.Price - sum;
                    invoicesToReport.Add(inv);
                }
            }
            ViewData["h1"] = "Facturas por servicio";

            return View("InvoicesByActivity", invoicesOfMonth);
        }
        public async Task<IActionResult> PendingInvoicesReport()
        {
            return View();
        }
        public async Task<IActionResult> MonthlyInvoicesReport()
        {
            return View();
        }
        public async Task<IActionResult> InvoicesByActivityReport()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Payment([Bind("Amount,InvoiceId")] Payment payment)
        {

            if (ModelState.IsValid)
            {
                var prefix = _context.Sequences.SingleOrDefault(s => s.DocumentType == DocumentType.Recipe).Prefix;
                var sequence = _context.Sequences.SingleOrDefault(s => s.DocumentType == DocumentType.Recipe);
                long nextSequence = sequence.StaringSequence > sequence.CurrentSequence ? sequence.StaringSequence : sequence.CurrentSequence + 1;

                var invoiceFound = _context.Invoices
                    .Include(i => i.Payments)
                    .Include(i => i.Kid.TutorPrincipal)
                    //.Include("Payments.Invoice.Kid.TutorPrincipal")
                    .SingleOrDefault(i => i.Id == payment.InvoiceId);
                decimal totalPaid = 0;
                decimal remaining = 0;
                if (invoiceFound.Payments != null && invoiceFound.Payments.Count > 0)
                {
                    foreach (var pay in invoiceFound.Payments)
                    {
                        totalPaid += pay.Amount;
                    }
                }
                remaining = invoiceFound.Price - totalPaid;
                if (payment.Amount > remaining)
                {

                    ViewData["invoice"] = invoiceFound;
                    ViewData["doc"] = invoiceFound.Document;
                    ViewData["remaining"] = remaining;
                    ViewData["Rango"] = "Se espera un monto menor a " + remaining.ToString();
                    return View();
                }
                Receipt receipt = new Receipt
                {
                    Id = Guid.NewGuid(),
                    GeneratedDate = DateTime.Now,
                    Sequence = nextSequence,
                    Amount = payment.Amount,
                    AffectedDocument = invoiceFound.Document

                };
                receipt.Document = prefix + receipt.SequenceString;


                //Payment paymentToInsert = new Payment
                //{
                //    Amount = payment.Amount,
                //    ReceiptId = receipt.Id
                //};

                //payment.ReceiptId = receipt.Id;


                //var invoiceFound = _context.Invoices.SingleOrDefault(i => i.Id == payment.InvoiceId);
                //_context.Attach<Invoice>(invoiceFound);
                //paymentToInsert.InvoiceId = invoiceFound.Id;
                //paymentToInsert.ReceiptId = receipt.Id;

                //receipt.Payments.Add(paymentToInsert);

                sequence.CurrentSequence = nextSequence;

                remaining -= receipt.Amount;
                if (remaining > 0)
                {
                    invoiceFound.Status = InvoiceStatus.PartialPaid;
                }
                else
                {
                    invoiceFound.Status = InvoiceStatus.Paid;
                }

                _context.Receipt.Add(receipt);
                payment.ReceiptId = receipt.Id;
                _context.Payment.Add(payment);
                _context.SaveChanges();
                TempData["remainding"] = remaining.ToString();
                return RedirectToAction(nameof(ReceiptPreview), receipt);

            }

            return View();
        }
        public async Task GeneratePDF(Invoice invoice)
        {
            string filePath = "C:\\Users\\gfajardo\\Downloads\\diploma-diseno-email.pdf";
            var credentials = new StorageCredentials("kindergarterinvoices", "av6Jd3a0s4QHPz0G0YXuPJYcpUdLntO9vxsRHL0EfQDGUsKF5YR/y4iU1bGQkUxjnnbVWz4G9ffyrROhKh+ncQ==");
            var client = new CloudBlobClient(new Uri("https://kindergarterinvoices.blob.core.windows.net/"), credentials);

            // Retrieve a reference to a container. (You need to create one using the mangement portal, or call container.CreateIfNotExists())
            var container = client.GetContainerReference("kphinvoices");
            // Retrieve reference to a blob named "myfile.pdf".
            var blockBlob = container.GetBlockBlobReference("diploma-diseno-email.pdf");

            // Create or overwrite the "myblob" blob with contents from a local file.
            using (var fileStream = System.IO.File.OpenRead(filePath))
            {
                await blockBlob.UploadFromStreamAsync(fileStream);
            }

        }
        public IActionResult CreatePDF()
        {
            // Create the 'Hello, World!' PDF:
            var doc = new GcPdfDocument();
            var page = doc.NewPage();
            var g = page.Graphics;
            g.DrawString("Hello, World!", new TextFormat() { Font = StandardFonts.Times }, new PointF(72, 72));

            // Save it to a memory stream:
            MemoryStream ms = new MemoryStream();
            doc.Save(ms);
            //ms.Seek(0, SeekOrigin.Begin);

            ///

            var credentials = new StorageCredentials("kindergarterinvoices", "av6Jd3a0s4QHPz0G0YXuPJYcpUdLntO9vxsRHL0EfQDGUsKF5YR/y4iU1bGQkUxjnnbVWz4G9ffyrROhKh+ncQ==");
            var client = new CloudBlobClient(new Uri("https://kindergarterinvoices.blob.core.windows.net/"), credentials);

            // Retrieve a reference to a container. (You need to create one using the mangement portal, or call container.CreateIfNotExists())
            var container = client.GetContainerReference("kphinvoices");
            // Retrieve reference to a blob named "myfile.pdf".
            var blockBlob = container.GetBlockBlobReference("diploma-diseno-email.pdf");
            blockBlob.Properties.ContentType = "application/pdf";


            blockBlob.UploadFromStreamAsync(ms);

            /////
            // Send it back to the web page:
            Response.Headers["Content-Disposition"] = "inline; filename=\"HelloWorld.pdf\"";
            return new FileStreamResult(ms, "application/pdf");
        }
        public void CreatePDF2()
        {
            var account = new CloudStorageAccount(new StorageCredentials("kindergarterinvoices", "av6Jd3a0s4QHPz0G0YXuPJYcpUdLntO9vxsRHL0EfQDGUsKF5YR/y4iU1bGQkUxjnnbVWz4G9ffyrROhKh+ncQ=="), true);
            var blobClient = account.CreateCloudBlobClient();
            var container = blobClient.GetContainerReference("kphinvoices");
            using (MemoryStream ms = new MemoryStream())
            {
                using (var doc = new iTextSharp.text.Document())
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, ms);
                    doc.Open();
                    doc.Add(new Paragraph("Hello World"));
                }
                var byteArray = ms.ToArray();
                var blobName = "hello-world.pdf";
                var blob = container.GetBlockBlobReference(blobName);
                blob.Properties.ContentType = "application/pdf";
                blob.UploadFromByteArrayAsync(byteArray, 0, byteArray.Length);
            }
        }
        //public async Task<IActionResult> Generate(Invoice invoice)
        //{
        //    invoice.Status = InvoiceStatus.Generated;
        //    await _context.Invoices.AddAsync(invoice);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
        private bool InvoiceExists(Guid id)
        {
            return _context.Invoices.Any(e => e.Id == id);
        }
    }
}

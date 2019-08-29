using GrapeCity.Documents.Pdf;
using GrapeCity.Documents.Text;
using iTextSharp.text;
using iTextSharp.text.pdf;
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

        public InvoicesController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: Invoices
        public async Task<IActionResult> Index()
        {
            //var kindergartenContext = _context.Invoices.Include(i => i.Kid);
            var invoicesGenerated = GenerateInvoices();

            foreach (var invoice in invoicesGenerated)
            {
                //foreach (var detail in invoice.InvoiceDetails)
                //{
                //    _context.InvoiceDetails.Add(detail);
                //}
                //_context.Invoices.Add(invoice);

            }
            await _context.SaveChangesAsync();

            var invoices = _context.Invoices.Include(i => i.Kid)
                .Where(i => i.GeneratedDate.Month == DateTime.Now.Month).ToList();
            var invoicesUpdated = await UpdateInvoices(invoicesGenerated);
            //var invoicesModified = await ModifieInvoices(invoicesGenerated);
            return View(invoicesUpdated.OrderBy(i => i.Sequence).ToList());
        }

        private async Task<List<Invoice>> UpdateInvoices(List<Invoice> invoicesGenerated)
        {
            foreach (var invoice in invoicesGenerated)
            {
                var invoiceFound = await _context.Invoices
                                        .Include(i => i.InvoiceDetails)
                                        .SingleOrDefaultAsync(i => i.KidId == invoice.KidId &&
                                                                   i.GeneratedDate.Month == DateTime.Now.Month);
                if (invoiceFound != null)
                {
                    invoice.Id = invoiceFound.Id;
                    invoice.Status = invoiceFound.Status;
                    invoice.Price = invoiceFound.Price;
                    invoice.GeneratedDate = invoiceFound.GeneratedDate;
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
        public List<Invoice> GenerateInvoices()
        {
            List<Invoice> invoices = new List<Invoice>();
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
                    decimal acumulativeAmount = 0;
                    var invoice = new Invoice
                    {
                        Status = InvoiceStatus.Preview,
                        GeneratedDate = DateTime.Now,
                        DueDate = new DateTime(
                        DateTime.Now.Year,
                        DateTime.Now.Month,
                        DateTime.DaysInMonth(
                            DateTime.Now.Year,
                            DateTime.Now.Month
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
                .SingleOrDefaultAsync(i => i.Id == invoice.Id);
            if (invoiceFound != null)
            {

                _context.InvoiceDetail.RemoveRange(invoiceFound.InvoiceDetails);

                _context.Invoices.Remove(invoiceFound);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Generate(Guid? id)
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
                        DateTime.Now.Month,
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
        public async Task<IActionResult> Payment()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Payment([Bind("Amount")] Payment payment)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));

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

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
    public class ReceiptsController : Controller
    {
        private readonly KindergarterContext _context;

        public ReceiptsController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: Receipts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Receipt.ToListAsync());
        }

        // GET: Receipts/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipt = await _context.Receipt
                .FirstOrDefaultAsync(m => m.Id == id);
            if (receipt == null)
            {
                return NotFound();
            }

            return View(receipt);
        }

        // GET: Receipts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Receipts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Sequence,Document,GeneratedDate,Amount,AffectedDocument,Id")] Receipt receipt)
        {
            if (ModelState.IsValid)
            {
                receipt.Id = Guid.NewGuid();
                _context.Add(receipt);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(receipt);
        }

        // GET: Receipts/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipt = await _context.Receipt.FindAsync(id);
            if (receipt == null)
            {
                return NotFound();
            }
            return View(receipt);
        }

        // POST: Receipts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Sequence,Document,GeneratedDate,Amount,AffectedDocument,Id")] Receipt receipt)
        {
            if (id != receipt.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receipt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceiptExists(receipt.Id))
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
            return View(receipt);
        }

        // GET: Receipts/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var receipt = await _context.Receipt
                .FirstOrDefaultAsync(m => m.Id == id);
            if (receipt == null)
            {
                return NotFound();
            }

            return View(receipt);
        }

        // POST: Receipts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var receipt = await _context.Receipt.FindAsync(id);
            var invoice = await _context.Invoices.Include("Payments.Receipt")
                .SingleOrDefaultAsync(i => i.Document == receipt.AffectedDocument);

            if (invoice.Payments.Count == 1)
            {
                if (invoice.Payments.First().ReceiptId == id)
                {
                    invoice.Status = InvoiceStatus.Generated;
                }
            }else if(invoice.Payments.Count > 1)
            {
                invoice.Status = InvoiceStatus.PartialPaid;

            }

            _context.Receipt.Remove(receipt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Preview(Receipt receipt)
        {
            var receiptToPreview = await _context.Receipt
                .Include("Payments.Invoice.Kid.Kindergarter")
                .Include("Payments.Invoice.InvoiceDetails.Item")
                .SingleOrDefaultAsync(r => r.Id == receipt.Id);
            return View(receiptToPreview);
        }
        public async Task<IActionResult> PreviewInvoice(string invoiceDocument)
        {
            var invoiceToPreview = await _context.Invoices
                .Include(i => i.Kid.TutorPrincipal)
                .Include(i => i.Kid.Kindergarter)
                .Include("InvoiceDetails.Item")
                .SingleOrDefaultAsync(i=>i.Document == invoiceDocument);
            if (invoiceToPreview != null)
            {
                return RedirectToAction("Preview", "Invoices", invoiceToPreview);
            }
            return View(nameof(Index));
        }
        private bool ReceiptExists(Guid id)
        {
            return _context.Receipt.Any(e => e.Id == id);
        }
    }
}

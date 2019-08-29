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
    public class SequencesController : Controller
    {
        private readonly KindergarterContext _context;

        public SequencesController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: Sequences
        public async Task<IActionResult> Index()
        {
            return View(await _context.Sequences.ToListAsync());
        }

        // GET: Sequences/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sequence = await _context.Sequences
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sequence == null)
            {
                return NotFound();
            }

            return View(sequence);
        }

        // GET: Sequences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sequences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StaringSequence,CurrentSequence,Prefix,DocumentType,Id")] Sequence sequence)
        {
            if (ModelState.IsValid)
            {
                sequence.Id = Guid.NewGuid();
                _context.Add(sequence);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(sequence);
        }

        // GET: Sequences/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sequence = await _context.Sequences.FindAsync(id);
            if (sequence == null)
            {
                return NotFound();
            }
            return View(sequence);
        }

        // POST: Sequences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("StaringSequence,CurrentSequence,Prefix,DocumentType,Id")] Sequence sequence)
        {
            if (id != sequence.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sequence);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SequenceExists(sequence.Id))
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
            return View(sequence);
        }

        // GET: Sequences/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sequence = await _context.Sequences
                .FirstOrDefaultAsync(m => m.Id == id);
            if (sequence == null)
            {
                return NotFound();
            }

            return View(sequence);
        }

        // POST: Sequences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var sequence = await _context.Sequences.FindAsync(id);
            _context.Sequences.Remove(sequence);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SequenceExists(Guid id)
        {
            return _context.Sequences.Any(e => e.Id == id);
        }
    }
}

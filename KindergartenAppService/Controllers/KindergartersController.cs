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
    public class KindergartersController : Controller
    {
        private readonly KindergarterContext _context;

        public KindergartersController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: Kindergarters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kindergarters.ToListAsync());
        }

        // GET: Kindergarters/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kindergarter = await _context.Kindergarters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kindergarter == null)
            {
                return NotFound();
            }

            return View(kindergarter);
        }

        // GET: Kindergarters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kindergarters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,Id")] Kindergarter kindergarter)
        {
            if (ModelState.IsValid)
            {
                kindergarter.Id = Guid.NewGuid();
                _context.Add(kindergarter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kindergarter);
        }

        // GET: Kindergarters/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kindergarter = await _context.Kindergarters.FindAsync(id);
            if (kindergarter == null)
            {
                return NotFound();
            }
            return View(kindergarter);
        }

        // POST: Kindergarters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Description,Id")] Kindergarter kindergarter)
        {
            if (id != kindergarter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kindergarter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KindergarterExists(kindergarter.Id))
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
            return View(kindergarter);
        }

        // GET: Kindergarters/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kindergarter = await _context.Kindergarters
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kindergarter == null)
            {
                return NotFound();
            }

            return View(kindergarter);
        }

        // POST: Kindergarters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var kindergarter = await _context.Kindergarters.FindAsync(id);
            _context.Kindergarters.Remove(kindergarter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KindergarterExists(Guid id)
        {
            return _context.Kindergarters.Any(e => e.Id == id);
        }
    }
}

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
    public class PediatriciansController : Controller
    {
        private readonly KindergarterContext _context;

        public PediatriciansController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: Pediatricians
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pediatrician.ToListAsync());
        }

        // GET: Pediatricians/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pediatrician = await _context.Pediatrician
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pediatrician == null)
            {
                return NotFound();
            }

            return View(pediatrician);
        }

        // GET: Pediatricians/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pediatricians/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Address,PhoneNumber,Id")] Pediatrician pediatrician)
        {
            if (ModelState.IsValid)
            {
                pediatrician.Id = Guid.NewGuid();
                _context.Add(pediatrician);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pediatrician);
        }

        // GET: Pediatricians/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pediatrician = await _context.Pediatrician.FindAsync(id);
            if (pediatrician == null)
            {
                return NotFound();
            }
            return View(pediatrician);
        }

        // POST: Pediatricians/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Name,Address,PhoneNumber,Id")] Pediatrician pediatrician)
        {
            if (id != pediatrician.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pediatrician);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PediatricianExists(pediatrician.Id))
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
            return View(pediatrician);
        }

        // GET: Pediatricians/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pediatrician = await _context.Pediatrician
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pediatrician == null)
            {
                return NotFound();
            }

            return View(pediatrician);
        }

        // POST: Pediatricians/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var pediatrician = await _context.Pediatrician.FindAsync(id);
            _context.Pediatrician.Remove(pediatrician);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PediatricianExists(Guid id)
        {
            return _context.Pediatrician.Any(e => e.Id == id);
        }
    }
}

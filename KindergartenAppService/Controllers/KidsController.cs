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
    public class KidsController : Controller
    {
        private readonly KindergarterContext _context;

        public KidsController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: Kids
        public async Task<IActionResult> Index()
        {
            var kindergarterContext = _context.Kid.Include(k => k.Kindergarter);
            return View(await kindergarterContext.ToListAsync());
        }

        // GET: Kids/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kid = await _context.Kid
                .Include(k => k.Kindergarter)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kid == null)
            {
                return NotFound();
            }

            return View(kid);
        }

        // GET: Kids/Create
        public IActionResult Create()
        {
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Id");
            return View();
        }

        // POST: Kids/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("FirstName,SecondName,FatherName,MotherName,KindergarterId,Id")] Kid kid)
        {
            if (ModelState.IsValid)
            {
                kid.Id = Guid.NewGuid();
                _context.Add(kid);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                //ViewBag.MensajeCreado = "El niño ha sido creado exitosamente";
                //ViewData["Mensaje"] = "El niño ha sido creado exitosamente";
                TempData["TempMessage"] = "Mensaje desde temp.";
                return RedirectToAction(nameof(Details), kid);
                //return View("Details",kid);
            }
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Id", kid.KindergarterId);
            return View(kid);
        }

        // GET: Kids/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kid = await _context.Kid.FindAsync(id);
            if (kid == null)
            {
                return NotFound();
            }
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Id", kid.KindergarterId);
            return View(kid);
        }

        // POST: Kids/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("FirstName,SecondName,FatherName,MotherName,KindergarterId,Id")] Kid kid)
        {
            if (id != kid.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kid);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KidExists(kid.Id))
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
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Id", kid.KindergarterId);
            return View(kid);
        }

        // GET: Kids/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kid = await _context.Kid
                .Include(k => k.Kindergarter)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (kid == null)
            {
                return NotFound();
            }

            return View(kid);
        }

        // POST: Kids/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var kid = await _context.Kid.FindAsync(id);
            _context.Kid.Remove(kid);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KidExists(Guid id)
        {
            return _context.Kid.Any(e => e.Id == id);
        }
    }
}

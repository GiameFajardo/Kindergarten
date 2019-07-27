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
    public class ActivityTemplatesController : Controller
    {
        private readonly KindergarterContext _context;

        public ActivityTemplatesController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: ActivityTemplates
        public async Task<IActionResult> Index()
        {
            var kindergarterContext = _context.ActivityTemplate.Include(a => a.Kindergarter);
            return View(await kindergarterContext.ToListAsync());
        }

        // GET: ActivityTemplates/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityTemplate = await _context.ActivityTemplate
                .Include(a => a.Kindergarter)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activityTemplate == null)
            {
                return NotFound();
            }

            return View(activityTemplate);
        }

        // GET: ActivityTemplates/Create
        public IActionResult Create()
        {
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Description");
            return View();
        }

        // POST: ActivityTemplates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Description,KindergarterId,Id")] ActivityTemplate activityTemplate)
        {
            if (ModelState.IsValid)
            {
                activityTemplate.Id = Guid.NewGuid();
                _context.Add(activityTemplate);
                await _context.SaveChangesAsync();
                TempData["SuccessfulMessage"] = "La plantilla se ha creado satisfactoriamente";

                return RedirectToAction(nameof(Details),activityTemplate);
            }
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Id", activityTemplate.KindergarterId);
            return View(activityTemplate);
        }

        // GET: ActivityTemplates/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityTemplate = await _context.ActivityTemplate.FindAsync(id);
            if (activityTemplate == null)
            {
                return NotFound();
            }
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Description", activityTemplate.KindergarterId);
            return View(activityTemplate);
        }

        // POST: ActivityTemplates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Description,KindergarterId,Id")] ActivityTemplate activityTemplate)
        {
            if (id != activityTemplate.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activityTemplate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActivityTemplateExists(activityTemplate.Id))
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
            ViewData["KindergarterId"] = new SelectList(_context.Kindergarters, "Id", "Id", activityTemplate.KindergarterId);
            return View(activityTemplate);
        }

        // GET: ActivityTemplates/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activityTemplate = await _context.ActivityTemplate
                .Include(a => a.Kindergarter)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activityTemplate == null)
            {
                return NotFound();
            }

            return View(activityTemplate);
        }

        // POST: ActivityTemplates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var activityTemplate = await _context.ActivityTemplate.FindAsync(id);
            _context.ActivityTemplate.Remove(activityTemplate);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActivityTemplateExists(Guid id)
        {
            return _context.ActivityTemplate.Any(e => e.Id == id);
        }
    }
}

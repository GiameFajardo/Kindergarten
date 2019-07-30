﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using KindergartenAppService.Models;

namespace KindergartenAppService.Controllers
{
    public class EnrollActivitiesController : Controller
    {
        private readonly KindergarterContext _context;

        public EnrollActivitiesController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: EnrollActivities
        public async Task<IActionResult> Index()
        {
            var kindergarterContext = _context.EnrollActivity.Include(e => e.Activity).Include(e => e.Enrollment);
            return View(await kindergarterContext.ToListAsync());
        }

        // GET: EnrollActivities/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollActivity = await _context.EnrollActivity
                .Include(e => e.Activity)
                .Include(e => e.Enrollment)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enrollActivity == null)
            {
                return NotFound();
            }

            return View(enrollActivity);
        }

        // GET: EnrollActivities/Create
        public IActionResult Create()
        {
            ViewData["ActivityId"] = new SelectList(_context.Activity, "Id", "Description");
            ViewData["EnrollmentId"] = new SelectList(_context.Enrollments, "Id", "Id");
            return View();
        }

        // POST: EnrollActivities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ActivityId,EnrollmentId,Id")] EnrollActivity enrollActivity)
        {
            if (ModelState.IsValid)
            {
                enrollActivity.Id = Guid.NewGuid();
                _context.Add(enrollActivity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActivityId"] = new SelectList(_context.Activity, "Id", "Description", enrollActivity.ActivityId);
            ViewData["EnrollmentId"] = new SelectList(_context.Enrollments, "Id", "Id", enrollActivity.EnrollmentId);
            return View(enrollActivity);
        }

        // GET: EnrollActivities/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollActivity = await _context.EnrollActivity.FindAsync(id);
            if (enrollActivity == null)
            {
                return NotFound();
            }
            ViewData["ActivityId"] = new SelectList(_context.Activity, "Id", "Description", enrollActivity.ActivityId);
            ViewData["EnrollmentId"] = new SelectList(_context.Enrollments, "Id", "Id", enrollActivity.EnrollmentId);
            return View(enrollActivity);
        }

        // POST: EnrollActivities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("ActivityId,EnrollmentId,Id")] EnrollActivity enrollActivity)
        {
            if (id != enrollActivity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(enrollActivity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EnrollActivityExists(enrollActivity.Id))
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
            ViewData["ActivityId"] = new SelectList(_context.Activity, "Id", "Description", enrollActivity.ActivityId);
            ViewData["EnrollmentId"] = new SelectList(_context.Enrollments, "Id", "Id", enrollActivity.EnrollmentId);
            return View(enrollActivity);
        }

        // GET: EnrollActivities/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var enrollActivity = await _context.EnrollActivity
                .Include(e => e.Activity)
                .Include(e => e.Enrollment)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (enrollActivity == null)
            {
                return NotFound();
            }

            return View(enrollActivity);
        }

        // POST: EnrollActivities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var enrollActivity = await _context.EnrollActivity.FindAsync(id);
            _context.EnrollActivity.Remove(enrollActivity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EnrollActivityExists(Guid id)
        {
            return _context.EnrollActivity.Any(e => e.Id == id);
        }
    }
}
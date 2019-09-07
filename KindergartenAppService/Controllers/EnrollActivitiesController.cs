using KindergartenAppService.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            var kindergarterContext = _context.EnrollActivity.Include(e => e.Activity).Include(e => e.Enrollment.Kid);
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
                .Include(e => e.Enrollment.Kid)
                .Include(e=>e.Service)
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
            if (TempData["Enroll"] != null)
            {
                var enroll = _context.Enrollments.FindAsync(TempData["Enroll"]).Result;
                Guid activityId = new Guid();
                var activities = _context.Activity;
                ViewData["ActivityId"] = new SelectList(activities, "Id", "Description");


                ViewData["EnrollmentId"] = new SelectList(_context.Enrollments.Include(e=>e.Kid), "Id", "Kid.FullName");

                if (activities.ToList().Count > 0)
                {
                    if(TempData["Activity"]!= null)
                    {
                        var id = TempData["Activity"].ToString();
                        activityId = new Guid(id);
                        ViewData["ServiceId"] = new SelectList(_context.Service
                           .Where(s => s.ActivityId == activityId), "Id", "PriceDescription");
                    }
                    else
                    {
                        ViewData["ServiceId"] = new SelectList(_context.Service
                            .Where(s=>s.ActivityId == activities.First().Id), "Id", "PriceDescription");
                    }
                }

                if (enroll != null)
                {
                    EnrollActivity enrollActivity = new EnrollActivity();
                    if (activityId != null)
                    {

                        enrollActivity = new EnrollActivity { EnrollmentId = enroll.Id , ActivityId = activityId};
                    }
                    else
                    {
                        enrollActivity = new EnrollActivity { EnrollmentId = enroll.Id };

                    }
                    ViewBag.CameFromKid = TempData["CameFromKid"];
                    return View(enrollActivity);
                }

                return View();
            }

            if(TempData["Enroll"] != null)
            {

            }
            ViewData["ActivityId"] = new SelectList(_context.Activity, "Id", "Description");
            ViewData["EnrollmentId"] = new SelectList(_context.Enrollments.Include(e => e.Kid), "Id", "Kid.FullName");
            ViewBag.CameFromKid = TempData["CameFromKid"];
            return View();
        }

        // POST: EnrollActivities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ServiceId,ActivityId,EnrollmentId,Id")] EnrollActivity enrollActivity)
        {
            
            if (ModelState.IsValid)
            {
                enrollActivity.Id = Guid.NewGuid();
                _context.Add(enrollActivity);
                await _context.SaveChangesAsync();
                var enrollment = await _context.Enrollments.SingleOrDefaultAsync(e => e.Id == enrollActivity.EnrollmentId);
                var kidId = await  _context.Kid.SingleOrDefaultAsync(k => k.Enrollment.Id == enrollment.Id);
                if (TempData["ComeFromKid"] != null)
                {
                    
                    return RedirectToAction("Details", "Kids",kidId);
                }
                else
                {
                    return RedirectToAction(nameof(Index));

                }
            }
            ViewData["ActivityId"] = new SelectList(_context.Activity, "Id", "Description", enrollActivity.ActivityId);
            ViewData["EnrollmentId"] = new SelectList(_context.Enrollments.Include(i=>i.Kid), "Id", "Kid.FullName", enrollActivity.EnrollmentId);
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
            ViewData["EnrollmentId"] = new SelectList(_context.Enrollments.Include(e => e.Kid), "Id", "Kid.FullName");

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
            ViewData["EnrollmentId"] = new SelectList(_context.Enrollments.Include(e => e.Kid), "Id", "Kid.FullName");
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
                .Include(e => e.Enrollment.Kid)
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
        //public async Task<IActionResult> AddService(string a)
        //{
        //    var param = a;
        //    return RedirectToAction(nameof(Index));
        //}
        //[HttpPost, ActionName("AddService")]
        public async Task<IActionResult> AddService(string a, string b)
        {

            var data2 = JsonConvert.DeserializeObject<String>(a);
            Guid id = new Guid(data2);
            Guid activityId = new Guid(b);
            var enrollment = await _context.Enrollments.FindAsync(id);
            var services = _context.Service.Where(s => s.ActivityId == activityId);
            var enrollActivity = new EnrollActivity
            {
                EnrollmentId = enrollment.Id,
                ActivityId = activityId
            };
            TempData["CameFromKid"] = "true";
            TempData["Enroll"] = enrollment.Id;
            TempData["Activity"] = activityId;
            return RedirectToAction("Create", "EnrollActivities",enrollActivity);
        }
        public async Task<IActionResult> KidPerServiceReport()
        {

            ViewData["Activities"] = new SelectList(_context.Activity, "Id", "Description");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> KidPerServiceReport(EnrollActivity ea)
        {

            if (ea.ActivityId != Guid.Empty)
            {

                ViewData["Activities"] = new SelectList(_context.Activity, "Id", "Description");
                return RedirectToAction("Report", ea);
            }

            ViewData["Activities"] = new SelectList(_context.Activity, "Id", "Description");
            return View(ea);
        }
        public async Task<IActionResult> Report(EnrollActivity ea)
        {

            Activity activity = await _context.Activity.FindAsync(ea.ActivityId);
            TempData["Activity"] = activity.Description;

            var result = (from kid in _context.Kid
                              join enrollment in _context.Enrollments 
                                on kid.Id equals enrollment.KidId
                              join enrollActivity in _context.EnrollActivity.Include(e=>e.Enrollment.Kid.TutorPrincipal).Include(e=>e.Service) 
                                on enrollment.Id equals enrollActivity.EnrollmentId
                              join activit in _context.Activity 
                                on enrollActivity.ActivityId equals activit.Id
                          where activit.Id == ea.ActivityId
                          select enrollActivity).ToList();
        
            //var enrolls = new List<EnrollActivity>() { new EnrollActivity { Id = Guid.NewGuid() } };
            return View(result);
        }
    }
}

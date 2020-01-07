using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KindergartenAppService.Models;

namespace KindergartenAppService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KidController : ControllerBase
    {
        private readonly KindergarterContext _context;

        public KidController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: api/Kid
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Kid>>> GetKid()
        {
            try
            {

            var kids = await _context.Kid
                    //.Include(k => k.Enrollment)
                    .Include(k => k.TutorPrincipal)
                    .Include(k => k.TutorSecundary)
                    .Include(k => k.TutorAutorized)
                    .Include(k => k.Pediatrician.Name)
                    //.Include(k => k.Kindergarter)
                    .ToListAsync();
                return kids;
            }
            catch (Exception ex)
            {

                
            }
            return await _context.Kid.ToListAsync();

        }

        // GET: api/Kid/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Kid>> GetKid(Guid id)
        {
            var kid = await _context.Kid.FindAsync(id);

            if (kid == null)
            {
                return NotFound();
            }

            return kid;
        }

        // PUT: api/Kid/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKid(Guid id, Kid kid)
        {
            if (id != kid.Id)
            {
                return BadRequest();
            }

            _context.Entry(kid).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KidExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Kid
        [HttpPost]
        public async Task<ActionResult<Kid>> PostKid(Kid kid)
        {
            try
            {
            _context.Kid.Add(kid);
            await _context.SaveChangesAsync();

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message + ex.InnerException.Message);
            }

            return CreatedAtAction("GetKid", new { id = kid.Id }, kid);
        }

        // DELETE: api/Kid/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Kid>> DeleteKid(Guid id)
        {
            var kid = await _context.Kid.FindAsync(id);
            if (kid == null)
            {
                return NotFound();
            }

            _context.Kid.Remove(kid);
            await _context.SaveChangesAsync();

            return kid;
        }

        private bool KidExists(Guid id)
        {
            return _context.Kid.Any(e => e.Id == id);
        }
    }
}

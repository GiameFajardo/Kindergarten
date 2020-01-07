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
    public class PediatricianController : ControllerBase
    {
        private readonly KindergarterContext _context;

        public PediatricianController(KindergarterContext context)
        {
            _context = context;
        }

        // GET: api/Pediatrician
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pediatrician>>> GetPediatrician()
        {
            return await _context.Pediatrician.ToListAsync();
        }

        // GET: api/Pediatrician/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Pediatrician>> GetPediatrician(Guid id)
        {
            var pediatrician = await _context.Pediatrician.FindAsync(id);

            if (pediatrician == null)
            {
                return NotFound();
            }

            return pediatrician;
        }

        // PUT: api/Pediatrician/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPediatrician(Guid id, Pediatrician pediatrician)
        {
            if (id != pediatrician.Id)
            {
                return BadRequest();
            }

            _context.Entry(pediatrician).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PediatricianExists(id))
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

        // POST: api/Pediatrician
        [HttpPost]
        public async Task<ActionResult<Pediatrician>> PostPediatrician(Pediatrician pediatrician)
        {
            _context.Pediatrician.Add(pediatrician);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPediatrician", new { id = pediatrician.Id }, pediatrician);
        }

        // DELETE: api/Pediatrician/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Pediatrician>> DeletePediatrician(Guid id)
        {
            var pediatrician = await _context.Pediatrician.FindAsync(id);
            if (pediatrician == null)
            {
                return NotFound();
            }

            _context.Pediatrician.Remove(pediatrician);
            await _context.SaveChangesAsync();

            return pediatrician;
        }

        private bool PediatricianExists(Guid id)
        {
            return _context.Pediatrician.Any(e => e.Id == id);
        }
    }
}

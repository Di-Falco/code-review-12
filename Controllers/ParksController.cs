using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksDirectory.Models;

namespace ParksDirectory.Solution.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParksController : ControllerBase
    {
        private readonly ParkContext _context;

        public ParksController(ParkContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string location, string description)
        {
            var query = _context.Parks.AsQueryable();
            
            if (name != null)
            { query = query.Where(entry => entry.Name == name); }

            if (location != null)
            { query = query.Where(entry => entry.Location == location); }

            if (description != null)
            { query = query.Where(entry => entry.Description.Contains(description)); }

            return await query.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Park>> GetPark(int id)
        {
            var park = await _context.Parks.FindAsync(id);

            if (park == null)
            { return NotFound(); }

            return park;
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutPark(int id, Park park)
        {
            if (id != park.ParkId)
            { return BadRequest(); }

            _context.Entry(park).State = EntityState.Modified;

            try 
            { await _context.SaveChangesAsync(); }
            catch (DbUpdateConcurrencyException)
            { 
                if(!ParkExists(id))
                { return NotFound(); }

                else
                { throw; }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Park>> PostPark(Park park)
        {
            _context.Parks.Add(park);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPark", new { id = park.ParkId }, park);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePark(int id)
        {
            var park = await _context.Parks.FindAsync(id);
            if (park == null)
            { return NotFound();}

            _context.Parks.Remove(park);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ParkExists(int id)
        {
            return _context.Parks.Any(e => e.ParkId == id);
        }
    }
}

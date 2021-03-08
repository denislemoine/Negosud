using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NegoduxAPI.Data;
using NegoduxAPI.Models;

namespace NegoduxAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamillesController : ControllerBase
    {
        private readonly NegoduxAPIContext _context;

        public FamillesController(NegoduxAPIContext context)
        {
            _context = context;
        }

        // GET: api/Familles
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Famille>>> GetFamille()
        {
            return await _context.Famille.ToListAsync();
        }

        // GET: api/Familles/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Famille>> GetFamille(long id)
        {
            var famille = await _context.Famille.FindAsync(id);

            if (famille == null)
            {
                return NotFound();
            }

            return famille;
        }

        // PUT: api/Familles/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFamille(long id, Famille famille)
        {
            if (id != famille.Id)
            {
                return BadRequest();
            }

            _context.Entry(famille).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FamilleExists(id))
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

        // POST: api/Familles
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Famille>> PostFamille(Famille famille)
        {
            _context.Famille.Add(famille);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFamille", new { id = famille.Id }, famille);
        }

        // DELETE: api/Familles/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFamille(long id)
        {
            var famille = await _context.Famille.FindAsync(id);
            if (famille == null)
            {
                return NotFound();
            }

            _context.Famille.Remove(famille);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FamilleExists(long id)
        {
            return _context.Famille.Any(e => e.Id == id);
        }
    }
}

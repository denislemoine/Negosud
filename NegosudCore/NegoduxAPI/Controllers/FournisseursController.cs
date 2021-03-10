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
    public class FournisseursController : ControllerBase
    {
        private readonly NegoduxAPIContext _context;

        public FournisseursController(NegoduxAPIContext context)
        {
            _context = context;
        }

        // GET: api/Fournisseurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fournisseur>>> GetFournisseur()
        {
            return await _context.Fournisseur.Where(result => result.IsActive == true).ToListAsync();
        }

        // GET: api/Fournisseurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fournisseur>> GetFournisseur(long id)
        {
            var fournisseur = await _context.Fournisseur.FindAsync(id);

            if (fournisseur == null)
            {
                return NotFound();
            }

            return fournisseur;
        }

        // PUT: api/Fournisseurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFournisseur(long id, Fournisseur fournisseur)
        {
            if (id != fournisseur.Id)
            {
                return BadRequest();
            }

            _context.Entry(fournisseur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FournisseurExists(id))
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

        // POST: api/Fournisseurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Fournisseur>> PostFournisseur(Fournisseur fournisseur)
        {
            _context.Fournisseur.Add(fournisseur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFournisseur", new { id = fournisseur.Id }, fournisseur);
        }

        // DELETE: api/Fournisseurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFournisseur(long id)
        {
            var fournisseur = await _context.Fournisseur.FindAsync(id);
            if (fournisseur == null)
            {
                return NotFound();
            }

            _context.Fournisseur.Remove(fournisseur);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FournisseurExists(long id)
        {
            return _context.Fournisseur.Any(e => e.Id == id);
        }
    }
}

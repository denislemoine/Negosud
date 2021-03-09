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
    public class ProduitFournisseursController : ControllerBase
    {
        private readonly NegoduxAPIContext _context;

        public ProduitFournisseursController(NegoduxAPIContext context)
        {
            _context = context;
        }

        // GET: api/ProduitFournisseurs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProduitFournisseur>>> GetProduitFournisseur()
        {
            return await _context.ProduitFournisseur.ToListAsync();
        }

        // GET: api/ProduitFournisseurs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProduitFournisseur>> GetProduitFournisseur(long id)
        {
            var produitFournisseur = await _context.ProduitFournisseur.FindAsync(id);

            if (produitFournisseur == null)
            {
                return NotFound();
            }

            return produitFournisseur;
        }

        // PUT: api/ProduitFournisseurs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduitFournisseur(long id, ProduitFournisseur produitFournisseur)
        {
            if (id != produitFournisseur.Id)
            {
                return BadRequest();
            }

            _context.Entry(produitFournisseur).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProduitFournisseurExists(id))
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

        // POST: api/ProduitFournisseurs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ProduitFournisseur>> PostProduitFournisseur(ProduitFournisseur produitFournisseur)
        {
            _context.ProduitFournisseur.Add(produitFournisseur);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduitFournisseur", new { id = produitFournisseur.Id }, produitFournisseur);
        }

        // DELETE: api/ProduitFournisseurs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduitFournisseur(long id)
        {
            var produitFournisseur = await _context.ProduitFournisseur.FindAsync(id);
            if (produitFournisseur == null)
            {
                return NotFound();
            }

            _context.ProduitFournisseur.Remove(produitFournisseur);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProduitFournisseurExists(long id)
        {
            return _context.ProduitFournisseur.Any(e => e.Id == id);
        }
    }
}

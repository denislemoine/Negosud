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
    public class CommandeInterneProduitsController : ControllerBase
    {
        private readonly NegoduxAPIContext _context;

        public CommandeInterneProduitsController(NegoduxAPIContext context)
        {
            _context = context;
        }

        // GET: api/CommandeInterneProduits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommandeInterneProduit>>> GetCommandeInterneProduit()
        {
            return await _context.CommandeInterneProduit.ToListAsync();
        }

        // GET: api/CommandeInterneProduits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommandeInterneProduit>> GetCommandeInterneProduit(long id)
        {
            var commandeInterneProduit = await _context.CommandeInterneProduit.FindAsync(id);

            if (commandeInterneProduit == null)
            {
                return NotFound();
            }

            return commandeInterneProduit;
        }

        // PUT: api/CommandeInterneProduits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommandeInterneProduit(long id, CommandeInterneProduit commandeInterneProduit)
        {
            if (id != commandeInterneProduit.Id)
            {
                return BadRequest();
            }

            _context.Entry(commandeInterneProduit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommandeInterneProduitExists(id))
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

        // POST: api/CommandeInterneProduits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CommandeInterneProduit>> PostCommandeInterneProduit(CommandeInterneProduit commandeInterneProduit)
        {
            _context.CommandeInterneProduit.Add(commandeInterneProduit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommandeInterneProduit", new { id = commandeInterneProduit.Id }, commandeInterneProduit);
        }

        // DELETE: api/CommandeInterneProduits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommandeInterneProduit(long id)
        {
            var commandeInterneProduit = await _context.CommandeInterneProduit.FindAsync(id);
            if (commandeInterneProduit == null)
            {
                return NotFound();
            }

            _context.CommandeInterneProduit.Remove(commandeInterneProduit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommandeInterneProduitExists(long id)
        {
            return _context.CommandeInterneProduit.Any(e => e.Id == id);
        }
    }
}

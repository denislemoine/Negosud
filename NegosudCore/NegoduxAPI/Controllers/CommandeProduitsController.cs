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
    public class CommandeProduitsController : ControllerBase
    {
        private readonly NegoduxAPIContext _context;

        public CommandeProduitsController(NegoduxAPIContext context)
        {
            _context = context;
        }

        // GET: api/CommandeProduits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommandeProduit>>> GetCommandeProduit()
        {
            return await _context.CommandeProduit.ToListAsync();
        }

        // GET: api/CommandeProduits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommandeProduit>> GetCommandeProduit(long id)
        {
            var commandeProduit = await _context.CommandeProduit.FindAsync(id);

            if (commandeProduit == null)
            {
                return NotFound();
            }

            return commandeProduit;
        }

        // PUT: api/CommandeProduits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommandeProduit(long id, CommandeProduit commandeProduit)
        {
            if (id != commandeProduit.Id)
            {
                return BadRequest();
            }

            _context.Entry(commandeProduit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommandeProduitExists(id))
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

        // POST: api/CommandeProduits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CommandeProduit>> PostCommandeProduit(CommandeProduit commandeProduit)
        {
            _context.CommandeProduit.Add(commandeProduit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommandeProduit", new { id = commandeProduit.Id }, commandeProduit);
        }

        // DELETE: api/CommandeProduits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommandeProduit(long id)
        {
            var commandeProduit = await _context.CommandeProduit.FindAsync(id);
            if (commandeProduit == null)
            {
                return NotFound();
            }

            _context.CommandeProduit.Remove(commandeProduit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommandeProduitExists(long id)
        {
            return _context.CommandeProduit.Any(e => e.Id == id);
        }
    }
}

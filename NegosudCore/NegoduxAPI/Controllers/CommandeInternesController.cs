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
    public class CommandeInternesController : ControllerBase
    {
        private readonly NegoduxAPIContext _context;

        public CommandeInternesController(NegoduxAPIContext context)
        {
            _context = context;
        }

        // GET: api/CommandeInternes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommandeInterne>>> GetCommandeInterne()
        {
            return await _context.CommandeInterne.ToListAsync();
        }

        // GET: api/CommandeInternes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CommandeInterne>> GetCommandeInterne(int id)
        {
            var commandeInterne = await _context.CommandeInterne.FindAsync(id);

            if (commandeInterne == null)
            {
                return NotFound();
            }

            return commandeInterne;
        }

        // PUT: api/CommandeInternes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCommandeInterne(int id, CommandeInterne commandeInterne)
        {
            if (id != commandeInterne.Id)
            {
                return BadRequest();
            }

            _context.Entry(commandeInterne).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CommandeInterneExists(id))
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

        // POST: api/CommandeInternes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CommandeInterne>> PostCommandeInterne(CommandeInterne commandeInterne)
        {
            _context.CommandeInterne.Add(commandeInterne);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCommandeInterne", new { id = commandeInterne.Id }, commandeInterne);
        }

        // DELETE: api/CommandeInternes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCommandeInterne(int id)
        {
            var commandeInterne = await _context.CommandeInterne.FindAsync(id);
            if (commandeInterne == null)
            {
                return NotFound();
            }

            _context.CommandeInterne.Remove(commandeInterne);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CommandeInterneExists(int id)
        {
            return _context.CommandeInterne.Any(e => e.Id == id);
        }
    }
}

using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MYPROJECT.Models;  // Ensure this matches your namespace
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MYPROJECT.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("AllowCorsPolicy")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly DonationDBContext _context;

        // Inject the DonationDBContext into the controller
        public CandidateController(DonationDBContext context)
        {
            _context = context;
        }

        // GET: api/Candidate
        [Route("GetCandidates")]
        [HttpGet]
       
        public async Task<ActionResult<IEnumerable<Dcondidates>>> GetCandidates()
        {
            // Return all candidates from the database
            return await _context.Dcondidates.ToListAsync();
        }

        // GET: api/Candidate/{id}
        
        [HttpGet("{id}")]

        public async Task<ActionResult<Dcondidates>> GetCandidate(int id)
        {
            // Find the candidate by id
            try
            {
                var candidate = await _context.Dcondidates.FindAsync(id);

                if (candidate == null)
                {
                    return NotFound();
                }

                return candidate;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        // POST: api/Candidate
        [HttpPost]
        public async Task<ActionResult<Dcondidates>> PostCandidate(Dcondidates candidate)
        {
            // Add the candidate to the DbContext
            _context.Dcondidates.Add(candidate);
            await _context.SaveChangesAsync();

            // Return the created candidate with a 201 status code
            return CreatedAtAction(nameof(GetCandidate), new { id = candidate.Id }, candidate);
        }

        // PUT: api/Candidate/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCandidate(int id, Dcondidates candidate)
        {
            if (id != candidate.Id)
            {
                return BadRequest();
            }

            _context.Entry(candidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CandidateExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();  // Return 204 status code for successful update
        }

        // DELETE: api/Candidate/{id}
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCandidate(int id)
        {
            var candidate = await _context.Dcondidates.FindAsync(id);
            if (candidate == null)
            {
                return NotFound();
            }

            _context.Dcondidates.Remove(candidate);
            await _context.SaveChangesAsync();

            return NoContent();  // Return 204 status code for successful deletion
        }

        private bool CandidateExists(int id)
        {
            return _context.Dcondidates.Any(e => e.Id == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using TravelBlogAPI.Data;
using TravelBlogShared.Models;

namespace TravelBlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TravelPostController : ControllerBase
    {
        private readonly TravelBlogContext _context;

        public TravelPostController(TravelBlogContext context)
        {
            _context = context;
        }

        // GET: api/TravelPost
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TravelPost>>> GetTravelPosts()
        {
            return await _context.Posts.ToListAsync();
        }

        // GET: api/TravelPost/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TravelPost>> GetTravelPost(int id)
        {
            var post = await _context.Posts.FindAsync(id);

            if (post == null)
            {
                return NotFound();
            }

            return post;
        }

        // POST: api/TravelPost
        [HttpPost]
        public async Task<ActionResult<TravelPost>> PostTravelPost(TravelPost post)
        {
            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTravelPost", new { id = post.PostID }, post);
        }

        // PUT: api/TravelPost/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTravelPost(int id, TravelPost post)
        {
            if (id != post.PostID)
            {
                return BadRequest();
            }

            _context.Entry(post).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TravelPostExists(id))
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

        // DELETE: api/TravelPost/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTravelPost(int id)
        {
            var post = await _context.Posts.FindAsync(id);
            if (post == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(post);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TravelPostExists(int id)
        {
            return _context.Posts.Any(e => e.PostID == id);
        }
    }
}

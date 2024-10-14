using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelBlogApi.Models;

namespace TravelBlogApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TravelBlogItemsController : ControllerBase
{
    private readonly TravelBlogContext _context;

    public TravelBlogItemsController(TravelBlogContext context)
    {
        _context = context;
    }

    // GET: api/TravelBlogItems
    [HttpGet]
    public async Task<ActionResult<IEnumerable<TravelBlogItemDTO>>> GetTravelBlogItems()
    {
        return await _context.TravelBlogItems
            .Select(x => ItemToDTO(x))
            .ToListAsync();
    }

    // GET: api/TravelBlogItems/5
    // <snippet_GetByID>
    [HttpGet("{id}")]
    public async Task<ActionResult<TravelBlogItemDTO>> GetTravelBlogItem(long id)
    {
        var TravelBlogItem = await _context.TravelBlogItems.FindAsync(id);

        if (TravelBlogItem == null)
        {
            return NotFound();
        }

        return ItemToDTO(TravelBlogItem);
    }
    // </snippet_GetByID>

    // PUT: api/TravelBlogItems/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // <snippet_Update>
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTravelBlogItem(long id, TravelBlogItemDTO TravelBlogDTO)
    {
        if (id != TravelBlogDTO.Id)
        {
            return BadRequest();
        }

        var TravelBlogItem = await _context.TravelBlogItems.FindAsync(id);
        if (TravelBlogItem == null)
        {
            return NotFound();
        }

        TravelBlogItem.Name = TravelBlogDTO.Name;
        TravelBlogItem.IsComplete = TravelBlogDTO.IsComplete;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException) when (!TravelBlogItemExists(id))
        {
            return NotFound();
        }

        return NoContent();
    }
    // </snippet_Update>

    // POST: api/TravelBlogItems
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // <snippet_Create>
    [HttpPost]
    public async Task<ActionResult<TravelBlogItemDTO>> PostTravelBlogItem(TravelBlogItemDTO TravelBlogDTO)
    {
        var TravelBlogItem = new TravelBlogItem
        {
            IsComplete = TravelBlogDTO.IsComplete,
            Name = TravelBlogDTO.Name
        };

        _context.TravelBlogItems.Add(TravelBlogItem);
        await _context.SaveChangesAsync();

        return CreatedAtAction(
            nameof(GetTravelBlogItem),
            new { id = TravelBlogItem.Id },
            ItemToDTO(TravelBlogItem));
    }
    // </snippet_Create>

    // DELETE: api/TravelBlogItems/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTravelBlogItem(long id)
    {
        var TravelBlogItem = await _context.TravelBlogItems.FindAsync(id);
        if (TravelBlogItem == null)
        {
            return NotFound();
        }

        _context.TravelBlogItems.Remove(TravelBlogItem);
        await _context.SaveChangesAsync();

        return NoContent();
    }

    private bool TravelBlogItemExists(long id)
    {
        return _context.TravelBlogItems.Any(e => e.Id == id);
    }

    private static TravelBlogItemDTO ItemToDTO(TravelBlogItem TravelBlogItem) =>
       new TravelBlogItemDTO
       {
           Id = TravelBlogItem.Id,
           Name = TravelBlogItem.Name,
           IsComplete = TravelBlogItem.IsComplete
       };
}
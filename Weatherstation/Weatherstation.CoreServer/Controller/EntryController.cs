using Microsoft.AspNetCore.Mvc;
using Weatherstation.CoreServer.Interfaces;
using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Controller;

[ApiController]
[Route("[controller]")]
public class EntryController(IEntryRepo entryRepo) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Entry(Entry entry)
    {
        if (entry == null)
        {
            return BadRequest();
        }
        
        await entryRepo.AddEntryAsync(entry);
        return CreatedAtRoute("GetEntry", new { id = entry.Id }, entry);
    }
    
    [HttpPost("entries")]
    public async Task<IActionResult> Entries(List<Entry> entries)
    {
        if (entries == null)
        {
            return BadRequest();
        }
        
        await entryRepo.AddEntriesAsync(entries);
        return Created();
    }
    
    [HttpGet]
    public async Task<IActionResult> Entries()
    {
        var entries = await entryRepo.GetAllEntriesAsync();
        if (entries == null)
        {
            return NotFound();
        }
        
        return Ok(entries);
    }
    
}
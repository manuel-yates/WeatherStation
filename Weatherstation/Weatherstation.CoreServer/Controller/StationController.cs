using Microsoft.AspNetCore.Mvc;
using Weatherstation.CoreServer.Interfaces;
using Weatherstation.Data.Models;

namespace Weatherstation.CoreServer.Controller;

[ApiController]
[Route("[controller]")]
public class StationController(IStationRepo stationRepo) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> Post(Station station)
    {
        if (station == null)
        {
            return BadRequest();
        }
        
        await stationRepo.AddStationAsync(station);
        return CreatedAtRoute("GetStation", new { id = station.Id }, station);
    }
    
    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        if(int.IsNegative(id))
        {
            return BadRequest();
        }
        
        var station = await stationRepo.GetStationAsync(id);
        if (station == null)
        {
            return NotFound();
        }
        
        return Ok(station);
    }
    
    [HttpGet("all")]
    public async Task<IActionResult> GetAll()
    {
        var stations = await stationRepo.GetAllStationsAsync();
        if (stations == null)
        {
            return NotFound();
        }
        
        return Ok(stations);
    }
    
    [HttpPut]
    public async Task<IActionResult> Update(Station station)
    {
        if (station == null)
        {
            return BadRequest();
        }
        
        await stationRepo.UpdateStationAsync(station);
        return NoContent();
    }
    
}
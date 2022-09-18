using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BookwormAPI.Models;

namespace BookwormAPI.Controllers
{
[Route("api/[controller]")]
[ApiController]
public class RatingsController : ControllerBase
{
private readonly BookwormAPIContext _db; 
    
    public RatingsController(BookwormAPIContext db)
    {
      _db = db; 
    }

    // GET: api/Ratings
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Rating>>> Get()
    {
      return await _db.Ratings.ToListAsync();
    }

    // GET: api/Ratings/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Rating>> GetRating(int id)
    {
      var Rating = await _db.Ratings.FindAsync(id);

      if (Rating == null)
      {
        return NotFound();
      }
      return Rating;
    }

    [HttpPost]
    public async Task<ActionResult<Rating>> Post(Rating Rating)
    {
      _db.Ratings.Add(Rating); 
      await _db.SaveChangesAsync(); 

      return CreatedAtAction("Post", new { id = Rating.RatingId }, Rating); 
    }
}
}
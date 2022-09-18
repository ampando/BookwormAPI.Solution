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
public class ReviewsController : ControllerBase
{
private readonly BookwormAPIContext _db; 
    
    public ReviewsController(BookwormAPIContext db)
    {
      _db = db; 
    }

    // GET: api/Reviews
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Review>>> Get()
    {
      return await _db.Reviews.ToListAsync();
    }

    // GET: api/Reviews/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Review>> GetReview(int id)
    {
      var review = await _db.Reviews.FindAsync(id);

      if (review == null)
      {
        return NotFound();
      }
      return review;
    }

    [HttpPost]
    public async Task<ActionResult<Review>> Post(Review review)
    {
      _db.Reviews.Add(review); 
      await _db.SaveChangesAsync(); 

      return CreatedAtAction("Post", new { id = review.ReviewId }, review); 
    }
}
}

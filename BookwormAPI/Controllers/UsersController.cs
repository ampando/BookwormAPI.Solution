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
public class UsersController : ControllerBase
{
private readonly BookwormAPIContext _db; 
    
    public UsersController(BookwormAPIContext db)
    {
      _db = db; 
    }

    // GET: api/Users
    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> Get()
    {
      return await _db.Users.ToListAsync();
    }

    // GET: api/Users/5
    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUser(int id)
    {
      var User = await _db.Users.FindAsync(id);

      if (User == null)
      {
        return NotFound();
      }
      return User;
    }

    [HttpPost]
    public async Task<ActionResult<User>> Post(User User)
    {
      _db.Users.Add(User); 
      await _db.SaveChangesAsync(); 

      return CreatedAtAction("Post", new { id = User.UserId }, User); 
    }
}
}

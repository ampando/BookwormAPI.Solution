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
public class LibrariesController : ControllerBase
{
private readonly BookwormAPIContext _db; 
    
    public LibrariesController(BookwormAPIContext db)
    {
      _db = db; 
    }

    // GET: api/Librarys
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Library>>> Get()
    {
      return await _db.Librarys.ToListAsync();
    }

    // GET: api/Librarys/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Library>> GetLibrary(int id)
    {
      var Library = await _db.Librarys.FindAsync(id);

      if (Library == null)
      {
        return NotFound();
      }
      return Library;
    }

    [HttpPost]
    public async Task<ActionResult<Library>> Post(Library Library)
    {
      _db.Librarys.Add(Library); 
      await _db.SaveChangesAsync(); 

      return CreatedAtAction("Post", new { id = Library.LibraryId }, Library); 
    }
}
}

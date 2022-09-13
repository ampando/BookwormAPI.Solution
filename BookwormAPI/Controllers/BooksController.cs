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
public class BooksController : ControllerBase
{
private readonly BookwormAPIContext _db; 
    
    public BooksController(BookwormAPIContext db)
    {
      _db = db; 
    }

  // GET: api/Books/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Book>> GetBook(int id)
    {
      var book = await _db.Books.FindAsync(id);

      if (book == null)
      {
        return NotFound();
      }
      return book;
    } 

  // GET api/books
  [HttpGet]
  public async Task<ActionResult<IEnumerable<Book>>> Get(string title, string author, string ageRange, string summary, string rating, string genre, string tags, string reviews)
  {
    IQueryable<Book> query = _db.Books.AsQueryable(); 
    
    if (title != null)
    {
      query = query.Where(entry => entry.Title == title);
    }
    if (author != null)
    {
      query = query.Where(entry => entry.Author == author);
    }
    if (ageRange != null)
    {
      query = query.Where(entry => entry.AgeRange == ageRange);
    }
    if (summary != null)
    {
      query = query.Where(entry => entry.Summary == summary);
    }
    
    if (rating != null)
    {
      query = query.Where(entry => entry.Rating == rating);
    }
    
    if (genre != null)
    {
      query = query.Where(entry => entry.Genre == genre);
    }

    if (tags != null)
    {
      query = query.Where(entry => entry.Tags == tags);
    }
    
    if (reviews != null)
    {
      query = query.Where(entry => entry.Reviews == reviews);
    }
    
    return await query.ToListAsync();
  }

    [HttpPost]
    public async Task<ActionResult<Book>> Post(Book book)
    {
      _db.Books.Add(book); 
      await _db.SaveChangesAsync(); 

      return CreatedAtAction("Post", new { id = book.BookId }, book); 
    }

   [HttpDelete("{id}")]
  public async Task<IActionResult> Delete(int id)
  {
    var book = await _db.Books.FindAsync(id);
    if (book == null)
    {
      return NotFound();
    }
    
    _db.Books.Remove(book);
    await _db.SaveChangesAsync();

    return NoContent();
    }

    // PUT: api/Books/5
  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, Book book)
  {
    if (id != book.BookId)
    {
      return BadRequest(); 
    }

    _db.Entry(book).State = EntityState.Modified; 
    
    try
    {
      await _db.SaveChangesAsync(); 
    }
    catch (DbUpdateConcurrencyException)
    {
      if (!BookExists(id))
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

  private bool BookExists(int id)
    {
      return _db.Books.Any( e => e.BookId == id);
    }
  }
}
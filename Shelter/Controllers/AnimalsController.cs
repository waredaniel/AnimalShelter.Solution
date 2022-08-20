using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shelter.Models;

namespace Shelter.Controllers
{
  
  [Route("api/[controller]")]
  [ApiController]
  public class AnimalsController : ControllerBase
  {
    private readonly ShelterContext _db;

    public AnimalsController(ShelterContext db)
    {
      _db = db;
    }

    //GET: api/animals
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Animal>>> Get(string name, int age, string species, string breed, string gender, bool immunizations)
    {
      var query = _db.Animals.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

       if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }
    
      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      

      return await query.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Animal>> GetAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
          return NotFound();
      }
      return animal;
    }

    [HttpGet("page{page}")]
    public async Task<ActionResult<List<Animal>>> GetShelterDatabase(int page)
    {
      if (_db.Animals == null)
        return NotFound();
      
      var pageResults = 3f;
      var pageCount = Math.Ceiling(_db.Animals.Count() / pageResults);

      var animals = await _db.Animals
      .Skip((page - 1) * (int)pageResults)
      .Take((int)pageResults)
      .ToListAsync();

      var response = new AnimalPages
      {
        Animals = animals,
        CurrentPage = page,
        Pages = (int)pageCount
      };
      return Ok(response);
    }

     // PUT: api/Animals/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      _db.Entry(animal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
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
     private bool AnimalExists(int id)
    {
      return _db.Animals.Any(e => e.AnimalId == id);
    }

      // POST: api/Animals
    [HttpPost]
    public async Task<ActionResult<Animal>> Post(Animal animal)
    {
      _db.Animals.Add(animal);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetAnimal), new { id = animal.AnimalId }, animal);
    }

    // DELETE: api/Animals/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var animal = await _db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      _db.Animals.Remove(animal);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}
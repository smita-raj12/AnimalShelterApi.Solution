using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class OtherAnimalsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public OtherAnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/OtherAnimals
    [HttpGet]
    public ActionResult<IEnumerable<OtherAnimal>> Get(string name, string gender, int? age, string type)
    {
      var query = _db.OtherAnimals.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (gender != null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }
      if (age != null)
      {
        query = query.Where(entry => entry.Age == age);
      }
      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }
      return query.ToList();
    }

    // POST api/OtherAnimals
    [HttpPost]
    public async Task<ActionResult<OtherAnimal>> Post(OtherAnimal otherAnimal)
    {
      _db.OtherAnimals.Add(otherAnimal);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetOtherAnimal), new { id = otherAnimal.OtherAnimalId }, otherAnimal);
    }
    // GET: api/OtherAnimals/5
    [HttpGet("{id}")]
    public async Task<ActionResult<OtherAnimal>> GetOtherAnimal(int id)
    {
      var otherAnimal = await _db.OtherAnimals.FindAsync(id);

      if (otherAnimal == null)
      {
          return NotFound();
      }

      return otherAnimal;
    }
     // PUT: api/OtherAnimal/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, OtherAnimal otherAnimal)
    {
      if (id != otherAnimal.OtherAnimalId)
      {
        return BadRequest();
      }

      _db.Entry(otherAnimal).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!OtherAnimalExists(id))
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

    private bool OtherAnimalExists(int id)
    {
      return _db.OtherAnimals.Any(e => e.OtherAnimalId == id);
    }
    // DELETE: api/OtherAnimals/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteOtherAnimal(int id)
    {
      var otherAnimal = await _db.OtherAnimals.FindAsync(id);
      if (otherAnimal == null)
      {
        return NotFound();
      }

      _db.OtherAnimals.Remove(otherAnimal);
      await _db.SaveChangesAsync();

      return NoContent();
    }
  }
}
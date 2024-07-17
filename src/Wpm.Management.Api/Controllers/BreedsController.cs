using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;
using Wpm.Management.Api.DataAccess;

namespace Wpm.Management.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BreedsController(ManagementDbContext dbContext,
                              ILogger<BreedsController> logger) : ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var all = await dbContext.Breeds.ToListAsync();
        return all != null ? Ok(all) : NotFound();
    }

    [HttpGet("{id}", Name = nameof(GetBreedById))]
    public async Task<IActionResult> GetBreedById(int id)
    {
        var breed = await dbContext.Breeds.FindAsync(id);
        return breed != null ? Ok(breed): NotFound();
    }

    [HttpPost]
    public async Task<IActionResult> Create(NewBreed newBreed)
    {
        try
        {
            var breed = newBreed.ToBreed();
            await dbContext.Breeds.AddAsync(breed);
            await dbContext.SaveChangesAsync();

            return CreatedAtRoute(nameof(GetBreedById), new { id = breed.Id }, newBreed);
        }
        catch (Exception ex)
        {
            logger.LogError(ex.ToString());
            return StatusCode((int)HttpStatusCode.InternalServerError);
        }
    }
}

public record NewBreed(string Name)
{
    public Breed ToBreed()
    {
        return new Breed(0, Name);
    }
}
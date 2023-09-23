using EFCore_Peliculas.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Peliculas;

[ApiController]
[Route("api/generos")]
public class GenerosController : ControllerBase
{
  private readonly ApplicationDbContext context;
  public GenerosController(ApplicationDbContext context)
  {
    this.context = context;
  }

  [HttpGet]
  public async Task<IEnumerable<Genero>> Get()
  {
    return await context.Generos.ToListAsync();
  }
}
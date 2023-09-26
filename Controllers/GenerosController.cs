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

  [HttpGet("primer")]
  public async Task<ActionResult<Genero>> Primer()
  {
    var genero = await context.Generos.FirstOrDefaultAsync(g => g.Nombre.StartsWith("Z"));
    if (genero is null)
    {
      return NotFound();
    }
    return genero;
  }

  [HttpGet("{id:int}")]
  public async Task<ActionResult<Genero>> Get(int id)
  {
    var genero = await context.Generos.FirstOrDefaultAsync(g => g.Identificador == id);

    if (genero is null)
    {
      return NotFound();
    }

    return genero;
  }

  [HttpGet("filtrar")]
  public async Task<IEnumerable<Genero>> Filtrar(string nombre)
  {
    return await context.Generos.Where(g => g.Nombre.Contains(nombre)).ToListAsync();
  }

  [HttpGet("paginacion")]
  public async Task<IEnumerable<Genero>> GetPaginacion(int pagina)
  {
    var cantidadRegistrosPorPagina = 2;
    var generos = await context.Generos.Skip((pagina - 1) * cantidadRegistrosPorPagina).Take(cantidadRegistrosPorPagina).ToListAsync();
    return generos;
  }
}
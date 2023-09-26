using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Peliculas;

[ApiController]
[Route("api/actores")]
public class AutoresController : ControllerBase
{
  private readonly ApplicationDbContext context;
  private readonly IMapper mapper;

  public AutoresController(ApplicationDbContext context, IMapper mapper)
  {
    this.context = context;
    this.mapper = mapper;
  }

  [HttpGet]
  public async Task<IEnumerable<ActorDTO>> Get()
  {
    var actores = await context.Actores.ProjectTo<ActorDTO>(mapper.ConfigurationProvider).ToListAsync();
    return actores;
  }
}
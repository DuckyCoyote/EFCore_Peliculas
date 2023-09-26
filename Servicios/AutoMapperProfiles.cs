using AutoMapper;
using EFCore_Peliculas.Entities;

namespace EFCore_Peliculas;

public class AutoMapperProfiles : Profile
{
  public AutoMapperProfiles()
  {
    CreateMap<Actor, ActorDTO>();
  }
}

using System.Reflection;
using EFCore_Peliculas.Entities;
using EFCorePeliculas.Entidades.Seeding;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Peliculas;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
  public DbSet<Genero> Generos { get; set; }
  public DbSet<Actor> Actores { get; set; }
  public DbSet<Cine> Cines { get; set; }
  public DbSet<Pelicula> Peliculas { get; set; }
  public DbSet<CineOferta> CineOfertas { get; set; }
  public DbSet<SalaDeCine> SalasDeCine { get; set; }
  public DbSet<PeliculaActor> PeliculasActores { get; set; }

  protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
  {
    configurationBuilder.Properties<DateTime>().HaveColumnType("Date");
  }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    SeedingModuloConsulta.Seed(modelBuilder);
  }
}

using EFCore_Peliculas.Entities;
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

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Genero>().HasKey(g => g.Id);
    modelBuilder.Entity<Genero>().Property(g => g.Nombre).HasMaxLength(50).IsRequired();

    modelBuilder.Entity<Actor>().Property(a => a.Nombre).HasMaxLength(100).IsRequired();
    modelBuilder.Entity<Actor>().Property(a => a.FechaNacimiento).HasColumnType("date");

    modelBuilder.Entity<Cine>().Property(c => c.Nombre).HasMaxLength(150).IsRequired();

    modelBuilder.Entity<Pelicula>().Property(p => p.Titulo).HasMaxLength(250).IsRequired();
    modelBuilder.Entity<Pelicula>().Property(p => p.FechaEstreno).HasColumnType("date");
    modelBuilder.Entity<Pelicula>().Property(p => p.PosterURL).HasMaxLength(500).IsUnicode();

    modelBuilder.Entity<CineOferta>().Property(Co => Co.PorcentajeDescuento).HasPrecision(precision: 5, scale: 2);
    modelBuilder.Entity<CineOferta>().Property(Co => Co.FechaInicio).HasColumnType("date");
    modelBuilder.Entity<CineOferta>().Property(Co => Co.FechaFin).HasColumnType("date");

    modelBuilder.Entity<SalaDeCine>().Property(SC => SC.TipoSalaDeCine).HasDefaultValue(TipoSalaDeCine.DosDimensiones);
    modelBuilder.Entity<SalaDeCine>().Property(SC => SC.Precio).HasPrecision(precision: 9, scale: 2);

    modelBuilder.Entity<PeliculaActor>().Property(PA => PA.Personaje).HasMaxLength(150);
  }
}
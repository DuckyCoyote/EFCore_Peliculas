
using EFCore_Peliculas.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCore_Peliculas;

public class ApplicationDbContext : DbContext
{
  public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
  public DbSet<Genero> Generos { get; set; }
  public DbSet<Actor> Actores { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);

    modelBuilder.Entity<Genero>().HasKey(g => g.Id);
    modelBuilder.Entity<Genero>().Property(g => g.Nombre).HasMaxLength(50).IsRequired();

    modelBuilder.Entity<Actor>().Property(a => a.Nombre).HasMaxLength(100).IsRequired();
    modelBuilder.Entity<Actor>().Property(a => a.FechaNacimiento).HasColumnType("date");
  }
}
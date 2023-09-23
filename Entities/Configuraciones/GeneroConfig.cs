using EFCore_Peliculas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Peliculas;

public class GeneroConfig : IEntityTypeConfiguration<Genero>
{
  public void Configure(EntityTypeBuilder<Genero> builder)
  {
    builder.HasKey(g => g.Identificador);
    builder.Property(g => g.Nombre).HasMaxLength(50).IsRequired();
  }
}
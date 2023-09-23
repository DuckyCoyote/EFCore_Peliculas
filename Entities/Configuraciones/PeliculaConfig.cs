using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Peliculas;

public class PeliculaConfig : IEntityTypeConfiguration<Pelicula>
{
  public void Configure(EntityTypeBuilder<Pelicula> builder)
  {
    builder.Property(p => p.Titulo).HasMaxLength(250).IsRequired();
    builder.Property(p => p.PosterURL).HasMaxLength(500).IsUnicode();
  }
}
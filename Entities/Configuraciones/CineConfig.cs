using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Peliculas;

public class CineConfig : IEntityTypeConfiguration<Cine>
{
  public void Configure(EntityTypeBuilder<Cine> builder)
  {
    builder.Property(c => c.Nombre).HasMaxLength(150).IsRequired();
  }
}
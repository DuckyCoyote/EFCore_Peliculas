using EFCore_Peliculas.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Peliculas;

public class ActorConfig : IEntityTypeConfiguration<Actor>
{
  public void Configure(EntityTypeBuilder<Actor> builder)
  {
    builder.Property(a => a.Nombre).HasMaxLength(100).IsRequired();
  }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Peliculas;

public class PeliculaActorConfig : IEntityTypeConfiguration<PeliculaActor>
{
  public void Configure(EntityTypeBuilder<PeliculaActor> builder)
  {
    builder.HasKey(PA => new { PA.PeliculaId, PA.ActorId });
    builder.Property(PA => PA.Personaje).HasMaxLength(150);
  }
}
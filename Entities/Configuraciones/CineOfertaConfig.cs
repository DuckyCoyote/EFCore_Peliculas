using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Peliculas;

public class CineOfertaConfig : IEntityTypeConfiguration<CineOferta>
{
  public void Configure(EntityTypeBuilder<CineOferta> builder)
  {
    builder.Property(Co => Co.PorcentajeDescuento).HasPrecision(precision: 5, scale: 2);
  }
}
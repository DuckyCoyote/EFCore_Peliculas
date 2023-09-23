using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFCore_Peliculas;

public class SalaDeCineConfig : IEntityTypeConfiguration<SalaDeCine>
{
  public void Configure(EntityTypeBuilder<SalaDeCine> builder)
  {
    builder.Property(SC => SC.TipoSalaDeCine).HasDefaultValue(TipoSalaDeCine.DosDimensiones);
    builder.Property(SC => SC.Precio).HasPrecision(precision: 9, scale: 2);
  }
}
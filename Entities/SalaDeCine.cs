using NetTopologySuite.Geometries;

namespace EFCore_Peliculas;

public class SalaDeCine
{
  public int Id { get; set; }
  public TipoSalaDeCine TipoSalaDeCine{ get; set; }
  public decimal Precio { get; set; }
  public int CineId { get; set; }
  public HashSet<SalaDeCine> SalasDeCine { get; set; }
  public HashSet<Pelicula> Peliculas { get; set; }
}

using NetTopologySuite.Geometries;

namespace EFCore_Peliculas;

public class Cine
{
  public int Id { get; set; }
  public string Nombre { get; set; }
  public Point Ubicacion { get; set; }
  public CineOferta CineOferta { get; set; }

}

namespace EFCore_Peliculas.Entities;
public class Actor
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Biografia { get; set; }
    public DateTime? FechaNacimiento { get; set; }
}

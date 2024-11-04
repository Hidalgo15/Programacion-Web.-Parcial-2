using Microsoft.EntityFrameworkCore;    
using System.ComponentModel.DataAnnotations;

public class Visita {

    [Key]
    public int Id { get; set; }
    public string Teléfono { get; set; }
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public string CorreoElectrónico { get; set; }
}
using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Interfacez;

public interface IDueño
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }
    
    public int Edad { get; set; }
    
    public string Telefono { get; set; }
    
}
using Sistema_de_Gesti_n_Veterinaria_VetCare.Interfacez;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

public class Dueño : IDueño
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; }
    
    public int Edad { get; set; }
    
    public string Telefono { get; set; }

    public static  List<Dueño> _dueño = new List<Dueño>();
  
    
    public Dueño(string nombre, int edad, string telefono)
    {
        Nombre = nombre;
        Edad = edad;
        Telefono = telefono;
    }
    
    
    
}

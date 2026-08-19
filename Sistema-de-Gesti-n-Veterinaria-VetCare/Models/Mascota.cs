using Sistema_de_Gesti_n_Veterinaria_VetCare.Interfacez;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

public class Mascota : IMascota
{
    
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Raza { get; set; }
    public string Sintoma { get; set; }
    public Guid DueñoId { get; set; }

    public Dueño Dueño { get; set; }
    
    public static  List<Mascota> _mascota = new List<Mascota>();
        
    public Mascota(string nombre, int edad, string raza, string sintoma, Dueño dueño)
    {
        Nombre = nombre;
        Edad = edad;
        Raza = raza;
        Sintoma = sintoma;
        Dueño = dueño;
    }
}
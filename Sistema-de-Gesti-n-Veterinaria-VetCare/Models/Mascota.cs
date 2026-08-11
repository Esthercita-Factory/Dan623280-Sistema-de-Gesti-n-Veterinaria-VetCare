namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

public class Mascota
{
    
    public string Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Sintoma { get; set; }

    public Mascota(string nombre, int edad, string sintoma)
    {
        Id = Guid.NewGuid().ToString();
        Nombre = nombre;
        Edad = edad;
        Sintoma = sintoma;
    }
}
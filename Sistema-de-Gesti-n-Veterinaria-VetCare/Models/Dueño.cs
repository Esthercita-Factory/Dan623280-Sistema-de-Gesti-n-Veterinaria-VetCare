namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

public class Dueño
{
    public string Id { get; set; }
    public string Nombre { get; set; }
    
    public Dueño(string nombre, int edad, string sintoma)
    {
        Id = Guid.NewGuid().ToString();
        Nombre = nombre;
    }
}
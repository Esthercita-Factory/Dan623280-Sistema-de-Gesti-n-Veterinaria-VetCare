using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Services;

public class ServiceVerifiMascotas
{
    public static List<Mascota> ObtenerTodos()
    {
        return RepositoryMascota.ObtenerTodo();
    }
    
    //
    public static bool Agregar(string nombre, int edad, string raza, string sintoma, Dueño dueño)
    {
        Mascota mascota = new Mascota(nombre, edad, raza, sintoma, dueño);
        RepositoryMascota.Agregar(mascota);
        return true;
    }
    
}
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
    
    public static void Actualizar(Mascota mascota, string nombre, int edad, string raza, string sintoma)
    {
        RepositoryMascota.Actualizar(mascota, nombre, edad, raza, sintoma);
    }

    public static void Eliminar(Mascota mascota)
    {
        RepositoryMascota.Eliminar(mascota);
    }
    
    //Consulta
    
    //Id
    public static Mascota BuscarPorId(Guid id)
    {
        return RepositoryMascota.ConsultarId(id);

    }
    
    // Nombre
    public static List<Mascota> BuscarPorNombre(string nombre)
    {
        return RepositoryMascota.ConsultarNombre(nombre);

    }
    
    //Edad
    public static List<Mascota> BuscarPorEdad(int edad)
    {
        return RepositoryMascota.ConsultarEdad(edad);

    }
    
    //Raza
    public static List<Mascota> BuscarPorRaza(string raza)
    {
        return RepositoryMascota.ConsultarRaza(raza);

    }
    
    //Sintoma
    public static List<Mascota> BuscarPorSintoma(string sintoma)
    {
        return RepositoryMascota.ConsultarRaza(sintoma);

    }
    
    
}
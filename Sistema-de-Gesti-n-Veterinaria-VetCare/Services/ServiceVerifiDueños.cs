using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Services;

public class ServiceVerifiDueños
{
    public static List<Dueño> ObtenerTodos()
    {
        return RepositoryDueño.ObtenerTodo();
    }

    public static bool Agregar(string nombre, int edad, string telefono)
    {
        Dueño dueño1 = new Dueño(nombre, edad, telefono);
        RepositoryDueño.Agregar(dueño1);
        return true;
    }

    public static void ActuazliarDueño(Dueño dueño, string nombre, int edad, string telefono)
    {
        RepositoryDueño.Actualizar(dueño,nombre, edad, telefono);
    }
    public static void Eliminar(Dueño dueño)
    {
        RepositoryDueño.Eliminar(dueño);
    }
    
    //Consultar 
    
    //Id
    public static Dueño BuscarPorId(Guid id)
    {
        return RepositoryDueño.BuscarPorId(id);

    }
    
    // Nombre
    public static List<Dueño> BuscarPorNombre(string nombre)
    {
        return RepositoryDueño.ConsultarNombre(nombre);

    }
    
    //Edad
    public static List<Dueño> BuscarPorEdad(int edad)
    {
        return RepositoryDueño.ConsultarEdad(edad);
    }
    
    //Telefono
    public static List<Dueño> BuscarPorTelefono(string telefono)
    {
        return RepositoryDueño.ConsultarTelefono(telefono);
    }
    
}
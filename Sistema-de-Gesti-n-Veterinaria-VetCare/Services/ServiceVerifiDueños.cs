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
    
    //Consultar 
    
    //Id
    public static Dueño BuscarPorId(Guid id)
    {
        return RepositoryDueño.BuscarPorId(id);

    }
    
}
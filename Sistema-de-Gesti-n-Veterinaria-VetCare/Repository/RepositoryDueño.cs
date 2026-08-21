using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;

public static class RepositoryDueño
{
    
    //Crud
    
    //Agregar
    public static void Agregar(Dueño dueño)
    {
        Dueño._dueño.Add(dueño);
    }
    
    //Obtener

    public static List<Dueño> ObtenerTodo()
    {
        return Dueño._dueño;
    }

    //Actualizar
    public static void Actualizar(Dueño dueño, string nombre, int edad, string telefono)
    {
        dueño.Nombre = nombre;
        dueño.Edad = edad;
        dueño.Telefono = telefono;
        
    }

    //Eliminar
    public static void Eliminar(Dueño dueño)
    {
        Dueño._dueño.Remove(dueño);
    }
    
    
    //Consultas
    
    //id
    public static Dueño BuscarPorId(Guid id)
    {
        return Dueño._dueño.FirstOrDefault(d => d.Id == id);
    }
    
    //Nombre
    public static List<Dueño> ConsultarNombre(string nombre)
    {
        return Dueño._dueño.Where(d => d.Nombre == nombre).ToList();
    }

    //Edad
    public static List<Dueño> ConsultarEdad(int edad)
    {
        return Dueño._dueño.Where(d => d.Edad == edad).ToList();
    }

    //Telefono
    public static List<Dueño> ConsultarTelefono(string telefono)
    {
        return Dueño._dueño.Where(d => d.Telefono == telefono).ToList();
    }
    
}
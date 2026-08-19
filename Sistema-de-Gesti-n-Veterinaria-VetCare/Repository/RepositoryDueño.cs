using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;

public static class RepositoryDueño
{
    
    //Crud
    public static void Agregar(Dueño dueño)
    {
        Dueño._dueño.Add(dueño);
    }

    public static void Actualizar(this Dueño dueño, string nombre, int edad, string telefono)
    {
        dueño.Nombre = nombre;
        dueño.Edad = edad;
        dueño.Telefono = telefono;
        
    }

    public static void Eliminar(this Mascota mascota)
    {
        Mascota._mascota.Remove(mascota);
    }
    
    //Consultas

    public static Dueño? BuscarPorId(Guid id)
    {
        return Dueño._dueño
            .FirstOrDefault(d => d.Id == id);
    }
    
}
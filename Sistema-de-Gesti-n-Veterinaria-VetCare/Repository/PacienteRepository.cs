using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;

public class PacienteRepository
{
    
    public static List<Mascota> _pacientes = new List<Mascota>();

    public static void Guardar(Mascota mascota)
    {
        _pacientes.Add(mascota);
    }

    public static List<Mascota> ObtenerPacientes()
    {
        return _pacientes;
    }

    public static Mascota BuscarPorNombre(string nombre)
    {
        foreach (var paciente_unico in _pacientes)
        {
            if (paciente_unico.Nombre == nombre)
            {
                return paciente_unico;
                
            }
        }
        return null;
    }
    public static Mascota BuscarPorId(string id)
    {
        foreach (var paciente_unico in _pacientes)
        {
            if (paciente_unico.Id == id)
            {
                return paciente_unico;
                
            }
        }
        return null;
    }
    public static void Eliminar(Mascota mascota)
    {
        _pacientes.Remove(mascota);

    }
    
    
}
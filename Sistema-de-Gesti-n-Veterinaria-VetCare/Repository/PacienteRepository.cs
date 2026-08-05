using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;

public class PacienteRepository
{
    
    public static List<Paciente> _pacientes = new List<Paciente>();

    public static void Guardar(Paciente paciente)
    {
        _pacientes.Add(paciente);
    }

    public static List<Paciente> ObtenerPacientes()
    {
        return _pacientes;
    }

    public static Paciente BuscarPorNombre(string nombre)
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
    public static Paciente BuscarPorId(string id)
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
    public static void Eliminar(Paciente paciente)
    {
        _pacientes.Remove(paciente);

    }
    
    
}
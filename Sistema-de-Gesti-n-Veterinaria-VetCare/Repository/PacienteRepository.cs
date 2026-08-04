using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;

public class PacienteRepository
{
    
    private readonly List<Paciente> _pacientes = new List<Paciente>();

    public void Guardar(Paciente paciente)
    {
        _pacientes.Add(paciente);
    }

    public List<Paciente> ObtenerPacientes()
    {
        return _pacientes;
    }

    public Paciente? BuscarPorNombre(string nombre)
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
    
}
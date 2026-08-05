using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class Validation_menu
{
    public void Registrar()
    {
        string nombre = ConsolaInput.PedirTexto("Nombre: ");
        int edad = ConsolaInput.PedirEntero("Edad: ",0,120);
        string sintoma = ConsolaInput.PedirTexto("Sintoma: ");
        Paciente p = new Paciente(nombre, edad, sintoma);
        
        PacienteRepository.Guardar(p);
        User_mensajes.Mensajes("Añadidos");
    }

    public void Mostrar()
    {
        Console.WriteLine("==============Datos de Pacientes=============");
        foreach (Paciente paciente in PacienteRepository.ObtenerPacientes())
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("id: "+paciente.Id);
            Console.WriteLine("nombre: "+paciente.Nombre);
            Console.WriteLine("edad: "+paciente.Edad);
            Console.WriteLine("sintoma: "+paciente.Sintoma);
            Console.WriteLine("----------------------------------------");
        }
        
    }

    public void Buscar()
    {
        string nombre = ConsolaInput.PedirTexto("Nombre: ");
        Paciente pacienteencontrado  =  PacienteRepository.BuscarPorNombre(nombre);

        if (pacienteencontrado != null)
        {
            Console.WriteLine("=== DATOS DEL PACIENTE ===");
            Console.WriteLine($"ID:     {pacienteencontrado.Id}");
            Console.WriteLine($"Nombre: {pacienteencontrado.Nombre}");
            Console.WriteLine($"Edad:   {pacienteencontrado.Edad} años");
            Console.WriteLine($"Sintoma:     {pacienteencontrado.Sintoma}");
        }
        else
        {
            Console.WriteLine("❌ Error: No se encontró ningún paciente con ese nombre.");
        }

    }
    
    public void Buscarid()
    {
        string id = ConsolaInput.PedirTexto("Id: ");
        Paciente pacienteencontrado  =  PacienteRepository.BuscarPorId(id);

        if (pacienteencontrado != null)
        {
            Console.WriteLine("=== DATOS DEL PACIENTE ===");
            Console.WriteLine($"ID:     {pacienteencontrado.Id}");
            Console.WriteLine($"Nombre: {pacienteencontrado.Nombre}");
            Console.WriteLine($"Edad:   {pacienteencontrado.Edad} años");
            Console.WriteLine($"Sintoma:     {pacienteencontrado.Sintoma}");
        }
        else
        {
            Console.WriteLine("❌ Error: No se encontró ningún paciente con ese nombre.");
        }

    }
    public void Eliminar()
    {
        string id = ConsolaInput.PedirTexto("Id: ");
        Paciente pacienteencontrado  =  PacienteRepository.BuscarPorId(id);

        if (pacienteencontrado != null)
        {
            
            PacienteRepository.Eliminar(pacienteencontrado);
            pacienteencontrado = null;
            Console.WriteLine("Paciente eliminado correctamente");
            
            
        }
        else
        {
            
            Console.WriteLine("❌ Error: No se encontró ningún paciente con ese nombre.");
            
        }

    }

    public void Actualizar()
    {
        string id = ConsolaInput.PedirTexto("Id: ");
        Paciente pacienteencontrado  =  PacienteRepository.BuscarPorId(id);

        if (pacienteencontrado != null)
        {
            pacienteencontrado.Nombre = ConsolaInput.PedirTexto($"Nombre: {pacienteencontrado.Nombre} Cambiar por: ");
            pacienteencontrado.Edad = ConsolaInput.PedirEntero($"Edad: {pacienteencontrado.Edad} Cambiar por: ");
            pacienteencontrado.Sintoma = ConsolaInput.PedirTexto($"Sintoma: {pacienteencontrado.Sintoma} Cambiar por: ");
            
            
        }
        else
        {
            Console.WriteLine("❌ Error: No se encontró ningún paciente con ese nombre.");
        }
    }
    
}
using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class Validation_menu
{
    PacienteRepository repo = new PacienteRepository();
    public void Registrar()
    {
        Console.Write("Nombre: ");
        string nombre = Console.ReadLine();
        Console.Write("Edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());
        Console.Write("Sintoma: ");
        string sintoma = Console.ReadLine();
        Paciente p = new Paciente(nombre, edad, sintoma);
        
        repo.Guardar(p);
        User_mensajes.Mensajes("Añadidos");
    }

    public void Mostrar()
    {
        Console.WriteLine("==============Datos de Pacientes=============");
        foreach (Paciente paciente in repo.ObtenerPacientes())
        {
            
            Console.WriteLine("id: "+paciente.Id);
            Console.WriteLine("nombre: "+paciente.Nombre);
            Console.WriteLine("edad: "+paciente.Edad);
            Console.WriteLine("sintoma: "+paciente.Sintoma);
        }
        
    }
}
using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Services;
using Sistemadealquilerdevehículos.Services;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class Ingresar
{
    
    //string nombre, int edad, string telefono
    public static void IngresarDueño()
    {
        string nombre = ConsolaInput.PedirTexto("Colocar Nombre: ");
        int edad = ConsolaInput.PedirEntero("Colocar Edad: ");
        string telefono = ConsolaInput.PedirTexto("Colocar Telefono: ");
        bool agregar = ServiceVerifiDueños.Agregar(nombre, edad, telefono);

        if (agregar)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("=== Datos Agregados Correctamente ===");
            Console.WriteLine("=====================================");
        }
        else
        {
            Console.WriteLine("======================================");
            Console.WriteLine("=== Hubo Error Al Añadir Los Datos ===");
            Console.WriteLine("======================================");
        }
    }
    
    //string nombre, int edad, string raza, string sintoma, Dueño dueño
    
    public static void IngresarMacota()
    {
        string nombre = ConsolaInput.PedirTexto("Colocar Nombre: ");
        int edad =  ConsolaInput.PedirEntero("Colocar Edad: ");
        string raza =  ConsolaInput.PedirTexto("Colocar Raza: ");
        string sintoma = ConsolaInput.PedirTexto("Colocar Sintoma: ");
        List<Dueño> dueños = ServiceVerifiDueños.ObtenerTodos(); 
        Mostrar.MostrarDueños(dueños);
        Guid iddueño = ConsolaInput.PedirGuid("Colocar id de dueño: ");

        Dueño dueño = ServiceVerifiDueños.BuscarPorId(iddueño);

        if (dueño != null)
        {
            Mostrar.MostrarDueño(dueño);
            bool Agregar = ServiceVerifiMascotas.Agregar(nombre, edad, raza, sintoma, dueño);

            if (Agregar)
            {
                Console.WriteLine("=====================================");
                Console.WriteLine("=== Datos Agregados Correctamente ===");
                Console.WriteLine("=====================================");
            }
            else
            {
                Console.WriteLine("======================================");
                Console.WriteLine("=== Hubo Error Al Añadir Los Datos ===");
                Console.WriteLine("======================================");
            }

        }
        else
        {
            Console.WriteLine("=======================");
            Console.WriteLine("=== Dueño no existe ===");
            Console.WriteLine("=======================");
        }
        


    }
}
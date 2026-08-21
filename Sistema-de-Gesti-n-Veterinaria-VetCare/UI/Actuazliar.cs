using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Services;
using Sistemadealquilerdevehículos.Services;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class Actuazliar
{
    public static void ActuazaliarDueño()
    {
        bool salir = true;
        do
        {
            Guid id = ConsolaInput.PedirGuid("Colocar id: ");
            Dueño dueño = ServiceVerifiDueños.BuscarPorId(id);

            int opcion;
            
            if (dueño != null)
            {
                Mostrar.MostrarDueño(dueño);
                Menu.MenuActualziarDueño();
                //nombre edad telefono salir
                opcion = ConsolaInput.PedirEntero("Seleccionar Opcion de Busqueda",1,4);
                
            }
            else
            {
                Console.WriteLine("=========================");
                Console.WriteLine("=== dueño no existe ===");
                Console.WriteLine("=========================");
                opcion = 4;
            }
            

            switch (opcion)
            {
                case 1:
                    string nombre = ConsolaInput.PedirTexto("Nombre: ");
                    ServiceVerifiDueños.ActuazliarDueño(dueño, nombre, dueño.Edad,dueño.Telefono);
                    break;
                case 2:
                    int edad = ConsolaInput.PedirEntero("Edad: ");
                    ServiceVerifiDueños.ActuazliarDueño(dueño, dueño.Nombre, edad,dueño.Telefono);
                    break;
                case 3:
                    string telefono = ConsolaInput.PedirTexto("Telefono: ");
                    ServiceVerifiDueños.ActuazliarDueño(dueño, dueño.Nombre, dueño.Edad,telefono);
                    break;
                case 4:
                    salir = false;
                    break;
                default:
                    Console.WriteLine("====================");
                    Console.WriteLine("= numero no valido =");
                    Console.WriteLine("====================");
                    salir = false;
                    break;
            }
        } while (salir);
        
    }
    
    public static void ActuazaliarMascota()
    {
        bool salir = true;
        do
        {
            //string nombre, int edad, string raza, string sintoma, Dueño dueño
            Guid id = ConsolaInput.PedirGuid("Colocar id: ");
            Mascota mascota = ServiceVerifiMascotas.BuscarPorId(id);
            
            int opcion;
            
            if (mascota != null)
            {
                Mostrar.MostrarMascota(mascota);
                Menu.MenuActualziarMascota();
                //nombre edad telefono salir
                opcion = ConsolaInput.PedirEntero("Seleccionar Opcion de Busqueda",1,5);
                
            }
            else
            {
                Console.WriteLine("=========================");
                Console.WriteLine("=== dueño no existe ===");
                Console.WriteLine("=========================");
                opcion = 4;
            }

            switch (opcion)
            {
                
                case 1:
                    string nombre = ConsolaInput.PedirTexto("Nombre: ");
                    ServiceVerifiMascotas.Actualizar(mascota, nombre, mascota.Edad, mascota.Raza,mascota.Sintoma);
                    break;
                case 2:
                    int edad = ConsolaInput.PedirEntero("Edad: ");
                    ServiceVerifiMascotas.Actualizar(mascota, mascota.Nombre, edad, mascota.Raza,mascota.Sintoma);
                    break;
                case 3:
                    string raza = ConsolaInput.PedirTexto("Raza: ");
                    ServiceVerifiMascotas.Actualizar(mascota, mascota.Nombre, mascota.Edad, raza,mascota.Sintoma);
                    break;
                case 4:
                    string sintoma = ConsolaInput.PedirTexto("Sintoma: ");
                    ServiceVerifiMascotas.Actualizar(mascota, mascota.Nombre, mascota.Edad, mascota.Raza,sintoma);
                    break;
                case 5:
                    salir = false;
                    break;
                default:
                    Console.WriteLine("====================");
                    Console.WriteLine("= numero no valido =");
                    Console.WriteLine("====================");
                    salir = false;
                    break;
            }
        } while (salir);
    }
}
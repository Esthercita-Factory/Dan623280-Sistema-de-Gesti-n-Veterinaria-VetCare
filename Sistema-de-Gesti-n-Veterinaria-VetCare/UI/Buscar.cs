using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Services;
using Sistemadealquilerdevehículos.Services;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class Buscar
{
    
    public static void BuscarDueño()
    {
        bool salir = true;
        do
        {
            Menu.MenuSelectDueño();
            // id nombre edad telefono salir
            int opcion = ConsolaInput.PedirEntero("Seleccionar Opcion de Busqueda");

            switch (opcion)
            {
                case 1: 
                    Guid id = ConsolaInput.PedirGuid("Colocar id: ");
                    Dueño dueño = ServiceVerifiDueños.BuscarPorId(id);
                    if (dueño != null)
                    {
                        Mostrar.MostrarDueño(dueño);
                    }
                    else
                    {
                        Console.WriteLine("=======================");
                        Console.WriteLine("=== Dueño no existe ===");
                        Console.WriteLine("=======================");
                    }
                    break;
                case 2:
                    string nombre = ConsolaInput.PedirTexto("Nombre: ");
                    List<Dueño> listanombre =ServiceVerifiDueños.BuscarPorNombre(nombre);
                    Mostrar.MostrarDueños(listanombre);
                    break;
                case 3:
                    int edad = ConsolaInput.PedirEntero("Edad: ");
                    List<Dueño> listaedad =ServiceVerifiDueños.BuscarPorEdad(edad);
                    Mostrar.MostrarDueños(listaedad);
                    break;
                case 4:
                    string telefono = ConsolaInput.PedirTexto("Telefono: ");
                    List<Dueño> listatelefono =ServiceVerifiDueños.BuscarPorTelefono(telefono);
                    Mostrar.MostrarDueños(listatelefono);
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
    
    public static void BuscarMascota()
    {
        bool salir = true;
        do
        {
            //string nombre, int edad, string raza, string sintoma, Dueño dueño
            Menu.MenuSelectMacota();
            
            int opcion = ConsolaInput.PedirEntero("Seleccionar Opcion de Busqueda");

            switch (opcion)
            {
                case 1: 
                    Guid id = ConsolaInput.PedirGuid("Colocar id: ");
                    Mascota mascota = ServiceVerifiMascotas.BuscarPorId(id);
                    if (mascota != null)
                    {
                        Mostrar.MostrarMascota(mascota);
                    }
                    else
                    {
                        Console.WriteLine("=========================");
                        Console.WriteLine("=== mascota no existe ===");
                        Console.WriteLine("=========================");
                    }
                    break;
                case 2:
                    string nombre = ConsolaInput.PedirTexto("Nombre: ");
                    List<Mascota> listanombre = ServiceVerifiMascotas.BuscarPorNombre(nombre);
                    Mostrar.MostrarMascotas(listanombre);
                    break;
                case 3:
                    int edad = ConsolaInput.PedirEntero("Edad: ");
                    List<Mascota> listaedad = ServiceVerifiMascotas.BuscarPorEdad(edad);
                    Mostrar.MostrarMascotas(listaedad);
                    break;
                case 4:
                    string raza = ConsolaInput.PedirTexto("Raza: ");
                    List<Mascota> listaraza = ServiceVerifiMascotas.BuscarPorRaza(raza);
                    Mostrar.MostrarMascotas(listaraza);
                    break;
                case 5:
                    string sintoma = ConsolaInput.PedirTexto("Sintoma: ");
                    List<Mascota> listasintoma = ServiceVerifiMascotas.BuscarPorSintoma(sintoma);
                    Mostrar.MostrarMascotas(listasintoma);
                    break;
                case 6:
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
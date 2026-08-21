using System.Security.Cryptography.X509Certificates;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Services;
using Sistemadealquilerdevehículos.Services;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class Opciones
{
    // Console.WriteLine("8. Eliminar Dueño");
    // Console.WriteLine("9. Eliminar Mascota");
    // Console.WriteLine("10.  Salir");
    public static bool opcion()
    {
        Console.Write("Colocar opcion: ");
        int opcion = ConsolaInput.PedirEntero("Opcion: ",0,10);

        switch (opcion)
        {
            case 0:
                List<Dueño> dueños = ServiceVerifiDueños.ObtenerTodos(); 
                Mostrar.MostrarDueños(dueños);
                return true;
                break;
            case 1:
                List<Mascota> mascotas = ServiceVerifiMascotas.ObtenerTodos();
                Mostrar.MostrarMascotas(mascotas);
                return true;
                break;
            
            case 2:
                Ingresar.IngresarDueño();
                return true;
                break;
            
            case 3:
                Ingresar.IngresarMacota();
                return true;
                break;
            case 4:
                Buscar.BuscarDueño();
                return true;
                break;
            case 5:
                Buscar.BuscarMascota();
                return true;
                break;
            case 6:
                Actuazliar.ActuazaliarDueño();
                return true;
                break;
            
            case 7:
                Actuazliar.ActuazaliarMascota();
                return true;
                break;
            
            case 8:
                Eliminar.EliminarDueño();
                return true;
                break;
            case 9:
                Eliminar.EliminarMascota();
                return true;
                break;
            case 10:
                Console.WriteLine("==================");
                Console.WriteLine("= Salida Exitosa =");
                Console.WriteLine("==================");
                return false;
                break;
            default:
                Console.WriteLine("====================");
                Console.WriteLine("= numero no valido =");
                Console.WriteLine("====================");
                return true;
                break;
        }
    }
    
}
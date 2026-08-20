using System.Security.Cryptography.X509Certificates;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Services;
using Sistemadealquilerdevehículos.Services;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class Opciones
{
    
    
    
    // Console.WriteLine(" 5. Buscar Dueño");
    // Console.WriteLine(" 6. Buscar Mascota");
    // Console.WriteLine(" 7. Salir");
    
    public static bool opcion()
    {
        Console.Write("Colocar opcion: ");
        int opcion = ConsolaInput.PedirEntero("Opcion: ",0,7);

        switch (opcion)
        {
            case 1:
                Mostrar.MostrarDueños();
                return true;
                break;
            case 2:
                Mostrar.MostrarMascotas();
                return true;
                break;
            
            case 3:
                Ingresar.IngresarDueño();
                return true;
                break;
            
            case 4:
                Ingresar.IngresarMacota();
                return true;
                break;
            
            case 7:
                
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
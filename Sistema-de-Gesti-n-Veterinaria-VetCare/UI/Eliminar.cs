using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Services;
using Sistemadealquilerdevehículos.Services;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class Eliminar
{
    public static void EliminarDueño()
    {
        Guid id = ConsolaInput.PedirGuid("Colocar id: ");
        Dueño dueño = ServiceVerifiDueños.BuscarPorId(id);

        if (dueño != null)
        {
            Console.WriteLine("=====================================");
            Console.WriteLine("=== dueño eliminado correctamente ===");
            Console.WriteLine("=====================================");
            ServiceVerifiDueños.Eliminar(dueño);
        }
        else
        {
            Console.WriteLine("===============================");
            Console.WriteLine("=== no se encontro el dueño ===");
            Console.WriteLine("===============================");
        }
    }

    public static void EliminarMascota()
    {
        Guid id = ConsolaInput.PedirGuid("Colocar id: ");
        Mascota mascota = ServiceVerifiMascotas.BuscarPorId(id);

        if (mascota != null)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("=== mascota eliminado correctamente ===");
            Console.WriteLine("=======================================");
            ServiceVerifiMascotas.Eliminar(mascota);
        }
        else
        {
            Console.WriteLine("=================================");
            Console.WriteLine("=== no se encontro la mascota ===");
            Console.WriteLine("=================================");
        }
    }
}
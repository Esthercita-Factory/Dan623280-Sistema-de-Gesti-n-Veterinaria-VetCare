namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;
using System.Text.RegularExpressions;

public class ConsolaInput
{
    /// <summary>
    /// Solicita un número entero de forma segura, repitiendo la petición hasta que sea válido.
    /// </summary>
    public static int PedirEntero(string mensaje, int min = int.MinValue, int max = int.MaxValue)
    {
        while (true)
        {
            Console.Write($"{mensaje} ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int numero))
            {
                if (numero >= min && numero <= max)
                {
                    return numero; // Dato correcto, salimos del ciclo
                }
                Console.WriteLine($"❌ Error: El número debe estar entre {min} y {max}.");
            }
            else
            {
                Console.WriteLine("❌ Error: Ingrese un número entero válido.");
            }
        }
    }

    /// <summary>
    /// Solicita un texto de forma segura con validaciones personalizadas opcionales.
    /// </summary>
    public static string PedirTexto(string mensaje, string patronRegex = null, string mensajeErrorRegex = "Formato no válido.")
    {
        while (true)
        {
            Console.Write($"{mensaje} ");
            string entrada = Console.ReadLine()?.Trim();

            if (string.IsNullOrWhiteSpace(entrada))
            {
                Console.WriteLine("❌ Error: El campo no puede estar vacío.");
                continue;
            }

            // Si se envió un patrón de expresiones regulares, lo validamos
            if (patronRegex != null && !Regex.IsMatch(entrada, patronRegex))
            {
                Console.WriteLine($"❌ Error: {mensajeErrorRegex}");
                continue;
            }

            return entrada; // Dato correcto, salimos del ciclo
        }
    }
}
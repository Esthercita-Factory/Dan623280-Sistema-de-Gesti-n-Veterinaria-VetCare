using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Sistemadealquilerdevehículos.Services;

public class InputDate
{
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

    //////////////////////////////////////////////////////////////////////////////////////
    /// Solicita un texto de forma segura con validaciones personalizadas opcionales. ///
    ////////////////////////////////////////////////////////////////////////////////////
    public static string PedirTexto(string mensaje, string patronRegex = null, string mensajeErrorRegex = "Formato no válido.")
    {
        while (true)
        {
            Console.Write($"{mensaje} ");
            string entrada = Console.ReadLine().Trim();

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
    
    public static double PedirDouble(string mensaje, int min = int.MinValue, int max = int.MaxValue)
    {
        while (true)
        {
            Console.Write($"{mensaje} ");
            string entrada = Console.ReadLine();

            if (double.TryParse(entrada, out double numero))
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
    
    public static Guid? PedirGuid(string mensaje)
    {
        while (true)
        {
            Console.Write($"{mensaje} ");
            string entrada = Console.ReadLine()?.Trim();

            if (entrada == "0")
            {
                return null;
            }

            if (Guid.TryParse(entrada, out Guid id) && id != Guid.Empty)
            {
                return id;
            }

            Console.WriteLine("❌ Error: Ingrese un Guid válido o 0 para cancelar.");
        }
    }
    
    public static DateTime? PedirFecha(string mensaje)
    {
        while (true)
        {
            Console.Write($"{mensaje} ");
            string entrada = Console.ReadLine()?.Trim();

            if (entrada == "0")
            {
                return null;
            }
            if (DateTime.TryParseExact(
                    entrada,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime fecha))
            {
                return fecha;
            }

            Console.WriteLine("❌ Error: Ingrese una fecha válida. Ejemplo: 25/08/2026");
        }
    }
      
}
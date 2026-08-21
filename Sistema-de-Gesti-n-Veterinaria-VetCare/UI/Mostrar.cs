using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Services;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class Mostrar
{
    public static void MostrarDueño(Dueño dueño)
    {
        Console.Write("dueño, ");
        Console.Write($"id: {dueño.Id}, ");
        Console.Write($"Nombre: {dueño.Nombre}, ");
        Console.Write($"Edad: {dueño.Edad}, ");
        Console.WriteLine($"Telefono: {dueño.Telefono}");
    }
    public static void MostrarMascota(Mascota mascota)
    {
        
        Console.Write("Mascota, ");
        Console.Write($"id: {mascota.Id}, ");
        Console.Write($"Nombre: {mascota.Nombre}, ");
        Console.Write($"Edad: {mascota.Edad}, ");
        Console.Write($"Raza: {mascota.Raza}, ");
        Console.WriteLine($"Sintoma: {mascota.Sintoma}, ");
        MostrarDueño(mascota.Dueño);
        Console.WriteLine(" ");
        
    }

    public static void MostrarDueños(List<Dueño> dueños)
    {
        
        if (dueños.Count == 0)
        {
            Console.WriteLine("===============================");
            Console.WriteLine("== No hay Dueños Registrados ==");
            Console.WriteLine("===============================");
        }
        else
        {
            foreach (var d in dueños)
            {
                MostrarDueño(d);
            }   
        }
             
    }

    public static void MostrarMascotas(List<Mascota> mascotas)
    {
        
        if (mascotas.Count == 0)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("== No hay Mascotas Registradas ==");
            Console.WriteLine("=================================");
        }
        else
        {
            foreach (var m in mascotas)
            {
                MostrarMascota(m);
            }
        }
        
    }
}
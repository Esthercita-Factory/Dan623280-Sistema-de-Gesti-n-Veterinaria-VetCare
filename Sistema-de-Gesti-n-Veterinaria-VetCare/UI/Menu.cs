namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class Menu
{
    public static void MenuPrincipal()
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ==========================");
        Console.WriteLine(" ==== Menu Veterinaria ====");
        Console.WriteLine(" ==========================");
        Console.WriteLine(" ");
        
        Console.WriteLine(" 1. Mostrar Dueños");
        Console.WriteLine(" 2. Mostrar Mascotas");
        Console.WriteLine(" 3. Ingresar Dueño");
        Console.WriteLine(" 4. Ingrear Mascotas");
        Console.WriteLine(" 5. Buscar Dueño");
        Console.WriteLine(" 6. Buscar Mascota");
        Console.WriteLine(" 7. Salir");
        Console.WriteLine(" ");
            
    }

    public static void MenuSelectDueño()
    //
    {
        Console.WriteLine(" ");
        Console.WriteLine(" =========================");
        Console.WriteLine(" === Seleccionar Dueño ===");
        Console.WriteLine(" =========================");
        Console.WriteLine(" ");
        Console.WriteLine("1. Id");
        Console.WriteLine("2. Nombre");
        Console.WriteLine("3. Edad");
        Console.WriteLine("4. Telefono");
        Console.WriteLine("5. Salir");
        Console.WriteLine(" ");
    }
    
    public static void MenuSelectMacota()
        //string nombre, int edad, string raza, string sintoma, Dueño dueño
    {
        Console.WriteLine(" ");
        Console.WriteLine(" ==========================");
        Console.WriteLine(" === Seleccionar Macota ===");
        Console.WriteLine(" ==========================");
        Console.WriteLine(" ");
        Console.WriteLine("1. Id");
        Console.WriteLine("2. Nombre");
        Console.WriteLine("3. Edad");
        Console.WriteLine("4. Raza");
        Console.WriteLine("5. Sintoma");
        Console.WriteLine("6. Dueño");
        Console.WriteLine("7. Salir");
        Console.WriteLine(" ");
    }
}
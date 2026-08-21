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
        
        Console.WriteLine("0. Mostrar Dueños");
        Console.WriteLine("1. Mostrar Mascotas");
        Console.WriteLine("2. Ingresar Dueño");
        Console.WriteLine("3. Ingrear Mascotas");
        Console.WriteLine("4. Buscar Dueño");
        Console.WriteLine("5. Buscar Mascota");
        Console.WriteLine("6. Actualizar Dueño");
        Console.WriteLine("7. Actualizar Mascota");
        Console.WriteLine("8. Eliminar Dueño");
        Console.WriteLine("9. Eliminar Mascota");
        Console.WriteLine("10.  Salir");
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
    
    public static void MenuActualziarDueño()
        //
    {
        Console.WriteLine(" ");
        Console.WriteLine(" =====================================");
        Console.WriteLine(" === Seleccionar Dato a Actualizar ===");
        Console.WriteLine(" =====================================");
        Console.WriteLine(" ");
        Console.WriteLine("1. Nombre");
        Console.WriteLine("2. Edad");
        Console.WriteLine("3. Telefono");
        Console.WriteLine("4. Salir");
        Console.WriteLine(" ");
    }
    
    public static void MenuActualziarMascota()
        //
    {
        Console.WriteLine(" ");
        Console.WriteLine(" =====================================");
        Console.WriteLine(" === Seleccionar Dato a Actualizar ===");
        Console.WriteLine(" =====================================");
        Console.WriteLine(" ");
        Console.WriteLine("1. Nombre");
        Console.WriteLine("2. Edad");
        Console.WriteLine("3. Raza");
        Console.WriteLine("4. Sintoma");
        Console.WriteLine("5. Salir");
        Console.WriteLine(" ");
    }
    
}
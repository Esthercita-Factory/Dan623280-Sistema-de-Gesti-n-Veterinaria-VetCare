namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class User_Menu_M
{
    public static void Menu_M_Pacientes()
    {
        Console.WriteLine("1. Registrar paciente");
        Console.WriteLine("2. Listar pacientes");
        Console.WriteLine("3. Consultar paciente");
        Console.WriteLine("4. Eliminar paciente");
        Console.WriteLine("5. Actualizar paciente");
        Console.WriteLine("6. Salir");
    }
    
    public static void Menu_M_Dueños()
    {
        Console.WriteLine("1. Registrar Dueños");
        Console.WriteLine("2. Listar Dueños");
        Console.WriteLine("3. Consultar Dueños");
        Console.WriteLine("4. Eliminar Dueños");
        Console.WriteLine("5. Actualizar Dueños");
        Console.WriteLine("6. Salir");
    }
    public static void Menu_M_Principal()
    {
        Console.WriteLine("1. Gestionar PAcientes");
        Console.WriteLine("2. Gestionar  Dueños");
        Console.WriteLine("6. Salir");
    }
}
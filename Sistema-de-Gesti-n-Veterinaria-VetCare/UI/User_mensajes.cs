namespace Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

public class User_mensajes
{
    public static void Mensajes(string tipo)
    {
        if (tipo == "Añadidos")
        {
            Console.WriteLine("================================");
            Console.WriteLine("= Datos Añadidos Correctamente =");
            Console.WriteLine("================================");
        }
        else if (tipo == "Salida")
        {
            Console.WriteLine("==================");
            Console.WriteLine("= Salida Exitosa =");
            Console.WriteLine("==================");
        }
        else if (tipo == "no valido")
        {
            Console.WriteLine("====================");
            Console.WriteLine("= Numero no valido =");
            Console.WriteLine("====================");
        }
        
    }
}
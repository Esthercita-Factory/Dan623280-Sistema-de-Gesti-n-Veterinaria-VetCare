using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;
using Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

bool salir = true;


do
{

    User_Menu.Menu();

    Validation_menu v = new Validation_menu();

int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            v.Registrar();
            break;
        case 2:
            v.Mostrar();
            break;
        case 3:
            
            break;
        case 4:
            User_mensajes.Mensajes("Salida");
            break;
        default:
            User_mensajes.Mensajes("no valido");
            break;
    }
    
} while (salir);

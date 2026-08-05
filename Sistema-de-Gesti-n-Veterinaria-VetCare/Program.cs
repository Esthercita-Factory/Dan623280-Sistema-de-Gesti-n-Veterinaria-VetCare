using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;
using Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

bool salir = true;


do
{

    User_Menu.Menu();

    Validation_menu v = new Validation_menu();
    
    
    Console.Write("Colocar opcion: ");
    int opcion = ConsolaInput.PedirEntero("Opcion: ",0,120);

    switch (opcion)
    {
        case 1:
            v.Registrar();
            break;
        case 2:
            v.Mostrar();
            break;
        case 3:
            v.Buscar();
            break;
        case 4:
            v.Eliminar();
            break;
        case 5:
            v.Actualizar();
            break;
        case 6:
            salir = false;
            User_mensajes.Mensajes("Salida");
            break;
        default:
            User_mensajes.Mensajes("no valido");
            break;
    }
    
} while (salir);

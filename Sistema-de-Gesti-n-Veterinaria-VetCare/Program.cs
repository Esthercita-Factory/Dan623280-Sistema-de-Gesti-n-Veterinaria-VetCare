using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;
using Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;
using Sistema_de_Gesti_n_Veterinaria_VetCare.UI;

bool salir = true;


do
{
    Menu.MenuPrincipal();
    salir = Opciones.opcion();

} while (salir);

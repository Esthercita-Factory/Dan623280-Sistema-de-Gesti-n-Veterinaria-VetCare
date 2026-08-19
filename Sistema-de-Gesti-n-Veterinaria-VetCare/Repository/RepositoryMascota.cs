using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;

public static class RepositoryMascota
{
   //CRUD
   public static void Agregar(Mascota mascota)
   {
      Mascota._mascota.Add(mascota);
   }

   

   public static void Actualizar(this Mascota mascota, string nombre, int edad, string raza, string sintoma)
   {
      mascota.Nombre = nombre;
      mascota.Edad = edad;
      mascota.Raza = raza;
      mascota.Sintoma = sintoma;
   }

  

   public static void Eliminar(this Mascota mascota)
   {
      Mascota._mascota.Remove(mascota);
   }
   
   //CONSULTAS
   
   //Id
   public static Mascota? ConsultarId(Guid id)
   {
      return Mascota._mascota.FirstOrDefault(x => x.Id == id);
   }
   
   
   //Nombre
   public static Mascota ConsultarNombre(string nombre)
   {
      return  Mascota._mascota.FirstOrDefault(x => x.Nombre == nombre);
   }
   
   //Raza
   public static List<Mascota> ConsultarRaza(string raza)
   {
      
   }
   
   //Sintoma
   public static Mascota ConsultarRaza(string raza)
   {
      return Mascota._mascota.FirstOrDefault(x => x.Raza == raza);
   }
   
   
   
   
}

using Sistema_de_Gesti_n_Veterinaria_VetCare.Models;

namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Repository;

public static class RepositoryMascota
{
   //CRUD
   
   //Agregar
   public static void Agregar(Mascota mascota)
   {
      Mascota._mascota.Add(mascota);
   }
   
   //Obtener
   public static List<Mascota> ObtenerTodo()
   {
      return Mascota._mascota;
   }
   
   //Actualizar
   public static void Actualizar(this Mascota mascota, string nombre, int edad, string raza, string sintoma)
   {
      mascota.Nombre = nombre;
      mascota.Edad = edad;
      mascota.Raza = raza;
      mascota.Sintoma = sintoma;
   }

   //Eliminar
   public static void Eliminar(Mascota mascota)
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
   public static List<Mascota>? ConsultarNombre(string nombre)
   {
      return  Mascota._mascota.Where(x => x.Nombre == nombre).ToList();
   }
   
   //Edad
   public static List<Mascota>? ConsultarEdad(int edad)
   {
      return  Mascota._mascota.Where(x => x.Edad == edad).ToList();
   }
   
   //Raza
   public static List<Mascota>? ConsultarRaza(string raza)
   {
      return Mascota._mascota.Where(x => x.Raza == raza).ToList();
   }
   
   //Sintoma
   public static List<Mascota>? ConsultarSintoma(string sintoma)
   {
      return Mascota._mascota.Where(x => x.Raza == sintoma).ToList();
   }
   
   //por dueño

   public static List<Mascota>? ConsultarDueño(Dueño dueño)
   {
      return Mascota._mascota.Where(x => x.Dueño == dueño).ToList();
   }
   
   
   
   
}

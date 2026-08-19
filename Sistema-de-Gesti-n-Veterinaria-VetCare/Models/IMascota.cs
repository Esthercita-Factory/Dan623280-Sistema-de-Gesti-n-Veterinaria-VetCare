namespace Sistema_de_Gesti_n_Veterinaria_VetCare.Interfacez;

public interface IMascota
{
    public Guid Id { get; set; } 
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Raza { get; set; }
    public string Sintoma { get; set; }
    
    public Guid DueñoId { get; set; }

}
namespace AgenciaTurismo.Models;
public class PacoteTuristico
{
    public int Id { get; set; }
    public string Titulo { get; set; } = string.Empty;
    public DateTime DataInicio { get; set; }
    public int CapacidadeMaxima { get; set; }
    public decimal Preco { get; set; }
    public ICollection<PacoteTuristicoCidade> PacoteTuristicoCidades { get; set; } = new List<PacoteTuristicoCidade>();
    public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}

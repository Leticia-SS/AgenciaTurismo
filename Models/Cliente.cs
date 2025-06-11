namespace AgenciaTurismo.Models;
public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public ICollection<Reserva> Reservas { get; set; } = new List<Reserva>();
}

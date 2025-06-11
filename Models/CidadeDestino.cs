namespace AgenciaTurismo.Models;
public class CidadeDestino
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public int PaisDestinoId { get; set; }
    public PaisDestino PaisDestino { get; set; } = null!;
    public ICollection<PacoteTuristicoCidade> PacoteTuristicoCidades { get; set; } = new List<PacoteTuristicoCidade>();
}

namespace AgenciaTurismo.Models;
public class PaisDestino
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public ICollection<CidadeDestino> Cidades { get; set; } = new List<CidadeDestino>();
}

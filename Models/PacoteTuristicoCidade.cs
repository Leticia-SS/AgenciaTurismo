namespace AgenciaTurismo.Models;
public class PacoteTuristicoCidade
{
    public int PacoteTuristicoId { get; set; }
    public PacoteTuristico PacoteTuristico { get; set; } = null!;
    public int CidadeDestinoId { get; set; }
    public CidadeDestino CidadeDestino { get; set; } = null!;
}

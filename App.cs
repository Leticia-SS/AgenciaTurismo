using AgenciaTurismo.Data;

namespace AgenciaTurismo;
public class App
{
    private readonly AgenciaTurismoContext _db;
    public App(AgenciaTurismoContext db) => _db = db;

    public async Task RunAsync()
    {
        Console.WriteLine("Sistema de Agência de Turismo em execução...");
        var clientes = _db.Clientes.ToList();
        Console.WriteLine($"Clientes cadastrados: {clientes.Count}");
    }
}

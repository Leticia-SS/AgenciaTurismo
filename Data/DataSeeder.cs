using AgenciaTurismo.Models;

namespace AgenciaTurismo.Data;
public static class DataSeeder
{
    public static void Seed(AgenciaTurismoContext context)
    {
        if (context.Clientes.Any()) return;

        var brasil = new PaisDestino { Nome = "Brasil" };
        var italia = new PaisDestino { Nome = "Itália" };

        var rio = new CidadeDestino { Nome = "Rio de Janeiro", PaisDestino = brasil };
        var sp = new CidadeDestino { Nome = "São Paulo", PaisDestino = brasil };
        var roma = new CidadeDestino { Nome = "Roma", PaisDestino = italia };
        var veneza = new CidadeDestino { Nome = "Veneza", PaisDestino = italia };

        var pacote1 = new PacoteTuristico
        {
            Titulo = "Tour Brasil Incrível",
            DataInicio = DateTime.Today.AddDays(30),
            CapacidadeMaxima = 10,
            Preco = 2500m,
            PacoteTuristicoCidades = new List<PacoteTuristicoCidade>
            {
                new() { CidadeDestino = rio },
                new() { CidadeDestino = sp }
            }
        };

        var pacote2 = new PacoteTuristico
        {
            Titulo = "Descubra a Itália",
            DataInicio = DateTime.Today.AddDays(45),
            CapacidadeMaxima = 5,
            Preco = 5000m,
            PacoteTuristicoCidades = new List<PacoteTuristicoCidade>
            {
                new() { CidadeDestino = roma },
                new() { CidadeDestino = veneza }
            }
        };

        var cliente1 = new Cliente { Nome = "João da Silva", Email = "joao@email.com" };
        var cliente2 = new Cliente { Nome = "Maria Oliveira", Email = "maria@email.com" };

        var reserva1 = new Reserva { Cliente = cliente1, PacoteTuristico = pacote1, DataReserva = DateTime.Today };
        var reserva2 = new Reserva { Cliente = cliente2, PacoteTuristico = pacote1, DataReserva = DateTime.Today };
        var reserva3 = new Reserva { Cliente = cliente1, PacoteTuristico = pacote2, DataReserva = DateTime.Today };

        context.AddRange(brasil, italia, rio, sp, roma, veneza, pacote1, pacote2, cliente1, cliente2, reserva1, reserva2, reserva3);
        context.SaveChanges();
    }
}

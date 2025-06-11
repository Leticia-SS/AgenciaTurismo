using Microsoft.EntityFrameworkCore;
using AgenciaTurismo.Models;

namespace AgenciaTurismo.Data;
public class AgenciaTurismoContext : DbContext
{
    public AgenciaTurismoContext(DbContextOptions<AgenciaTurismoContext> options) : base(options) { }

    public DbSet<Cliente> Clientes => Set<Cliente>();
    public DbSet<Reserva> Reservas => Set<Reserva>();
    public DbSet<PacoteTuristico> PacotesTuristicos => Set<PacoteTuristico>();
    public DbSet<CidadeDestino> CidadesDestino => Set<CidadeDestino>();
    public DbSet<PaisDestino> PaisesDestino => Set<PaisDestino>();
    public DbSet<PacoteTuristicoCidade> PacotesTuristicosCidades => Set<PacoteTuristicoCidade>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PacoteTuristicoCidade>()
            .HasKey(pc => new { pc.PacoteTuristicoId, pc.CidadeDestinoId });

        modelBuilder.Entity<Reserva>()
            .HasIndex(r => new { r.ClienteId, r.PacoteTuristicoId, r.DataReserva })
            .IsUnique();
    }
}

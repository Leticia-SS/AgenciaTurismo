using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using AgenciaTurismo.Data;
using AgenciaTurismo;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, config) =>
    {
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
    })
    .ConfigureServices((context, services) =>
    {
        var connectionString = context.Configuration.GetConnectionString("DefaultConnection");
        services.AddDbContext<AgenciaTurismoContext>(options =>
            options.UseSqlServer(connectionString));
        services.AddTransient<App>();
    })
    .Build();

using (var scope = host.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AgenciaTurismoContext>();
    context.Database.EnsureCreated();
    DataSeeder.Seed(context);
}

var app = host.Services.GetRequiredService<App>();
await app.RunAsync();

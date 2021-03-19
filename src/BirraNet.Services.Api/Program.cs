using BirraNet.Infra.Data.Contexto;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BirraNet.Services.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var escopo = host.Services.CreateScope())
            {
                var servicos = escopo.ServiceProvider;
                var contexto = servicos.GetRequiredService<DataContext>();

                GeradorDados.Inicializar(servicos);
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

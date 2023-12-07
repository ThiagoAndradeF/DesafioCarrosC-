using Garagem.Services;
using Garagem.Services.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Garagem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                var form1 = serviceProvider.GetRequiredService<Form1>();
                Application.Run(form1);
            }

        }
        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddMemoryCache();
            services.AddTransient<IMarca, MarcaService>();
            services.AddTransient<IModelo, ModeloService>();
            services.AddTransient<IVeiculo, VeiculoService>();

            services.AddTransient<Form1>();
        }
    }
}
using Garagem.Services;
using Garagem.Services.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Garagem.Data.DbContexts;
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
            services.AddTransient<IGaragem, GaragemService>();
            services.AddDbContext<GaragemContext>(options =>
                    options.UseMySql("server=localhost;port=3306;database=minhaBaseDeDados;user=root;password=1234;",
                            new MySqlServerVersion(new Version(8, 0, 21))));
        }
    }
}
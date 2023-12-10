using Garagem.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Garagem.Data.DbContexts;
using System;
using Garagem.View;
namespace Garagem
{
    internal static class Program
    {
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
            //services.AddDbContext<GaragemContext>(options =>
            //    options.UseMySql("server=localhost;port=3306;initial catalog=Veiculos;uid=root;pwd=1234;",
            //        ServerVersion.Parse("8.0.34-mysql")));
            services.AddDbContext<GaragemContext>(options => {
                options.UseNpgsql("Host=localhost;Port=5432;Database=Garagem;Username=postgres;Password=3309;Include Error Detail=true");
            });
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            //services.AddDbContext<GaragemContext>();
            services.AddMemoryCache();
            services.AddTransient<IMarcaRepository, MarcaRepository>();
            services.AddTransient<IModeloRepository, ModeloRepository>();
            services.AddTransient<IVeiculoRepository, VeiculoRepository>();
            services.AddTransient<IGaragemRepository, GaragemRepository>();
            services.AddTransient<IAuthenticationRepository, AuthenticationRepository>();
            //services.AddScoped<Form1>();
            //services.AddScoped<MenuRestrito>();
            services.AddTransient<Form1>();
            services.AddTransient<MenuRestrito>();
        }
    }
}
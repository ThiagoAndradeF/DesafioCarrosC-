using Garagem;
using Garagem.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class GaragemContextFactory : IDesignTimeDbContextFactory<GaragemContext>
{
    public GaragemContext CreateDbContext(string[] args)
    {
        string connectionString = AppConfig.GetConnectionString();
        var optionsBuilder = new DbContextOptionsBuilder<GaragemContext>();

        // Usar UseMySql para configurar o contexto para MySQL
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        return new GaragemContext(optionsBuilder.Options);
    }
}

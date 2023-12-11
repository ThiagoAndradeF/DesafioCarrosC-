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
        optionsBuilder.UseNpgsql(connectionString);
        return new GaragemContext(optionsBuilder.Options);
    }
}

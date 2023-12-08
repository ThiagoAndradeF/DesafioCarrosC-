using Garagem.Data.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class GaragemContextFactory : IDesignTimeDbContextFactory<GaragemContext>
{
    public GaragemContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<GaragemContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Garagem;Username=postgres;Password=3309;Include Error Detail=true");
        return new GaragemContext(optionsBuilder.Options);
    }
}

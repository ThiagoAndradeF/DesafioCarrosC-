using Microsoft.Extensions.Configuration;

namespace Garagem;


public static class AppConfig
{
    public static IConfigurationRoot Configuration { get; private set; }

    static AppConfig()
    {
        try
        {
            
        }
        catch (Exception ex)
        {
            // Log ou trate a exceção conforme necessário
            throw new InvalidOperationException("Falha ao carregar as configurações", ex);
        }
        // Não foi necessário configurar muita coisa no appsetings.json
    }
    public static string GetConnectionString()
    {
        return "Server=localhost;Port=3306;Database=Garagem;Uid=root;Pwd=1234;";
    }
}

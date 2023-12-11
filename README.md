# DesafioCarrosC#
Breve descrição do seu aplicativo Windows Forms, o que ele faz e para que é usado.

## Pré-requisitos

Antes de começar, certifique-se de ter os seguintes requisitos instalados:
- [Microsoft .NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) (versão utilizada no desenvolvimento)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) (ou o sistema de banco de dados que seu aplicativo usa)
- [MySQL Workbench](https://dev.mysql.com/downloads/workbench/) (opcional, para gerenciar bancos de dados MySQL)
 **Pomelo Entity Framework Core MySQL - Versão mais atualizada
## Configuração

Para executar este aplicativo na sua máquina local, você precisará configurar a string de conexão com o banco de dados.

1. Navegue até o arquivo `AppConfig.cs` no código-fonte.
2. Localize o método `GetConnectionString()`.

   ```csharp
   public static string GetConnectionString()
   {
       return "Server=localhost;Port=3306;Database=Garagem;Uid=root;Pwd=1234;";
   }
Substitua a string de conexão padrão pela sua string de conexão pessoal.
Salve o arquivo e recompile o aplicativo.
Instalação
Para instalar o aplicativo, siga estas etapas:

Clone o repositório ou faça o download do código-fonte.
Abra a solução no Microsoft Visual Studio.
Encontre o diretório do projeto por linhda de comando e execute o comando **dotnet ef database update 
Compile o projeto para garantir que tudo está configurado corretamente.
Execute o aplicativo a partir do Visual Studio ou navegue até o diretório bin/Debug ou bin/Release e execute o executável gerado.

Uso
Logue com as credenciais: login: teste , senha: 123
Nesse aplicativo você pode adicionar veículos a uma lista, editá-los e excluílos.
Por lógica de negócio os atributos que podem ser editados são os de valor e os de observação.

Observação: No momento que escrevo esse readme os links de recuperar as informações de marca e modelo estão fora de ar.

Licença
Inclua informações sobre a licença do seu projeto. Se você ainda não escolheu uma licença, licenças open-source comuns incluem MIT, GPL e Apache 2.0.

# CRUD
Create 
Read
Update
Delete
Projeto MVC em .NET5

Comando para executar no Powershell:
dotnet tool install --global dotnet-ef
-Este comando não precisa ser baixado novamente, quando for ser criado um novo projeto.

Comando para criar um projeto MVC:
dotnet new mvc - abrir projeto mvc

Comandos para executar no projeto:
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Sqlite
dotnet add package Microsoft.EntityFrameworkCore.Sqlite.Design
-Devem ser baixados toda vez que um novo projeto MVC for criado

Comando para ser executado no PowerShell:
dotnet ef dbcontext scaffold "Data Source=app.db" Microsoft.EntityFrameworkCore.Sqlite -o Data 


Startup.cs deve ser adicionado o seguinte código no método configureService (na linha 26):
services.AddDbContext<appContext>(options => options.UseSqlite("Data Source=app.db"));

Comando para gerar o SQL do banco de dados no PowerShell:
dotnet ef migrations add ---nomedatabela(oubanco)---

Comando para gerar automaticamente Controllers e Views:
dotnet tool install --global dotnet-aspnet-codegenerator
(Se já foi criado um projeto MVC antes, e usado ele, não é necessário executa-lo novamente)

Comando para executar no projeto MVC:
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
-Esse comando deve ser executado toda vez que se for gerar automaticamente Controllers e Views

dotnet aspnet-codegenerator controller -name -Nome do controller-Controller -m -Nome da tabela do DB- -dc appContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries

## Sistema de gerenciamento de Lanches

### Descrição
- Project ASP .NET Core 6 developed with Macoratti in Udemy plataform. The objective of this project is to learn how to develop a web application with ASP .NET Core 6.
This project is a simple system to manage the sale of sandwiches.

### Tecnologias
- ASP .NET Core 6
- Entity Framework Core 6
- SQL Server
- Bootstrap 5
- Razor Pages
- C#
- HTML
- CSS
- JavaScript

### Instalação
- Clone this repository
- Open the project in Visual Studio
- Run the project

### Migração do banco de dados
- Open the Package Manager Console
- Select the project "Lanches"
- Run the command `Update-Database`

### Outros comandos
- `Add-Migration Initial`
- `Update-Database`
- `Remove-Migration`

### Comandos para Visual Studio Code
- `dotnet tool install --global dotnet-ef`
- `dotnet ef migrations add Initial`
- `dotnet ef database update`
- `dotnet ef migrations remove`

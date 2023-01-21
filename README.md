## Sistema de gerenciamento de Lanches

### Descrição
- Project ASP .NET Core 6 developed. The objective of this project is to learn how to develop a web application with ASP .NET Core 6.
This project is a simple system to manage the sale of sandwiches.
- Admin user: admin@localhost // Admin password: Numsey#2022

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

### Funcionalidades Aplicadas

- Repository Pattern
- View Model Pattern
- Injeção de Dependência
- Carrinho de compras com Session
- Autenticação e Autorização com Identity
- Paginação com ReflectionIT.Mvc.Paging
- Code-First
- Consultas LINQ
- Visualização de gráficos com Google Charts
- Upload de arquivos para o servidor

### Instalação
- Clone this repository
- Open the project in Visual Studio
- Install the SQL Server, and get the machine name like `NOTETK\\SQLEXPRESS` and change into the file 'appsettings.json'
- Run the command `Update-Database` in console applications 
- Run the project

### Migração do banco de dados
- Open the Package Manager Console
- Select the project "Lanches"
- Run the commands bellow if necessary.

### Outros comandos
- `Add-Migration Initial`
- `Update-Database`
- `Remove-Migration`

### Comandos para Visual Studio Code
- `dotnet tool install --global dotnet-ef`
- `dotnet ef migrations add Initial`
- `dotnet ef database update`
- `dotnet ef migrations remove`

### Imagem

<p align="center">
  <img src="https://github.com/eduardotks/c_sharp_asp_net_6_web_lanches/blob/main/Lanches/wwwroot/images/img_capa.png">
</p>


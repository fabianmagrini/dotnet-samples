# Introduction to Identity on ASP.NET Core

Reference: <https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-3.1&tabs=netcore-cli>

The following commands are for MacOS.

## Initial setup

Create an ASP.NET Core Web Application project with Individual User Accounts.

```sh
dotnet new webapp --auth Individual -o WebApp1
```

Apply the migrations to initialize the database. Migrations are not necessary at this step when using SQLite.

If dotnet ef has not been installed, install it as a global tool:

```sh
dotnet tool install --global dotnet-ef
```

### Test Register and Login

Run the app and register a user.

To generate a developer certificate run 'dotnet dev-certs https'. To trust the certificate (Windows and macOS only) run 'dotnet dev-certs https --trust'.

### View the Identity database

```sh
brew cask install db-browser-for-sqlite
```

### Scaffold Register, Login, LogOut, and RegisterConfirmation

If you have not previously installed the ASP.NET Core scaffolder, install it now:

```sh
dotnet tool install -g dotnet-aspnet-codegenerator
```

Scaffold Register, Login, LogOut, and RegisterConfirmation:

```sh
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet aspnet-codegenerator identity -dc WebApp1.Data.ApplicationDbContext --files "Account.Register;Account.Login;Account.Logout;Account.RegisterConfirmation"
```

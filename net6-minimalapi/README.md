# Building Minimal APIs in .NET 6

References:

* <https://docs.microsoft.com/en-au/aspnet/core/fundamentals/minimal-apis?view=aspnetcore-6.0>
* <https://docs.microsoft.com/en-au/learn/modules/build-web-api-minimal-api/>
* <https://docs.microsoft.com/en-au/learn/modules/build-web-api-minimal-database/>
* <https://docs.microsoft.com/en-au/learn/modules/build-web-api-minimal-spa/>

The following commands are for MacOS.

## Prerequisites

* Install .NET 6

## Initial setup

Create an ASP.NET Core Web Application project.

```sh
dotnet new web -o MinApi -f net6.0
```

To trust the certificate run

```sh
dotnet dev-certs https --trust
```

To run

```sh
dotnet run
```

## Add documentation with Swagger

Install swagger

```sh
dotnet add package Swashbuckle.AspNetCore --version 6.1.4
```

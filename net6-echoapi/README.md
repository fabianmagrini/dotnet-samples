# Containerising a minimal web api with Asp.Net Core 6.0

Containerising a minimal web api with Asp.Net Core 6.0.

References:

* <https://docs.microsoft.com/en-us/aspnet/core/security/docker-https?view=aspnetcore-6.0>
* <https://github.com/dotnet/dotnet-docker/blob/main/samples/run-aspnetcore-https-development.md>
* <https://github.com/dotnet/dotnet-docker/blob/main/samples/host-aspnetcore-https.md>
* <https://docs.microsoft.com/en-us/aspnet/core/security/enforcing-ssl?view=aspnetcore-6.0&tabs=visual-studio>
* <https://andrewlock.net/why-isnt-my-aspnetcore-app-in-docker-working/>

## Prerequisites

* .Net 6.0
* Docker Desktop
* Visual Studio Code
* Postman

## New webapi

This is a helloworld api and not for production!

```sh
dotnet new webapi -minimal -o EchoApi
cd EchoApi/
code .
```

## Dockerfile

Use the docker extension in Visual Studio Code to generate the dockefile, select View > Command Palette > Docker: Add Docker Files to Workspace...

```sh
docker build --pull -t echoapi .
docker image ls | grep echoapi # to verify image is built
docker run -it --rm -p 8080:80 echoapi
```

Test using postman when running:
<http://localhost:8080/>

Ctrl-c to exit.

Scan image for vulnerabilities

```sh
docker scan echoapi
```

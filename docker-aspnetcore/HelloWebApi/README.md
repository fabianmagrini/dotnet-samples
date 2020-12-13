# Containerising an Asp.Net Core 5.0 Web Api

Containerising an Asp.Net Core 5.0 Web Api.

## Prerequisites

* .Net 5.0
* Docker Desktop
* Visual Studio Code
* Postman

## New webapi

This is a helloworld api and not for production!

```sh
dotnet new webapi -o HelloWebApi --no-https
cd HelloWebApi/
code .
```

## Dockerfile

Use the docker extension in Visual Studio Code to generate the dockefile, select View > Command Palette > Docker: Add Docker Files to Workspace...

We will be experimenting with the Dockerfile so copy it to a folder "dockerfiles/starter/Dockerfile" and we will build using -f.

Then:

```sh
docker build -f dockerfiles/starter/Dockerfile -t hello-webapi:0.0.1 .
docker image ls | grep hello-webapi # to verify image is built
docker run -it --rm -p 8080:80 hello-webapi:0.0.1
```

Test using postman when running:
<http://localhost:8080/weatherforecast>

Ctrl-c to exit.

Scan image for vulnerabilities

```sh
docker scan hello-webapi:0.0.1
```

### Use Alpine base image

```sh
docker build -f dockerfiles/alpine/Dockerfile -t hello-webapi:0.0.2 .
docker run -it --rm -p 8080:80 hello-webapi:0.0.2
```

Scan image for vulnerabilities

```sh
docker scan hello-webapi:0.0.2
```

### Optimise

* Publish as a self contained executable targeting the runtime and trim to optimise the distributable size.
* Restore dependencies only once for faster build-time.
* Switch base image as using self contained executable.

```sh
docker build -f dockerfiles/optimise/Dockerfile -t hello-webapi:0.0.3 .
docker run -it --rm -p 8080:80 hello-webapi:0.0.3
```

### Run as non root

```sh
docker build -f dockerfiles/nonroot/Dockerfile -t hello-webapi:0.0.4 .
docker run -it --rm -p 8080:8080 hello-webapi:0.0.4
```

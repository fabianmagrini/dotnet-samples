# Code Walker

Traverse through a folder and execute an action on files.

References:

* <https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-iterate-through-a-directory-tree>
* <https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/>
* <https://aspnetcore.readthedocs.io/en/stable/fundamentals/configuration.html>
* <https://andrewlock.net/converting-web-config-files-to-appsettings-json-with-a-net-core-global-tool/>
* <https://docs.microsoft.com/en-us/dotnet/standard/base-types/regular-expression-language-quick-reference>

## Prerequisites

* .Net 6.0
* Visual Studio Code

## Getting started

```sh
dotnet new sln
# create classlib project
dotnet new classlib -o Common
dotnet sln add Common/Common.csproj
dotnet build
# create test project
dotnet new xunit -o Common.Tests
dotnet sln add ./Common.Tests/Common.Tests.csproj
dotnet add ./Common.Tests/Common.Tests.csproj reference ./Common/Common.csproj
# add library code and tests and iterate etc
dotnet test
# create console project
dotnet new console -o CodeWalker  --framework net6.0
dotnet sln add CodeWalker/CodeWalker.csproj
dotnet add CodeWalker/CodeWalker.csproj reference Common/Common.csproj
# add program code here etc
dotnet run --project CodeWalker/CodeWalker.csproj
```

## Run

```sh
dotnet run --project CodeWalker/CodeWalker.csproj
```

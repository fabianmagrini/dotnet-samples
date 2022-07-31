# Code Walker

Traverse through a folder and execute an action on files.

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

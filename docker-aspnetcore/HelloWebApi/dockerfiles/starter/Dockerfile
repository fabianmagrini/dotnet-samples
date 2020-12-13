FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["HelloWebApi.csproj", "./"]
RUN dotnet restore "HelloWebApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "HelloWebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HelloWebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HelloWebApi.dll"]

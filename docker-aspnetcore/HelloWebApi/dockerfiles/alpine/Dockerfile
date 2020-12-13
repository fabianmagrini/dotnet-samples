# Use Alpine base image
FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine AS base
WORKDIR /app
EXPOSE 80

# Use Alpine base image
FROM mcr.microsoft.com/dotnet/sdk:5.0-alpine AS build
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
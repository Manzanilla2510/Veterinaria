# FASE 1 — Imagen base para ASP.NET
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# FASE 2 — Compilación
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src

# Copiar SOLO el .csproj desde la carpeta correcta
COPY ["PVeterianaria/PVeterianaria.csproj", "./"]

# Restaurar dependencias
RUN dotnet restore "./PVeterianaria.csproj"

# Copiar todo el código
COPY . .

# Compilar el proyecto
RUN dotnet build "./PVeterianaria.csproj" -c $BUILD_CONFIGURATION -o /app/build

# FASE 3 — Publicación
FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./PVeterianaria.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

# FASE FINAL — Imagen liviana para producción
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS final
WORKDIR /app

# Copiar publicación
COPY --from=publish /app/publish ./

# Ejecutar API
ENTRYPOINT ["dotnet", "PVeterianaria.dll"]

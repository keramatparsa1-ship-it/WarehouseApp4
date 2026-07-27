FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["WarehouseApp.WebApi.sln", "./"]
COPY ["WarehouseAppWebApi/WarehouseApp.WebApi.csproj", "WarehouseAppWebApi/"]
COPY ["WarehouseApp.Application/WarehouseApp.Application.csproj", "WarehouseApp.Application/"]
COPY ["WarehouseApp.Domain/WarehouseApp.Domain.csproj", "WarehouseApp.Domain/"]
COPY ["WarehouseApp.Infrastructure/WarehouseApp.Infrastructure.csproj", "WarehouseApp.Infrastructure/"]

RUN dotnet restore "WarehouseApp.WebApi.sln"

COPY . .

WORKDIR "/src/WarehouseAppWebApi"
RUN dotnet publish "WarehouseApp.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

ENTRYPOINT ["dotnet", "WarehouseApp.WebApi.dll"]

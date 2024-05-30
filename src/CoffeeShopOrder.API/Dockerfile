#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["CoffeeShopOrder.API/CoffeeShopOrder.API.csproj", "CoffeeShopOrder.API/"]
COPY ["CoffeeShopOrder.Application/CoffeeShopOrder.Application.csproj", "CoffeeShopOrder.Application/"]
COPY ["CoffeeShopOrder.Domain/CoffeeShopOrder.Domain.csproj", "CoffeeShopOrder.Domain/"]
COPY ["CoffeeShopOrder.Infrastructure/CoffeeShopOrder.Infrastructure.csproj", "CoffeeShopOrder.Infrastructure/"]
RUN dotnet restore "CoffeeShopOrder.API/CoffeeShopOrder.API.csproj"
COPY . .
WORKDIR "/src/CoffeeShopOrder.API"
RUN dotnet build "CoffeeShopOrder.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CoffeeShopOrder.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CoffeeShopOrder.API.dll"]
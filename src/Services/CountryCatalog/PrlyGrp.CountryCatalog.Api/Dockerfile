#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/Services/CountryCatalog/PrlyGrp.CountryCatalog.Api/PrlyGrp.CountryCatalog.Api.csproj", "src/Services/CountryCatalog/PrlyGrp.CountryCatalog.Api/"]
COPY ["src/Services/CountryCatalog/PrlyGrp.CountryCatalog.Infrastructure/PrlyGrp.CountryCatalog.Infrastructure.csproj", "src/Services/CountryCatalog/PrlyGrp.CountryCatalog.Infrastructure/"]
COPY ["src/Services/CountryCatalog/PrlyGrp.CountryCatalog.ApplicationCore/PrlyGrp.CountryCatalog.ApplicationCore.csproj", "src/Services/CountryCatalog/PrlyGrp.CountryCatalog.ApplicationCore/"]
RUN dotnet restore "src/Services/CountryCatalog/PrlyGrp.CountryCatalog.Api/PrlyGrp.CountryCatalog.Api.csproj"
COPY . .
WORKDIR "/src/src/Services/CountryCatalog/PrlyGrp.CountryCatalog.Api"
RUN dotnet build "PrlyGrp.CountryCatalog.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PrlyGrp.CountryCatalog.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PrlyGrp.CountryCatalog.Api.dll"]

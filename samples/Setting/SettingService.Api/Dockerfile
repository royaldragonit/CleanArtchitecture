#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["samples/Setting/SettingService.Api/SettingService.Api.csproj", "samples/Setting/SettingService.Api/"]
COPY ["src/N8T.Core/N8T.Core.csproj", "src/N8T.Core/"]
COPY ["src/N8T.Infrastructure.EfCore/N8T.Infrastructure.EfCore.csproj", "src/N8T.Infrastructure.EfCore/"]
COPY ["src/N8T.Infrastructure/N8T.Infrastructure.csproj", "src/N8T.Infrastructure/"]
COPY ["src/N8T.Infrastructure.OTel/N8T.Infrastructure.OTel.csproj", "src/N8T.Infrastructure.OTel/"]
COPY ["samples/DataContracts/CoolStore.AppContracts/CoolStore.AppContracts.csproj", "samples/DataContracts/CoolStore.AppContracts/"]
COPY ["samples/DataContracts/CoolStore.IntegrationEvents/CoolStore.IntegrationEvents.csproj", "samples/DataContracts/CoolStore.IntegrationEvents/"]
COPY ["samples/Setting/SettingService.AppCore/SettingService.AppCore.csproj", "samples/Setting/SettingService.AppCore/"]
COPY ["samples/Setting/SettingService.Infrastructure/SettingService.Infrastructure.csproj", "samples/Setting/SettingService.Infrastructure/"]
RUN dotnet restore "./samples/Setting/SettingService.Api/SettingService.Api.csproj"
COPY . .
WORKDIR "/src/samples/Setting/SettingService.Api"
RUN dotnet build "./SettingService.Api.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./SettingService.Api.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SettingService.Api.dll"]
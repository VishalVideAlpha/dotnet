
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

ENV NUGET_PACKAGES=/root/.nuget/packages
ENV NUGET_FALLBACK_PACKAGES=
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1

COPY NuGet.config ./NuGet.config

COPY dotnetdemoapi/dotnetdemoapi/*.csproj ./dotnetdemoapi/
RUN dotnet restore ./dotnetdemoapi/dotnetdemoapi.csproj --configfile ./NuGet.config


COPY dotnetdemoapi/dotnetdemoapi/. ./dotnetdemoapi/
WORKDIR /src/dotnetdemoapi
RUN dotnet publish -c Release -o /app/publish --no-restore --configfile ../NuGet.config


FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .


ENV ASPNETCORE_URLS=http://+:5151
EXPOSE 5151

ENTRYPOINT ["dotnet", "dotnetdemoapi.dll"]

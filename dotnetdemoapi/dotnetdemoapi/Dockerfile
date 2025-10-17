
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src


ENV NUGET_PACKAGES=/root/.nuget/packages
ENV NUGET_FALLBACK_PACKAGES=
ENV DOTNET_SKIP_FIRST_TIME_EXPERIENCE=1
ENV DOTNET_CLI_TELEMETRY_OPTOUT=1


COPY dotnetdemoapi/dotnetdemoapi/*.csproj ./dotnetdemoapi/
# If you have central package management, also copy the props before the first restore:
# COPY Directory.Packages.props ./
RUN dotnet restore ./dotnetdemoapi/dotnetdemoapi.csproj


COPY dotnetdemoapi/dotnetdemoapi/. ./dotnetdemoapi/
WORKDIR /src/dotnetdemoapi
RUN dotnet restore   # <— ensures packages like Microsoft.AspNetCore.OpenApi are present


RUN dotnet publish -c Release -o /app/publish


FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:5151
EXPOSE 5151
ENTRYPOINT ["dotnet", "dotnetdemoapi.dll"]

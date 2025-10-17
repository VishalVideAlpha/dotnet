FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Ensure Linux-friendly package locations and no Windows fallback
ENV NUGET_PACKAGES=/root/.nuget/packages
ENV NUGET_FALLBACK_PACKAGES=

COPY dotnetdemoapi/dotnetdemoapi/*.csproj ./dotnetdemoapi/
RUN dotnet restore ./dotnetdemoapi/dotnetdemoapi.csproj
COPY dotnetdemoapi/dotnetdemoapi/. ./dotnetdemoapi/
WORKDIR /src/dotnetdemoapi
RUN dotnet publish -c Release -o /app/publish --no-restore
...

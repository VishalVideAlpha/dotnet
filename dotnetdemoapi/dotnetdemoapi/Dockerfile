
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY dotnetdemoapi/dotnetdemoapi/*.csproj ./dotnetdemoapi/
RUN dotnet restore ./dotnetdemoapi/dotnetdemoapi.csproj

COPY dotnetdemoapi/dotnetdemoapi/. ./dotnetdemoapi/
WORKDIR /src/dotnetdemoapi
RUN dotnet publish -c Release -o /app/publish --no-restore
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://+:5151
EXPOSE 5151
ENTRYPOINT ["dotnet", "dotnetdemoapi.dll"]

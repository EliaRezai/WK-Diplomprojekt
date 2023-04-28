# Build container. Load full SDK as base image.
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src

# TODO: Adapt the directories!
COPY Physiotool.Application Physiotool.Application
COPY Physiotool.Webapi      Physiotool.Webapi

# Compile the app
RUN dotnet restore "Physiotool.Webapi"
RUN dotnet build   "Physiotool.Webapi" -c Release -o /app/build
RUN dotnet publish "Physiotool.Webapi" -c Release -o /app/publish /p:UseAppHost=false

# App container. Only needs runtime (smaller image)
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS final
EXPOSE 80
EXPOSE 443
WORKDIR /app

COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "Physiotool.Webapi.dll"]

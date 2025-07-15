# Etapa 1 - build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

COPY *.sln .
COPY TeamTaskList.API/*.csproj TeamTaskList.API/
COPY TeamTaskList.Application/*.csproj TeamTaskList.Application/
COPY TeamTaskList.Domain/*.csproj TeamTaskList.Domain/
COPY TeamTaskList.Infrastructure/*.csproj TeamTaskList.Infrastructure/

RUN dotnet restore

COPY . .
RUN dotnet publish TeamTaskList.API/TeamTaskList.API.csproj -c Release -o /app/publish

# Etapa 2 - runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080

ENTRYPOINT ["dotnet", "TeamTaskList.API.dll"]

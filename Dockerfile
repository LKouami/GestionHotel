FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app
# Copy everything else and build
COPY . .
RUN dotnet restore GestionHotel.sln
 
RUN dotnet publish GestionHotel.API/GestionHotel.API.csproj -c Release -o out
 
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT [ "dotnet", "GestionHotel.API.dll" ]
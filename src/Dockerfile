# See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Install CIFS utilities for Samba
RUN apt-get update && apt-get install -y cifs-utils

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["API/API.csproj", "src/API/"]
COPY ["Application/Application.csproj", "src/Application/"]
COPY ["Domain/Domain.csproj", "src/Domain/"]
COPY ["Infrastructure/Infrastructure.csproj", "src/Infrastructure/"]
RUN dotnet restore "src/API/API.csproj"
COPY . .
WORKDIR "/src/API"
RUN dotnet build "API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "API.dll"]

# Commands for managing Docker
# docker rm -f $(docker ps -aq)  -- remove container
# docker rmi -f $(docker images -aq)  -- remove images
# docker build -t api:1 . -f API/Dockerfile  -- build docker image
# docker run -d --name api -p 8888:80 api:1  -- run docker api

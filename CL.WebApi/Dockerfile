#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:3.0 AS build
WORKDIR /src
COPY ["CL.WebApi/CL.WebApi.csproj", "CL.WebApi/"]
RUN dotnet restore "CL.WebApi/CL.WebApi.csproj"
COPY . .
WORKDIR "/src/CL.WebApi"
RUN dotnet build "CL.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "CL.WebApi.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "CL.WebApi.dll"]
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["./Webportfolio.csproj", "Webportfolio/"]
RUN dotnet restore "Webportfolio/Webportfolio.csproj"
COPY . ./Webportfolio
WORKDIR "/src/Webportfolio"
RUN dotnet build "Webportfolio.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Webportfolio.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Webportfolio.dll"]
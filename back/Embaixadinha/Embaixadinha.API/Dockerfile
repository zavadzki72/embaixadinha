FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY ["Embaixadinha.API/Embaixadinha.API.csproj", "Embaixadinha.API/"]
COPY ["Embaixadinha.Data/Embaixadinha.Data.csproj", "Embaixadinha.Data/"]
COPY ["Embaixadinha.Services/Embaixadinha.Services.csproj", "Embaixadinha.Services/"]

RUN dotnet restore "Embaixadinha.API/Embaixadinha.API.csproj"

COPY . .

WORKDIR "/src/Embaixadinha.API"
RUN dotnet build "Embaixadinha.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Embaixadinha.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Embaixadinha.API.dll"]
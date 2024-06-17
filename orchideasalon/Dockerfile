FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine AS base
USER $APP_UID
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["orchideasalon/orchideasalon.csproj", "orchideasalon/"]
RUN dotnet restore
COPY . .
WORKDIR "/src/orchideasalon"
RUN dotnet build "orchideasalon.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "orchideasalon.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "orchideasalon.dll"]

FROM --platform=$BUILDPLATFORM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
ARG TARGETARCH
WORKDIR /source

COPY orchideasalon/*.csproj .
RUN dotnet restore -a $TARGETARCH

COPY orchideasalon/. .
RUN dotnet publish --no-restore -a $TARGETARCH -o /app


FROM mcr.microsoft.com/dotnet/aspnet:8.0-alpine
EXPOSE 8080
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "orchideasalon.dll"]

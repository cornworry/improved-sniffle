# Learn about building .NET container images:
# https://github.com/dotnet/dotnet-docker/blob/main/samples/README.md
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.csproj .
RUN dotnet restore

# copy everything else and build app
COPY . .
RUN dotnet publish --self-contained false --no-restore -o /app


# final stage/image
FROM mcr.microsoft.com/dotnet/sdk:6.0
EXPOSE 5000
WORKDIR /app
COPY --from=build /app .
ENTRYPOINT ["dotnet", "DotNet.Docker.DiceApi.dll"]
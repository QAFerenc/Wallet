FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /sln
COPY ["src/Betsson.OnlineWallets.Tests/Betsson.OnlineWallets.Tests.csproj", "sln/Betsson.OnlineWallets.Tests/"]

RUN dotnet restore "sln/Betsson.OnlineWallets.Tests/Betsson.OnlineWallets.Tests.csproj"
COPY . .
WORKDIR "/sln/src/Betsson.OnlineWallets.Tests"
RUN dotnet build "Betsson.OnlineWallets.Tests.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Betsson.OnlineWallets.Tests.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Betsson.OnlineWallets.Tests.dll"]
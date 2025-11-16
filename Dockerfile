# -------------------------
# STAGE 1: Build the app
# -------------------------
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copy everything
COPY . .

# Restore dependencies
RUN dotnet restore HelloWorld/HelloWorld.csproj

# Build and publish
RUN dotnet publish HelloWorld/HelloWorld.csproj -c Release -o /app/publish

# -------------------------
# STAGE 2: Runtime Image
# -------------------------
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Copy published output
COPY --from=build /app/publish .

# Replace HelloWorld.dll with your actual DLL name if different
ENTRYPOINT ["dotnet", "HelloWorld.dll"]

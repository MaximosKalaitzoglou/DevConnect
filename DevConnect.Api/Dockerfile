# Use the official .NET SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Copy csproj and restore as distinct layers
COPY DevConnect.Api/*.csproj ./DevConnect.Api/
RUN dotnet restore ./DevConnect.Api/DevConnect.Api.csproj

# Copy the rest of the source code
COPY . .

# Publish the app to the /out directory
RUN dotnet publish DevConnect.Api/DevConnect.Api.csproj -c Release -o /out

# Use the ASP.NET runtime image to run the app
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /out .

# Expose port 80 inside the container
EXPOSE 80

# Start the app
ENTRYPOINT ["dotnet", "DevConnect.Api.dll"]

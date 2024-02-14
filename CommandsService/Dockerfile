# Use the .NET SDK as the build environment
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build-env

# Set the working directory inside the container
WORKDIR /app

# Copy the project file and restore dependencies
COPY *.csproj ./
RUN dotnet restore

# Copy the application files
COPY . ./

# Build the application
RUN dotnet publish -c Release -o out

# Use a smaller runtime image for the final image
FROM mcr.microsoft.com/dotnet/aspnet:8.0

# Set the working directory inside the container
WORKDIR /app

# Expose the port that the application will listen on
# EXPOSE 8081

# Copy the published output from the build environment
COPY --from=build-env /app/out .

# Specify the entry point for the container
ENTRYPOINT ["dotnet", "CommandsService.dll"]

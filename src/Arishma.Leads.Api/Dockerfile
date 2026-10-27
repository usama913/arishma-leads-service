FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY *.sln ./
COPY src/Arishma.Leads.Api/Arishma.Leads.Api.csproj src/Arishma.Leads.Api/
COPY src/Arishma.Leads.Application/Arishma.Leads.Application.csproj src/Arishma.Leads.Application/
COPY src/Arishma.Leads.Domain/Arishma.Leads.Domain.csproj src/Arishma.Leads.Domain/
COPY src/Arishma.Leads.Infrastructure/Arishma.Leads.Infrastructure.csproj src/Arishma.Leads.Infrastructure/
RUN dotnet restore src/Arishma.Leads.Api/Arishma.Leads.Api.csproj
COPY . .
RUN dotnet publish src/Arishma.Leads.Api/Arishma.Leads.Api.csproj -c Release -o /app/publish --no-restore
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app
COPY --from=build /app/publish .
ENV ASPNETCORE_URLS=http://*:5002
ENTRYPOINT ["dotnet", "Arishma.Leads.Api.dll"]

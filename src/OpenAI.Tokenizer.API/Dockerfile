#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["OpenAI.Tokenizer.API/OpenAI.Tokenizer.API.csproj", "OpenAI.Tokenizer.API/"]
RUN dotnet restore "OpenAI.Tokenizer.API/OpenAI.Tokenizer.API.csproj"
COPY . .
WORKDIR "/src/OpenAI.Tokenizer.API"
RUN dotnet build "OpenAI.Tokenizer.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OpenAI.Tokenizer.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpenAI.Tokenizer.API.dll"]
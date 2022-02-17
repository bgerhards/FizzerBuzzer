FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/FizzBuzz.Console/FizzBuzz.Console.csproj", "FizzBuzz.Console/"]
RUN dotnet restore "src/FizzBuzz.Console/FizzBuzz.Console.csproj"
COPY . .
WORKDIR "/src/FizzBuzz.Console"
RUN dotnet build "FizzBuzz.Console.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FizzBuzz.Console.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FizzBuzz.Console.dll"]

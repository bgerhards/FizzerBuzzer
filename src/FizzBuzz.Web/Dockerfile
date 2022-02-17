FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/FizzBuzz.Web/FizzBuzz.Web.csproj", "FizzBuzz.Web/"]
RUN dotnet restore "src/FizzBuzz.Web/FizzBuzz.Web.csproj"
COPY . .
WORKDIR "/src/FizzBuzz.Web"
RUN dotnet build "FizzBuzz.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FizzBuzz.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FizzBuzz.Web.dll"]

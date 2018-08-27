FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 51407
EXPOSE 44374

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["API_autoevaluacion_docker/API_autoevaluacion_docker.csproj", "API_autoevaluacion_docker/"]
RUN dotnet restore "API_autoevaluacion_docker/API_autoevaluacion_docker.csproj"
COPY . .
WORKDIR "/src/API_autoevaluacion_docker"
RUN dotnet build "API_autoevaluacion_docker.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "API_autoevaluacion_docker.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "API_autoevaluacion_docker.dll"]
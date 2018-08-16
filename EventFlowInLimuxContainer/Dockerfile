FROM microsoft/dotnet:2.0-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.0-sdk AS build
WORKDIR /src
COPY *.sln ./
COPY EventFlowInLimuxContainer/EventFlowInLimuxContainer.csproj EventFlowInLimuxContainer/
RUN dotnet restore
COPY . .
WORKDIR /src/EventFlowInLimuxContainer
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "EventFlowInLimuxContainer.dll"]

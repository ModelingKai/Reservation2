FROM mcr.microsoft.com/dotnet/core/aspnet:3.1

WORKDIR /app

COPY . .

CMD ASPNETCORE_URLS=http://*:$PORT dotnet WebApplication.dll


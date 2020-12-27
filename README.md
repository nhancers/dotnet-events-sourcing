# dotnet-events-sourcing
Sample app for demonstrating event souring using .net core and rabbit mq.

1. Creating empty solution
```shell
dotnet new webapi -o api
```

2. Add nuget packages
```shell
dotnet add package MediatR
dotnet add package MediatR.Extensions.Microsoft.DependencyInjection
```

3. Running Api
```shell
cd api
dotnet build
dotnet run
```
> This should start swagger at https://localhost:5001/swagger/index.html 
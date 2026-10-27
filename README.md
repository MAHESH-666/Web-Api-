# ASP.NET Web API Data Operations

A legacy C# ASP.NET MVC/Web API project demonstrating database-backed data access through a web application. The source includes MVC views/controllers and an Entity Framework database-first model.

## Technology

- C#
- ASP.NET Web API / ASP.NET MVC
- .NET Framework 4.7.2
- Entity Framework 6
- SQL Server
- Newtonsoft.Json
- Visual Studio / IIS Express

## Run locally

1. Open `PracticeApi.sln` in Visual Studio on Windows.
2. Restore NuGet packages.
3. Review the EDMX/model and database connection configuration in `PracticeApi/Web.config`.
4. Configure a local development database and connection string; do not put production credentials in the project.
5. Run with IIS Express.

## Scope

The project demonstrates database-oriented data operations and MVC/Web API integration. Consult the controllers and views to confirm the supported routes and workflows before relying on any endpoint.

## Maintenance notes

This is a legacy .NET Framework application. Review the dependency versions, request validation, authorization, error handling, and connection-string configuration before exposing it beyond a local development environment.

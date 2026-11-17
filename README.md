# How to load appointments on demand in Blazor Scheduler

This quick start project demonstrates how to efficiently load appointments on demand in the [Blazor Scheduler](https://www.syncfusion.com/scheduler-sdk/blazor-scheduler), fetching data asynchronously instead of loading all records upfront to improve performance. It showcases integrating the scheduler with a SQL Server database using Entity Framework Core, handling CRUD operations with load-on-demand functionality, and reducing initial load time and network overhead for scalable scheduling applications.

## Features

* On-demand appointment loading from SQL Server database
* Efficient data retrieval using Entity Framework Core
* RESTful API integration with the Scheduler component
* Database migration setup using EF Core migrations
* CRUD operations support for appointments

## Prerequisites

- Visual Studio 2026 or Visual Studio Code
- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)

## How to run the project

* Checkout this project to a location in your disk.
* Open the project (`SchedulerLoadOnDemand.csproj`) file.
* Restore the NuGet packages.
* Apply database migrations using the Package Manager console:
   ```
   PM> update-database
   ```
   This will create the database based on the application models. Ensure that the required EF Core packages are properly installed.
* Run the project

**Visual Studio Code**:

* Open the repository folder in Visual Studio Code.
* Open the integrated terminal.
* Navigate to the repository root.

```bash
cd blazor-scheduler-load-appointments-on-demand
dotnet restore
dotnet run
```

* Apply database migrations using the terminal:
   ```
   dotnet ef database update
   ```
   This will create the database based on the application models. Ensure that the required EF Core packages are properly installed.

Open the URL displayed in the terminal after the application starts.

## Documentation

For more information, refer to the following Syncfusion Blazor documentation:

* **Introduction**: https://blazor.syncfusion.com/documentation/introduction
* **Schedule Component**: https://help.syncfusion.com/scheduler-sdk/blazor/schedule/getting-started-with-server-app
* **Load on Demand**: https://help.syncfusion.com/scheduler-sdk/blazor/schedule/data-binding#load-on-demand

## Support

If you have any questions or need assistance, please refer to the official Syncfusion support channel or documentation.

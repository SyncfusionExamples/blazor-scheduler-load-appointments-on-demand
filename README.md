# How to load appointments on demand in Blazor Scheduler

This quick start project demonstrates how to efficiently load appointments on demand in the [Blazor Scheduler](https://www.syncfusion.com/blazor-components/blazor-scheduler), fetching data asynchronously instead of loading all records upfront to improve performance. It showcases integrating the scheduler with a SQL Server database using Entity Framework Core, handling CRUD operations with load-on-demand functionality, and reducing initial load time and network overhead for scalable scheduling applications.

## Prerequisites

* Visual Studio 2022 (17.14 or later) or Visual Studio Code
* .NET 10.0 SDK or later
* SQL Server Database Tools

## Key Features

* On-demand appointment loading from SQL Server database
* Efficient data retrieval using Entity Framework Core
* RESTful API integration with the Scheduler component
* Database migration setup using EF Core migrations
* CRUD operations support for appointments

## How to Run the Project

1. Checkout this project to your local machine
2. Open the solution file using Visual Studio 2022 (17.14 or later) or Visual Studio Code
3. Build the solution to restore the required NuGet packages
4. Apply database migrations using the Package Manager console:
   ```
   PM> update-database
   ```
   This will create the database based on the application models. Ensure that the required EF Core packages are properly installed.
5. Press `F5` to start the application

## Documentation

For more information, refer to the following Syncfusion Blazor documentation:

* **Introduction**: https://blazor.syncfusion.com/documentation/introduction
* **Schedule Component**: https://blazor.syncfusion.com/documentation/schedule/getting-started
* **Load on Demand**: https://blazor.syncfusion.com/documentation/scheduler/data-binding#load-on-demand

## Support

If you have any questions or need assistance, please refer to the official Syncfusion support channel or documentation.

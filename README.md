# Blazor-Scheduler-Load-appointments-on-demand

A quick start project that helps you how to load appointments on demand in the blazor Scheduler

Documentation : https://blazor.syncfusion.com/documentation/scheduler/data-binding#load-on-demand

## Prerequisites

Make sure that you have the latest versions of 'Visual Studio 2022' in your machine before starting to work on this project. Ensure that you are having SQL Server Data Tools within Visual Studio 2022.

# How to run this application?

* To run this application, you need to first clone the <code>Blazor-Scheduler-Load-appointments-on-demand</code> repository and then open it in Visual Studio 2022.
* Delete the Migration folder.
* Now create new migrations by running the following command in the Package Manager console:
> PM> Add-Migration SchedulerLoadOnDemand.Data.AppointmentDataContext
* Migrations automate the creation of database based on our Model. The EF Core packages required for migration will be added with .NET Core project setup.
* Now apply those changes to the database by running the following command:
> PM> update-database
* Now, simply build and run your project to view the output.
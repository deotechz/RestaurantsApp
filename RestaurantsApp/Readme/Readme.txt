===================================================================================================================
This project is created to learn and exercise asp.net core fundamentals using asp.net core 2.1

This is a restaurant app which can be used to view, add, edit and delete the restaurant using different techniques

Menu 'Restaurants' has been created and developed for this application.

Entity framework has been used in code first approach

NPM package manager is used to download jquery datatable control from https://datatables.net

===================================================================================================================

***Helplines***

Three components of EntityFramework are installed using Nuget Package Mananger
1. entityframeworkcore
2. entityframeworkcore.sqlserver
3. entityframeworkcore.design

Command Line
Get information about dbcontext
..\ClassLibrary.Data>dotnet ef dbcontext info -s ..\RestaurantsApp\RestaurantsApp.csproj
Add migrations
..\ClassLibrary.Data>dotnet ef migrations add initial -s ..\RestaurantsApp\RestaurantsApp.csproj
Update database
..\ClassLibrary.Data>dotnet ef database update -s ..\RestaurantsApp\RestaurantsApp.csproj
Generate migrations script
..\ClassLibrary.Data>dotnet ef migrations script -s ..\RestaurantsApp\RestaurantsApp.csproj

Download datatable jquery control from https://datatables.net

Set NodeJs path
>SET PATH=C:\Program Files\Nodejs;%PATH%

Initialize json package
>npm init for creating a package.json file

Install the dependencies in the local node_modules folder
>npm install

Install datatables jquery control
>npm install --save datatables.net-bs

Download using NuGet 
OdeToCode.UseNodeModules to serve static files from node_modules in asp.net core

Publish application
>dotnet publish -o F:\Test-codes\Dec\RestaurantsApp\Publish

Without having target framework installed on system
>dotnet publish -o F:\Test-codes\Dec\RestaurantsApp\PublishSelfContained --self-contained -r win-x64

Identify target platforms from .NET Core RID Catalog

Host ASP.NET Core on Windows with IIS
> Install the .NET Core Hosting Bundle
Restart the system or execute the following commands in a command shell:
>net stop was /y
>net start w3svc

To restart iis 
>iisreset [iisreset /start or stop]

Sql Login using IIS app pool
Login name: IIS AppPool\Restaurants
===================================================================================================================
Following exercises have been done.

## Drilling into Data
Editing Razor Pages
Adding a Razor Page
Using the Scaffolding Tools
Injecting and Using Configuration
Creating an Entity
Building a Data Access Service
Registering a Data Service
Building a Page Model
Displaying a Table of Restaurants

## Working with Models and Model Binding
Working with HTML Forms
Building a Search Form
Finding Restaurants by Name
Binding to a Query String
Using Model Binding and Tag Helpers
Building a Detail Page
Linking to the Details
Specifying Page Routes
Fetching Restaurants by ID
Handling Bad Requests

## Editing Data with Razor Pages
Creating the Restaurant Edit Page
Building an Edit Form with Tag Helpers
Model Binding an HTTP POST Operation
Adding Validation Checks
Using Model State and Showing Validation Errors
Following the POST-GET-REDIRECT Pattern
Building a Create Restaurant Page
Adding Create to the Data Access Service
Handling Create vs. Update Logic
Confirming the Last Operation

## Working with SQL Server and the Entity Framework Core
Installing the Entity Framework
Implementing an Entity Framework DbContext
Using the Entity Framework Tools
Using Other Databases and Tools
Adding Connection Strings and Registering Services
Adding Database Migrations
Running Database Migrations
Implementing a Data Access Service
Saving and Commiting Data
Modifying the Service Registration

## Building the User Interface
Using Razor Layout Pages and Sections
Implementing a Delete Restaurant Page Model
Implementing the Delete Markup
Using _ViewImports and _ViewStart Files
Reusing Markup with Partial Views
Rendering Partial Views
Implementing a ViewComponent
Rendering a ViewComponent
Scaffolding a Complete Set of CRUD Pages

## Integrating Client-side JavaScript and CSS
Serving Static Files and Content from wwwroot
Using ASP.NET Core Environments
Enforcing Validation on the Client
Loading Restaurants from the Client
Implementing an API Controller
Using DataTables
Managing Client Libraries Using npm and NodeJS
Managing Production Scripts and Development Scripts
Serving Files from the node_modules Directory
Creating Sortable, Searchable Data Grids with DataTables

## Working with the Internals of ASP.NET Core
Exploring the Application Entry Point
Processing Summer Corn with the Allen Family
Exploring the Application Middleware
Building Custom Middleware
Logging Application Messages
Configuring the App Using the Default Web Host Builder

## Deploying ASP.NET Core Web Applications
Using dotnet publish
Using MSBuld to Execute npm install
Building Self-contained Applications
Deploying to a Web Server
Exploring web.config and How IIS Hosting Works
Setting up Automatic Entity Framework Migrations
Connecting to a SQL Server Database
===================================================================================================================
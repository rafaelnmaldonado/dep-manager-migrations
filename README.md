# Department Manager
ASP.NET Core 7.0 Web API using Migrations from Entity Framework<br><br>


## How to run
1. Clone the project to your computer
2. Open with Visual Studio as a project
3. Change the connection string from __appsettings.json__ to your SQL Server connection string
4. Install __dotnet-ef__ using the command __dotnet tool install --global dotnet-ef__
5. Use the command __dotnet ef migrations remove__ to remove the migrations 
6. And __dotnet ef migrations add (migration name) -o (place to be stored)__ to create a new one
6. Run (Ctrl + F5)

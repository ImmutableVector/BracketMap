# BracketMap

---------------------------------
To set up development environment:
---------------------------------

1) Get latest Visual Studio 2019, or grab the lastest update if you already have it installed.
2) Download/Install .NET Core 3.0 SDK: https://dotnet.microsoft.com/download/dotnet-core/3.0
3) If you are not already running SQL Server, downlaod and install it
    https://www.microsoft.com/en-us/sql-server/sql-server-editions-express
   - Also get SSMS or Azure Data Studio if you want to view the database at all
    - SSMS: https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-2017
    - Azure Data Studio: https://docs.microsoft.com/en-us/sql/azure-data-studio/download?view=sql-server-2017
4) Clone the project locally
5) Open the .sln file
6) In Visual Studio, go to **Tools > Options > Preview Features**
   Check the **"Use previews of the .NET Core SDK (requires restart)" checkbox**
7) Restart Visual Studios and re-open the project
8) In Visual Studio, go to **Tools > Nuget Package > Package Manager Console**
9) Type the command: **Update-Database**
10) Build your project
11) Run it

Note: 
  - The servername you can use to view the database is **(localdb)\MSSQLLocalDB**
  - You can use postman to add data to the db if the application is running

http://localhost:52166/api/Tournament

**JSON Post Example**

{
  "name": "Ping Pong Tournament",
  "playerCount": 10
}

Finally, once data is in the db, the fetch data tab should be able to call it.

I will update the readme as the project evolves.

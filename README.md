
# ID Card Simulator

ID Card simulator project made with ASP along with MVC scaffolding mechanism.

## Features
- Resident CRUD (Create, Read, Update, Delete)
- Photo uploading
- Generating ID Card

## Tech
- [Visual Studio Community](https://visualstudio.microsoft.com/)
- [ASP MVC](https://dotnet.microsoft.com/en-us/apps/aspnet/mvc)
- [SQL](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Microsoft SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
- [Bootstrap](https://getbootstrap.com/)

## How To Run (For Visual Studio Community User)
I recommend for using [Visual Studio Community](https://visualstudio.microsoft.com/) as the text editor.

Open appsettings.json file, change "ConnectionStrings" value to your corresponding database configuration:
- Data Source=YOUR_SERVER_NAME
- Initial Catalog=YOUR_DATABASE_NAME
- User Id=YOUR_DBMS_USERNAME
- Pwd=YOUR_DBMS_PASSWORD

Afterward, run these commands in Package Manager Console (in case if you can't find the console, it located in Tools -> NuGet Package Manager -> Package Manager Console).

Adding migration to your DBMS (SQL):

```sh
 update-database
```

Finally, start running the project by clicking the run button on your text editor toolbar (or pressing Ctrl+F5).

## How To Run (For Visual Studio Code User) :

Open your CLI and go to the root directory. Afterward, run these commands below sequentially.

Install dotnet EF tools:
```sh
dotnet tool install --global dotnet-ef
```

Adding migration :

```sh
dotnet ef database update --project id-card-simulator
```

Enter build command :

```sh
 dotnet run --project id-card-simulator
```

Finally, open your browser and go to the listening port (it written on your terminal).

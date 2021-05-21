# HairSalon

#### _This application allows organization of clients and stylists, 5/21/2021_

#### By _**Brent Hubbard**_

## Description

This application will allow users to add stylists to the salon list and also let stylists add clients. Users can add themselves as a client to a specific stylist as long as they are on the list to begin with. Otherwise, they will have to add the stylist. Users will also be able to see a list of clients that belong to that specific stylist.

## Setup and Use

### Required items needed for operation

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface ie Terminal or GitBash to run and interact with the console.
- [MySQL Community Server][https://dev.mysql.com/downloads/file/?id=484914]

### Installation

1. Clone the repository: `$ git clone https://github.com/Brenthubbard/HairSalon.Solution.git`
2. Navigate to the `HairSalon.Solution` directory on your computer
3. Open with your preferred text editor to view the code base
4. To setup a SQL database using MySQL:
   - Create an `appsettings.json` file in the `HairSalon.Solution` directory
   - Copy the text box below and paste into the `appsettings.json` file, replacing `<password>` with your MySQL password:
   ```
     {
        "ConnectionStrings": {
           "DefaultConnection": "Server=localhost;Port=3306;database=brent_hubbard;uid=root;pwd=<password>;"
         }
     }
   ```
   - Open your terminal and run the command: `mysql -uroot -p<mysql_password>` (replace `<mysql_password>` with your MySQL password) and select the enter key to launch MySQL servers
   - Type the following commands to setup the database:
     - `CREATE DATABASE brent_hubbard;` to make a new database
     - `USE brent_hubbard;` to connect to the new database
     - `CREATE TABLE {stylist_category (StylistCategory INT, Name VARCHAR (255))};` to create a `{Stylist_category}` table
     - `CREATE TABLE {client_item (ClientId INT, client Int)};` to create another new `{Client_item}` table
5. To run the console app:
   - Navigate to `HairSalon.Solution` in your command line
   - Run the command `dotnet restore` to restore the dependencies that are listed in `HairSalon.csproj`
   - Run the command `dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0`
   - Run the command `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2`
   - Run the command `dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0`
   - Run the command `dotnet build` to build the project and its dependencies into a set of binaries
   - Finally, run the command `dotnet run` to run the project!
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
6. Visit the application via web browser at: `localhost:5000/`

## Known Bugs

_No known bugs_

## Support and contact details

_Feel free to reach out via my github account._

## Technologies Used

- C#
- .NET 5 SDK
- ASP.NET
- Entity Framework Core
- Bootstrap

### License

MIT License.

Copyright (c) 2021 **_Brent Hubbard_**

![Alt text](Factory/wwwroot/img/webpage.jpg?raw=true "Title")

# Dr Sillystringz's Factory

#### Web application that demonstrate many to many relationship in C#

#### Created By: Kate Kiatsiri

## Technologies Used

* C#
* .NET 5
* NuGet
* ASP.NET Core
* Entity Framework Core
* MySql
* MySql Workbench
* Bootstrap , CSS

## Description

This application is an 11th independent project at Epicodus to show understanding in ASP.Net Core MVC many-to-may relationships using mySql, Entity, and Razor. This app allows the user to manage their engineers and the machines they are licensed to repair.


## Setup and Usage Instructions

### Technology Requirements

* Download and install [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* Download and install a code text editor. Ex: [VS Code](https://code.visualstudio.com/)
* Download, install, and complete setup for [MySql Community Server](https://dev.mysql.com/downloads/file/?id=484914) and [MySql Workbench](https://dev.mysql.com/downloads/file/?id=484391).

### Installation

![Alt text](Factory/wwwroot/img/sql.jpg?raw=true "Title")

* Clone [this](https://github.com/keidsiri/Factory.Solution) repository, or download and open the Zip on your local machine
* Open the Factory.Solution folder in your preferred text editor
* To install required packages, navigate to Factory.Solution/Factory in the terminal and type the following commands:
  - dotnet add package Microsoft.EntityFrameworkCore -v 5.0.0
  - dotnet add package Pomelo.EntityFrameworkCore.MySql -v 5.0.0-alpha.2
  - dotnet add package Microsoft.EntityFrameworkCore.Proxies -v 5.0.0
  - dotnet tool install --global dotnet-ef --version 3.0.0

* Create a file named "appsettings.json" in the Factory directory
  - add the following code to the appsettings.json file:
  ```
  {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=kate_kiatsiri;uid=root;pwd=[YOUR-PASSWORD-HERE];"
    }
  }
  ```
  - replace [YOUR-PASSWORD-HERE] with your unique MySql password
* Launch the MySql server:
  - In the terminal, run the command "$ mySql -uroot -p[YOUR-PASSWORD-HERE]", replacing [YOUR-PASSWORD-HERE] with your unique MySql password
* To Import the required database:
  - In the terminal, navigate to Factory.Solution/Factory and run the command:
    - dotnet ef database update
* To Make Changes to the Database:
  - If you would like to change the database, make changes in the proper models files, then run the following commands in the terminal navigated to Factory.Solution/Factory:
    - "dotnet ef migrations add YourDescriptionHere"
    - "dotnet ef database update"
* To Restore, build, and run the project:
  - Navigate to the Factory.Solution/Factory folder in the command line or terminal
    - Run the command "$ dotnet restore" to restore the project dependencies
    - Run the command "$ dotnet build" to build and compile the project
    - Run the command "$ dotnet run" to build and compile the project
    - If the styling is not appearing in the browser, open http://localhost:5000 in an incognito browser

## Known Bugs

* none 

### License

[MIT License](https://opensource.org/licenses/MIT)
Copyright 2021 Kate Kiatsiri

## Contact Information

* [Kate Kiatsiri](github.com/keidsiri) 
[![GitHub Badge](https://img.shields.io/badge/GitHub-100000?style=for-the-badge&logo=github&logoColor=white)](https://github.com/keidsiri)
[![LinkedIn Badge](https://img.shields.io/badge/LinkedIn-0077B5?style=for-the-badge&logo=linkedin&logoColor=white)](https://www.linkedin.com/in/keidsiri)
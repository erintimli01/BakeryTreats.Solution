# _Pierre's Sweet and Savory Treats_

#### By _Erin Timlin_

#### _A C# web application requiring an account that our ol' friend Pierre can market his sweet and savory treats!_

## Technologies Used

* _.Net 6_
* _ASP.NET Core MVC 6_
* _C#_
* _MySQLWorkBench_
* _EF Core_
* _LINQ_

## Description

* _The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update, and delete functionality. All users should be able to have read functionality._

* _There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on._

* _A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it._

## Setup/Installation Requirements

* _Clone this repo_
* _Open the terminal and navigate to this project's production directory called "BakeryTreats.Solution"_
* _Within the production directory "BakeryTreats", create a new file called `appsettings.json`_
* _In `appsettings.json`, insert the following code:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=bakery_treats;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"
  }
}
```
* _Be sure to change [YOUR-USERNAME-HERE] to your username for MySQLWorkbench and [YOUR-PASSWORD-HERE] to your password for MySQLWorkbench, leaving out the square brackets_
* _In the command line, run the command `dotnet restore` to install all dependencies including EF Core. Then, run `dotnet ef database update` to allow MySQL to auto-create the required database for this project._
* _Within the production directory "BakeryTreats", run `dotnet watch run` in the command line to start the project in development mode with a watcher._
* _View saved treats and flavors on the homepage, but to see details and add your own, create an account by clicking "Create or manage an account" and signing up or logging in with your email and password_

## Known Bugs

* _Log in on the nav bar doesn't work all the time_



## License
_Please reach out with any questions or concerns! Also feel free to make any contributions!_

Copyright [MIT](license.txt) (c) _March 2023_ _Erin Timlin_
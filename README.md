# Oregon Parks API

#### Contributors: Anthony DiFalco

#### An API for state, national, and city parks in Oregon

## Technologies Used

* C#
* .NET
* ASP.NET Core
* MySQL / Entity

## Description

This project is an API that stores some basic data about parks around Oregon. Each instance of a park holds a name, location, description, and a photo url. These values are all used to populate the corresponding MVC project.

## Setup/Installation Requirements

Installation from GitHub:

* To run this program you will need to install VSCode, along with C# and .NET
* From your terminal run&emsp;`git clone https://github.com/Di-Falco/code-review-11`
* From the root directory run&emsp;`dotnet restore` &ensp; and &ensp; `dotnet build`

SQL setup:

* In the Root directory, create an appsetting.json file. The terminal command for this is&emsp;`touch appsettings.json`
* Within appsettings.json, insert the following:

`"ConnectionStrings": {`

&emsp;`  "DefaultConnection": "Server=localhost;Port=3306;database=anthony_difalco;uid=[YOUR-USERNAME-HERE];pwd=[YOUR-PASSWORD-HERE];"`

`}`
* Replace&ensp;`[YOUR-USERNAME-HERE]`&ensp;and&ensp;`[YOUR-PASSWORD-HERE]`&ensp;with your username and password for MySqlWorkbench

To access the API:

* from the root directory, run `dotnet run`
* The API can then be accessed at http://localhost:5002

## Known Bugs

* There is no https address, since this causes the program to always redirect to https and the https address can't be accessed anyway

## License

## Contact Information
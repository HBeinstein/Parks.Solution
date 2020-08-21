# National Parks API

#### Hannah Beinstein

## Description
An API to track National and State Parks with full CRUD functionality.

## Specifications


| Spec | Input | Output |
| :-------------      | :------------- | :------------- |
| 1. Program will display all parks in database | GET | "Yosemite National Park, California, National", "Zion National Park, Utah, National" |
| 2. Program will display details of a specific park in database | GET/Parks/3 | "Zion National Park, Utah, National" |
| 3. Program will add additional parks to database | POST "Smith Rock State Park, Oregon, State" | Updated Database: "Yosemite National Park, California, National", "Zion National Park, Utah, National", "Smith Rock State Park, Oregon, State" |
| 4. Program will update specified park in database | PUT "Smith Rock State Park, Oregon, National" | Updated Database: "Yosemite National Park, California, National", "Zion National Park, Utah, National", "Smith Rock State Park, Oregon, National" |
| 5. Program will delete specified park from database | DELETE "Smith Rock State Park, Oregon, State" | Updated Database: "Yosemite National Park, California, National", "Zion National Park, Utah, National" |
| 6. Program will return all parks in a specific state | GET/parks/?state=california | "Yosemite National Park, California, National" |
| 7. Program will return all National Parks or all State Parks | GET/parks/?stateOrNational=state | "Smith Rock State Park, Oregon, State"|
| 8. Program will return all National Parks or State Parks in a specific state | GET/parks/?stateOrNational=state&state=oregon | "Smith Rock State Park, Oregon, State"|


<!-- ## Swagger API Documentation -->


## Setup and Installation

* .NET Core 2.2 will need to be installed, it can be found here https://dotnet.microsoft.com/download/dotnet-core/2.2
* For Mac users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484914
* For Windows users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484919
* You will need a API development tool like Postman or a way to make API requests: https://www.postman.com/downloads/
* to clone this content, copy the url provided by the 'clone or download' button in GitHub
* Navigate to the newly created `NationalParks.Solution` directory
* Navigate to the `NationalParks` sub-directory and run `dotnet restore`
* Run `dotnet ef database update` in the terminal
* Run `dotnet build` to build the app and `dotnet run` to run it
* The web app will now be available on `http://localhost:5000/` in your browser
* You will need to get the JWT Authentication Token, Send the following code in the RAW section of your API request body

  ![Request Body](UserAuthRequest.PNG)  

  ![Response Body](AuthResponseBody.PNG)
* Copy the Token from the Value field of the Token Key from the response body of your request and attach it to the Bearer section of the header section of any requests made to API paths requiring Authentication

  ![Bearer Token](BearerTokenLocation.PNG)

## Tech used

* C#
* ASP.NET MVC
* Entity Framework Core
* MYSQL

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Hannah Beinstein
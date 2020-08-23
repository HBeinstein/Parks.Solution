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

## Setup and Installation

* Download the project from its Github repository here: https://github.com/HBeinstein/Parks.Solution.
* Make sure you have .NET Core installed. If you don't, it can be found here https://dotnet.microsoft.com/download/dotnet-core/2.2
* Mac users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484914
* Windows users, download MySQL here: https://dev.mysql.com/downloads/file/?id=484919
* To make requests, use an API development tool like Postman: https://www.postman.com/downloads/

_Once the project is downloaded:_
* Open in your code editor of choice
* Navigate to the `NationalParks.Solution` directory
* Navigate to the `NationalParks` sub-directory and run `dotnet restore` to install all dependencies
* Run `dotnet ef database update` in the terminal to create your database
* Run `dotnet build` to build the app and `dotnet run` to run it
* The project will now be available on `http://localhost:5000/` in your browser. Once you've started your server, you'll be able to make API calls in Postman. 
* Before you can access any of the API's CRUD methods, you'll need to get a JWT authentication token by making the following requests in Postman:

* First make a POST request to http://localhost:5000/users/authenticate. Be sure to include the following user credentials in the request body:
  ![Request Body](Authenticate.PNG)  

* Copy the Token value from the response body of your request. 
  ![Bearer Token](BearerTokenLocation.PNG)

* Under the Postman "Authorization" tab, select "Bearer Token" from the type options, and paste your token value in the "token" box to the right. Be sure to include this authorization token when making requests to the API-- any requests made without authorization will return a 401 Unauthorized error message.
  ![Response Body](BearerToken.PNG)

* Use the following URLs to access the API:
```
GET: http://localhost:5000/api/parks
POST: http://localhost:5000/api/parks
GET(DETAILS): http://localhost:5000/api/parks/{id}
PUT: http://localhost:5000/api/parks/{id}
DELETE: http://localhost:5000/api/parks/{id}
```

* You can filter your results by including the following parameters in your requests (add these to the end of your request URL). You can use multiple parameters by including a "&" between parameters in any request URL.
```
To filter by state, append: ?state={state name}

To show only State or National parks, append: ?stateornational={state} or ?stateornational={national}
```

* Example Request:
  ![Response Body](ExampleRequest.PNG)

* Example Result:
  ![Response Body](ExampleResult.PNG)

## Tech used

* C#
* ASP.NET MVC
* EFC
* MYSQL

### License

This project is licensed under the [MIT License](https://opensource.org/licenses/MIT).

Copyright (c) 2020 Hannah Beinstein
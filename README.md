# Animal Shelter

#### A C# API database project allowing you to browse through an animal shelter's cats and dogs via paginated results.

#### By Daniel Ware

## Technologies Used

* C#
* Entity Framework
* MySQL
* .NET 6.0
* ASP.NET
* Postman

## Setup/Installation Requirements

* Clone this repository from github
* Create an appsettings.json file in Shelter directory and add the following:
  {
  "Logging": {
    "LogLevel": {
      "Default": "Warning",
      "System": "Information",
      "Microsoft": "Information"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=Animals;uid=root;pwd=epicodus;"
  }
}

* Navigate to Shelter directory
* Run dotnet restore and dotnet build
* Run dotnet ef migrations add Initial
* Run dotnet ef database update
* Run dotnet run 

## API Endpoints

* GET http://localhost:5000/api/animals
* GET http://localhost:5000/api/animals/{id}
* GET http://localhost:5000/api/animals/page{id}
* POST http://localhost:5000/api/animals
* DELETE http://localhost:5000/api/animals/{id}
* PUT http://localhost:5000/api/animals/{id}

* Example Fields
  {
    "animalId": 1,
    "name": "Rex",
    "age": 3,
    "species": "Dog",
    "breed": "Mix",
    "gender": "Male",
    "immunizations": true
  }

## Futher Exploration

* This project explored the method of paginating the returned results into groups. The number of results returned per page is set to three for this project in AnimalController.cs but could be increased or decreased to user preference by changing the pageResults variable accordingly. The paginated results can be accessed via the GET method http://localhost:5000/api/animals/page{id} where the {id} references the page number request to be returned. 

## Known Bugs

* None

## License

MIT  (c) 2022

## Contact Information

Daniel Ware <waredanielb@gmail.com>
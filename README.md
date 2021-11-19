# Animal Shelter Api

Animal Shelter Api is for local animal shelter. This API will list the available cats and dogs at the shelter.A user may View List, Add, Edit, and Delete animals as needed and interact with the the API using Postman.

## Name of Author

  _Smita_

## Technologies used

  * C#
  * MySQL
  * My SQL Workbench
  * VS Code
  * Git BASH
  * LINQ
  * ASP .NET CORE MVC
  * Entity Framework Core
  * Postman
  * Swagger

  ## Setup/Installation Requirements

1. Download or clone the [https://github.com/smita-raj12/AnimalShelterApi.Solution](https://github.com/smita-raj12/AnimalShelterApi.Solution) to your local machine.

2. Download any Code Editor for your choice. (Here I used VSCode).

3. Open git BASH terminal and navigate to the  folder Animal Shelter Api. 

4. Add the following code to the file: appsettings.json

      
        {
          "Logging":
          {
              "LogLevel":
                {
                  "Default": "Warning",
                  "System": "Information",
                  "Microsoft": "Information"
                }
          },
          "AllowedHosts": "*",
          "ConnectionStrings":
          {
              "DefaultConnection": "Server=localhost;Port=3306;database=animal_shelter;uid={YOUR_USERNAME_NAME};pwd={YOUR_PASSWORD};"
          }
        }                                                      

5. Remove the {YOUR_USERNAME_NAME} and {YOUR_PASSWORD} and fill in the the code snippet with your username for MySQL, and MySQL password Do not include the curly brackets in your code snippet of appsettings.json

6. Make sure EF Core is installed to create and utilize migrations. Run the following code in the git BASH terminal to install. `$ dotnet tool install --global dotnet-ef --version 3.0.0`

7. Run `dotnet restore` to install required packages.

8. Run  `dotnet ef database update`

9. Run `dotnet build` in the git BASH terminal to build, and run the project in the terminal. $ dotnet watch run

10. View the API by downloading Postman and entering http://localhost:5000/api/cats or http://localhost:5000/api/dogs and http://localhost:5000/api/otherAnimals as a GET!

## Known bugs

None 

## License information with a copyright and date:

 [MIT](https://opensource.org/licenses/MIT)

## Contact information:
   
* EmailId: smita.raj12@gmail.com


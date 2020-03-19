# _Best Restaurants_

#### _Two-Day Project for Week 4 of Epicodus: Exploring Database Basics_, _Mar. 18/19, 2020_

#### By _**Dusty McCord, Joseph Wangemann, Drake Wilcox**_

## Description

This projects allows a user to keep track of their favorite restaurants and leave reviews for them. 

## Project Specifications

| Behavior | Input | Output |
|---|:---:|:---:|
|When user opens application they have a choice to see all restaurants or see all cuisines | Home | "See All Restaurants", "See All Cuisines."|
| When a user clicks "See All Cuisines", they are provided with a list of all Cuisines | Click: "See All Cuisines" | "Cuisines:" "Cuisine1", "Cuisine2" OR "Add New Cuisine"|
| When a user clicks on "Add A New Cuisine", they are directed to a form to add a new cuisine | Cick: "Add A New Cuisine | "Add A New Cuisine" Name: "Input Name" |
|When a User Adds a new Cuisine Name they are directed back to the Cuisines Index page | Name: "Spanish" Submit: "Add New Cuisine" | Cuisines: "Spanish" |
|When a user clicks on a cuisine name, they are directed to a list of Restaurants of that Cuisine | Click: "Cuisine Name" | Cuisine Details: "List of Restaurants:" |
| From the Cuisine Details Page, when a user click on "Edit Cuisine", they are directed to a Edit Page Form | Click: "Edit Cuisine" | Edit: "Cuisine Name" |
| When a user clicks on "Delete Cuisine," they are directed to a confirmation page | Click: "Delete Cuisine" | "Are you sure you want to delete this?" |
|When the user clicks on the name of a restaurant. They are directed to the detail page for that restaurant | Click: "Restaurant Name" | "Restaurant Name Deatails: |
|From the Restaurant Details Page, when the user clicks "Edit Restaurant Details", they are directed to an Restaurants/Edit Page | Click: "Edit Restaurant Details" | Edit "Restaurant Name" with Edit Form |
| After the User Submits the edit form, they are directed back to the Restaurant Details page | Click: "Save Changes" | Restaurant Index | 
| From the Restaurant Details Page, when the user clicks on Delete this restaurant, they are directed to a confirmation page | Click: "Delete This Restaurant" | "Are you sure you want delete 'Restaurant Name' |
| From the Restaurant Details page, when the user clicks on the "Add A Review Button," they are directed to a review form for that particular restaurant | Click: "Add A Review" | Add a new review for "Restaurant Name" | 
|After the User Fills out the review and submits, they are directed back to the the restaurant details page and can see their review | Submit: " "Add Review" | "'Restaurant Name' Details" |
| When a user clicks "Read Review", they are directed to a page displaying specific details from that Review | Click: "Read Review" | Review Detail Page |
|From the Home Page, when User Clicks "See all Restaurants" they are directed to an index of all restaurants with a description | Click: "See All Restaurants" | "Restaurant Index:"| 
| From the Restaurant Index Page, when the user clicks "Add New Restaurant", they are directed to an Add new Restaurant Create Page Form | Click: "Add New Restaurant" | Add A New Restaurant Form |
| After the user Adds a New Restaurant, they are directed back to the Restaurant Index, where the new restaurant can be seen| Submit: "Add Restaurant" | Restaurant Index |
| When the user enters a term into the search bar, they are returned with a list of Restaurants whose names or keywords match the search | Search: "Pizza" | Your Search Results: |

| 
||||

## Setup/Installation Requirements
_Make sure you have these tools installed on your computer:_
*  [Git version control](https://git-scm.com/downloads)
*  [MySql](https://azure.microsoft.com/en-us/free/mysql/)
*  [Microsoft .Net Core 2.2](https://docs.microsoft.com/en-us/dotnet/framework/install/)
*  [.Net Script](https://dotnet.microsoft.com/download/dotnet-core/2.2)


_In Terminal:_


* Using your terminal navigate to where you want to save this project by typing:
```sh
cd desktop
```

* Clone the file from GitHub by typing:
```sh
git clone  https://github.com/dustatron/Best-Restaurants.git
```

* Navigate to the project folder by typing:
```sh
cd Best-Restaurants/BestRestaurants
```
* Restore the project with this terminal command:
```sh
dotnet restore
```

* Open up MySql in your terminal with this command:
```sh
mysql -uroot -p{your password}
```

* Create a new table by typing:
```sh
CREATE DATABASE best_restaurant;
```

* Open your new database by typing:
```sh
USE best_restaurant;
```

* Create Cuisine table by typing:
```sh
CREATE TABLE `cuisines` (
  `CuisineId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`CuisineId`)
);
```

* Create Restaurants table by typing:
```sh
CREATE TABLE `restaurants` (
  `RestaurantId` int(11) NOT NULL AUTO_INCREMENT,
  `CuisineId` int(11) DEFAULT '0',
  `Name` varchar(255) DEFAULT NULL,
  `Address` varchar(255) DEFAULT NULL,
  `Hours` varchar(255) DEFAULT NULL,
  `Rating` int(10) DEFAULT NULL,
  `KeyWords` text,
  PRIMARY KEY (`RestaurantId`)
);
```

* Create a Reviews table by typing:
```sh
CREATE TABLE `reviews` (
  `ReviewId` int(11) NOT NULL AUTO_INCREMENT,
  `RestaurantId` int(11) DEFAULT '0',
  `UserName` varchar(255) DEFAULT NULL,
  `ReviewBody` text,
  `Rating` int(11) DEFAULT NULL,
  PRIMARY KEY (`ReviewId`)
);
```

* Now exit MySql by typing:
```sh
exit;
```

* Then start the webserver by typing:
```sh
dotnet run
```

* Open your web browser and navigate to localhost:5000
```sh
http://localhost:5000/
```

* If your setup worked you should see a welcome page with a rainbow background. 

**Note: To exit, simply press**
```sh
Ctrl + C
```

## Known Bugs

_No known bugs at this time._

## Support and contact details

This tool is provided as is. 

## Technologies Used
* [_Git_](https://git-scm.com/downloads)
* [_C#_](https://docs.microsoft.com/en-us/dotnet/csharp/)
* [_.NET Core 2.2_](https://docs.microsoft.com/en-us/dotnet/framework/install/)
* [_dotnet script_](https://github.com/filipw/dotnet-script)
* [_Asp.Net Core 2.2 MVC_](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-3.1&tabs=visual-studio)
* [_Visual Studio Code_](https://code.visualstudio.com/)
* [MySQL 8.0.15](https://downloads.mysql.com/archives/community/)
* [MySQL Workbench 8.0.15](https://downloads.mysql.com/archives/workbench/)
* [Entity Core framework](https://docs.microsoft.com/en-us/ef/)
* [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/)

### License

*This webpage is licensed under the MIT license.*

Copyright (c) 2020 **_Dusty McCord, Joseph Wangemann, Drake Wilcox_**
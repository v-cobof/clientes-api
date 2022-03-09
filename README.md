<div align="center">
  <h1>ClientesApp - VueCRUD</h1>
</div>

## About the Project 📘
Fullstack web app, that performs the four CRUD operations, using .NET 5.0, MongoDB and Vue.js. 

The main model of the application is a Customer (Cliente), and you can fill the form to add one to the database. After adding the customer, you can check it ou on the table below, and also edit It's information and delete it from the database.

## Layout - Frontend

Here are some pictures of the interface developed with Vue.js.

![image](https://user-images.githubusercontent.com/85073588/157368261-8b1fdb5e-eebd-4f15-97f4-4f37e0f730a3.png)
![image](https://user-images.githubusercontent.com/85073588/157368449-1beb6d75-be2a-4bee-b33f-1bb4621597ba.png)
![image](https://user-images.githubusercontent.com/85073588/157368997-bb5dd087-63b4-4615-b734-03e72e5b539f.png)

## Swagger - Backend

The following pictures are screenshots of the Swagger UI auto generated documentation for the API

![image](https://user-images.githubusercontent.com/85073588/157368500-60811daf-d9d4-4ec1-af28-ea2baf9a308f.png)

Each one of theese is a different route for the API, that will perform a different operation.

![image](https://user-images.githubusercontent.com/85073588/157368546-a01b715e-b550-4ae9-b4b8-83200cbcd77c.png)
![image](https://user-images.githubusercontent.com/85073588/157368578-10880cbb-3bf1-4c73-996e-6ae4ca2d7c34.png)
![image](https://user-images.githubusercontent.com/85073588/157368613-049defde-5cc4-4cfe-9261-0fe1a053dfeb.png)
![image](https://user-images.githubusercontent.com/85073588/157368655-8dcc69fb-1c74-4756-a185-a98b2caefd06.png)
![image](https://user-images.githubusercontent.com/85073588/157368684-3a2a5ce0-67f0-4d10-ae9a-b777342eb076.png)

This is the model of the data that is being transfered to perform POST and PUT actions. It doesn't contain the Id because 
this field will not be altered by the user, because it's managed by the MongoDB database.

![image](https://user-images.githubusercontent.com/85073588/157368725-b35ef84b-cd6b-4f94-8217-c6e1b6e6e3f3.png)

## Technologies ⚙️

### Backend
- C#
- .NET 5.0
- MongoDB
- MongoDB driver

### Frontend
- HTML
- CSS
- Bootstrap
- Javascript
- Vue.js

### Tools
- Git
- VS Code
- Microsoft Visual Studio
- Swagger

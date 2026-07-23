# Student Management System API

## Overview
This project is developed as part of the Zest India IT Pvt Ltd Technical Assignment.

## Technologies Used
- ASP.NET Core Web API (.NET 10)
- SQL Server
- Entity Framework Core
- JWT Authentication
- Repository Pattern
- Service Layer
- Swagger
- Global Exception Middleware
- Built-in Logging

## Features
- User Login using JWT
- Get All Students
- Get Student By Id
- Add Student
- Update Student
- Delete Student

## Database
Student Table:
- Id
- Name
- Email
- Age
- Course
- CreatedDate


## API Endpoints

| Method | Endpoint |
|--------|----------|
| POST | /api/Auth/login |
| GET | /api/Student |
| GET | /api/Student/{id} |
| POST | /api/Student |
| PUT | /api/Student/{id} |
| DELETE | /api/Student/{id} |

## Setup
1. Clone the repository.
2. Update the SQL Server connection string in `appsettings.json`.
3. Run the database migrations.
4. Start the application.
5. Test the APIs using Swagger or Postman.

## Author
Suraj Shinde

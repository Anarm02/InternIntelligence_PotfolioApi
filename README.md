# InternIntelligence Portfolio API

## Overview
InternIntelligence Portfolio API is a backend service built with **ASP.NET Core 8** to manage portfolios efficiently. It provides **CRUD** operations for skills, projects, and achievements, offering a structured approach to portfolio management.

## Features
- **CRUD Operations**: Manage skills, projects, and achievements.
- **Entity Framework Core**: Used as the ORM for database interactions.
- **MS SQL Server**: Database management system.
- **JWT Authentication**: Secure user authentication using JWT tokens.
- **Fluent Validation**: Implements validation logic for request models.
- **Swagger**: API documentation and testing support.
- **AutoMapper**: Simplifies object mapping.
- **N-Tier Architecture**: Ensures modularity and maintainability.
- **Unit of Work Pattern**: Manages database transactions efficiently.

## Installation & Setup
1. **Clone the repository**
   ```sh
   git clone https://github.com/Anarm02/InternIntelligence_PotfolioApi.git
   cd InternIntelligence_PotfolioApi
   ```
2. **Configure the database**
   - Update the `appsettings.json` file with your **MS SQL Server** connection string.
3. **Apply database migrations**
   ```sh
   dotnet ef database update
   ```
4. **Run the API**
   ```sh
   dotnet run
   ```

## API Documentation
Swagger is integrated for API documentation. After running the project, visit:
```
http://localhost:<port>/swagger/index.html
```

## Authentication
The API uses **JWT tokens** for authentication. To access protected endpoints:
1. Register/Login to obtain a **JWT token**.
2. Include the token in the `Authorization` header as **Bearer Token**.



---

# Book Store Backend

## Overview

This project is a basic backend for a book store application built using ASP.NET Core. It includes features for user registration and authentication, role-based access control, and is structured with an n-tier architecture for better scalability and maintainability.

## Features

- **User Registration & Authentication**: Users can register, log in, and access resources based on their roles.
- **Role-Based Access Control**: Different roles (e.g., Admin, User) with specific permissions.
- **N-Tier Architecture**: Separation of concerns into different layers:
  - **Presentation Layer**: Handles HTTP requests and responses.
  - **Business Logic Layer (BLL)**: Contains business rules and logic.
  - **Data Access Layer (DAL)**: Interacts with the database.
  - **Common Layer**: Contains shared entities and utility classes.
  
## Technologies Used

- **ASP.NET Core**: For building the web API.
- **Entity Framework Core**: For database access and management.
- **SQL Server**: As the database for storing user and book data.
- **Identity**: For managing user authentication and roles.
- **AutoMapper**: For mapping between entities and DTOs.
- **Unit of Work & Repository Pattern**: For managing database transactions and access.



### Screenshots


![User Registration](https://github.com/user-attachments/assets/48dba885-f2d6-4b7f-912f-28b34a4eda01)


![Book List](https://github.com/user-attachments/assets/60a8dcff-a20a-4018-b901-60311b65ef3a)


![Role Management](https://github.com/user-attachments/assets/bae27050-038f-45a8-b2e4-025a95426254)





---


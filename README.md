# TaskManager API

## Project Overview

TaskManager API is a RESTful ASP.NET Core Web API designed to manage tasks efficiently while demonstrating clean architecture principles and real-world backend design patterns. The project emphasizes separation of concerns, object-oriented design, and dependency injection.

The application uses an in-memory data store to focus on architecture and design rather than persistence.

---

## Features

The API allows clients to:

- Create new tasks
- Retrieve all tasks
- Retrieve a task by ID
- Mark tasks as completed

## Key Objectives

This project demonstrates:

- Multi-file ASP.NET Core project organization
- Application of SOLID principles
- ASP.NET Core dependency injection
- RESTful API design
- Clear separation of API, business logic, and domain models
- A scalable foundation for future enhancements

---

## High-Level Architecture

The project follows a layered architecture:

Controller Layer → Service Layer → Model Layer

### Responsibilities

**Controllers**
- Handle HTTP requests and responses
- Delegate business logic to services
  **Services**
- Contain core business logic
- Manage task operations

**Models**
- Represent domain data

**Interfaces**
- Enable loose coupling and testability


## Technologies Used

- ASP.NET Core Web API
- C#
- Dependency Injection
- RESTful API principles
- In-memory data storage
  ## Future Enhancements

- Database integration (SQL Server / MongoDB)
- Authentication and authorization
- Unit and integration testing
- Logging and global error handling
- DTOs and AutoMapper

---

## Author

Chotan  
Computer Science Undergraduate | Aspiring Software Engineer

# HR Leave Management System

A Leave Management System built using ASP.NET Core 10 and Clean Architecture principles. This project demonstrates enterprise application development practices including CQRS, MediatR, Repository Pattern, JWT Authentication, Entity Framework Core, and SQL Server.

## Project Overview

The HR Leave Management System is designed to streamline employee leave management processes within an organization. Employees can apply for leave, managers can review and approve requests, and administrators can manage leave types and allocations.

The application follows Clean Architecture to ensure separation of concerns, maintainability, scalability, and testability.

## Features

### Employee

* Login and Authentication
* Apply for Leave
* View Leave Requests
* Check Leave Balances
* Cancel Leave Requests

### Manager

* Review Leave Requests
* Approve Leave Requests
* Reject Leave Requests
* View Employee Leave History

### Administrator

* Manage Leave Types
* Manage Leave Allocations
* Manage Employees
* Manage Roles and Permissions

## Technology Stack

### Backend

* ASP.NET Core 10
* C#
* Entity Framework Core
* SQL Server

### Architecture & Design Patterns

* Clean Architecture
* CQRS Pattern
* Repository Pattern
* Dependency Injection
* Mediator Pattern

### Libraries

* MediatR
* FluentValidation
* AutoMapper
* JWT Authentication
* Swagger/OpenAPI

## Project Structure

```text
src
├── HRLeaveManagement.Domain
├── HRLeaveManagement.Application
├── HRLeaveManagement.Persistence
├── HRLeaveManagement.Infrastructure
├── HRLeaveManagement.API
└── HRLeaveManagement.Identity
```

## Getting Started

### Clone Repository

```bash
git clone https://github.com/yourusername/HRLeaveManagement-CleanArchitecture.git
```

### Restore Packages

```bash
dotnet restore
```

### Apply Database Migrations

```bash
dotnet ef database update
```

### Run Application

```bash
dotnet run
```

## Future Enhancements

* Email Notifications
* Refresh Token Authentication
* Audit Logging
* Docker Support
* Azure Deployment
* Unit & Integration Testing

## Learning Outcomes

This project helped strengthen knowledge in:

* ASP.NET Core Development
* Clean Architecture
* CQRS with MediatR
* Entity Framework Core
* JWT Authentication
* RESTful API Development
* SQL Server Database Design

## Acknowledgements

This project is inspired by Trevoir Williams' HR Leave Management Clean Architecture project and has been recreated using ASP.NET Core 10 for learning and portfolio purposes.

Original Repository:
https://github.com/trevoirwilliams/HR.LeaveManagement.CleanArchitecture-dotnet5

## Author

Dhanushkumar Radhakrishnan

Software Engineer | .NET Developer

## License

This project is intended for educational, learning, and portfolio purposes.

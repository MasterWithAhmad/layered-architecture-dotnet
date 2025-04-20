# Mini Rental System - Book Management Module

This is the *Book Management* module of the *Mini Rental System* web application, built using *ASP.NET Core MVC, **Entity Framework Core, and **Razor Views*. It features a responsive UI with dynamic modals for create/edit actions and AJAX-powered data updates.

## Architecture Overview

The solution follows a clean and maintainable architecture with a clear separation of concerns:

### 1. *Domain Layer*
- Contains core business entities such as Book.cs.
- Namespace: MiniRentalSystem.Domain.Entities

### 2. *Application Layer* (Optional, if added later)
- Business logic, DTOs, validation, and mapping logic.

### 3. *Infrastructure Layer*
- Database access using *Entity Framework Core*.
- Database context: ApplicationDbContext.cs.

### 4. *Web Layer*
- ASP.NET Core MVC controllers and views.
- Razor views used for rendering _CreateOrEdit, BookTable, and Index.

### 5. *Client-Side Enhancements*
- Uses *jQuery* and *SweetAlert2* for modal handling and confirmation dialogs.
- Partial rendering and AJAX to provide a seamless UX.

## Features

- *Add/Edit/Delete Books* via modals without page reload.
- *Dynamic refresh* of book list after actions.
- *Server-side validation* with client feedback.
- *Clean architecture* suitable for scaling with additional modules.

## Running the Project

1. Clone the repository.
2. Update appsettings.json with your DB connection.
3. Apply migrations (if not already):
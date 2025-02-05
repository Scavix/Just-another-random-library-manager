# Library Management System

A Windows Forms application for managing a library's books, users, and lending records. This project is built using .NET 8 (just me wanting to refresh memory on some tech).

## Features

- **User Management**: Register, edit, and remove users. Users can be assigned roles (Admin or User).
- **Book Management**: Add, edit, and remove books. Books can be searched by title or author.
- **Lending Management**: Lend and return books. Track lending records and due dates.
- **Authentication**: Login and register functionality with password management.

## Installation

1. Clone the repository:
```
   git clone https://github.com/Scavix/Just-another-random-library-manager.git
```
3. Open the solution in Visual Studio 2022.
4. Restore the NuGet packages.
5. Build the solution.

## Usage

1. Run the application.
2. Login with the following credentials:
    - Admin: `admin` / `admin`
    - User: `user` / `user`
3. Use the admin interface to manage users, books, and lending records.
4. Use the user interface to borrow and return books.

## Project Structure

- **LibraryManager**
  - **Book.cs**: Represents a book entity.
  - **User.cs**: Represents a user entity.
  - **Lending.cs**: Represents a lending record.
  - **BookManager.cs**: Manages book-related operations.
  - **UserManager.cs**: Manages user-related operations.
  - **LendingManager.cs**: Manages lending-related operations.
  - **loginForm.cs**: Handles user login.
  - **registerForm.cs**: Handles user registration.
  - **adminForm.cs**: Admin interface for managing users, books, and lendings.
  - **userForm.cs**: User interface for borrowing and returning books.
  - **lendingForm.cs**: Form for lending books.
  - **bookForm.cs**: Form for adding/editing books.
  - **changeForgotPasswordForm.cs**: Form for changing or recovering passwords.
  - **Roles.cs**: Enum for user roles.
  - **countries.json**: List of countries for user registration.
  - **users.json**: Sample user data.

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request.

## License

This project is licensed under the MIT License.

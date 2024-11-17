# Code First Relation - Entity Framework Core

This project demonstrates how to use the **Code First** approach in Entity Framework Core to create a database and define relationships between entities.

## Overview

The database consists of two tables with a one-to-many relationship:
1. **User Table**:
   - A user can have multiple posts.
2. **Post Table**:
   - Each post belongs to one user.

### Tables and Relationships

#### User Table
| Column      | Type   | Description                              |
|-------------|--------|------------------------------------------|
| `Id`        | `int`  | Primary key, auto-incremented.           |
| `Username`  | `string` | The username of the user.               |
| `Email`     | `string` | The email address of the user.          |

#### Post Table
| Column      | Type   | Description                              |
|-------------|--------|------------------------------------------|
| `Id`        | `int`  | Primary key, auto-incremented.           |
| `Title`     | `string` | The title of the post.                  |
| `Content`   | `string` | The content of the post.                |
| `UserId`    | `int`  | Foreign key linking the post to a user.  |

### Context Class

- **Class Name**: `PatikaSecondDbContext`
- **Database Name**: `PatikaCodeFirstDb2`
- **Generated Tables**: `Users` and `Posts`

## How It Works

1. **Define Models**:
   - `User` and `Post` models are defined with appropriate properties and data annotations.
   - A one-to-many relationship is established between `User` and `Post` using navigation properties.

2. **Configure DbContext**:
   - The `PatikaSecondDbContext` class is used to configure the database and specify the relationships.

3. **Migration**:
   - The `dotnet ef migrations add` command is used to create migrations.
   - The `dotnet ef database update` command is used to apply migrations and create the database.

## Setup Instructions

1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/code-first-relation.git
   ```

2. Open the project in Visual Studio or your preferred IDE.

3. Install Entity Framework Core:
   ```bash
   dotnet add package Microsoft.EntityFrameworkCore
   dotnet add package Microsoft.EntityFrameworkCore.SqlServer
   dotnet add package Microsoft.EntityFrameworkCore.Tools
   ```

4. Add the migration and update the database:
   ```bash
   dotnet ef migrations add InitialCreate
   dotnet ef database update
   ```

5. Run the project:
   ```bash
   dotnet run
   ```

## Key Features

- Demonstrates the Code First approach to database creation.
- Defines a one-to-many relationship between users and posts.
- Utilizes EF Core migrations to handle schema changes.

## Example Models

### User Model
```csharp
public class User
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public ICollection<Post> Posts { get; set; }
}
```

### Post Model
```csharp
public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
```

## Author

Created by **Batuhan Uzun**

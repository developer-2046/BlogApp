# BlogApp

BlogApp is a web application built with a C# .NET backend and an Angular frontend, designed to provide a platform for users to create, read, update, and delete blog posts. It utilizes Microsoft SQL Server for data persistence.

## Features

* **User Authentication:** (Assumed based on typical blog app functionality - verify from code)
    * User registration, login, and logout.
    * Secure password handling.
* **Blog Post Management (CRUD):**
    * Create new blog posts with a title and content.
    * View a list of all blog posts.
    * View individual blog posts.
    * Update existing blog posts.
    * Delete blog posts.
* **User Profiles:** (Assumed - verify from code)
    * Ability for users to manage their profiles.
* **API-Driven Backend:** C# .NET API to handle business logic and data access.
* **Dynamic Frontend:** Angular single-page application (SPA) for a responsive user experience.
* **Database:** Microsoft SQL Server for storing user and post data.

## Technologies Used

* **Backend:**
    * C#
    * ASP.NET Core (likely for API development)
    * Entity Framework Core (likely for ORM)
    * Microsoft SQL Server (Database)
* **Frontend:**
    * Angular (TypeScript, HTML, CSS/SCSS)
    * Angular CLI
    * Node.js & npm (for frontend build and package management)
* **Development Environment & Tools:**
    * Visual Studio or VS Code
    * SQL Server Management Studio (SSMS) or Azure Data Studio

## Project Structure (Conceptual)

BlogApp/├── BlogApp.API/                # ASP.NET Core Backend Project│   ├── Controllers/            # API controllers│   ├── Models/                 # Data models (Entities)│   ├── Data/                   # Database context, migrations│   ├── Services/               # Business logic services│   ├── Startup.cs              # (or Program.cs in .NET 6+)│   └── BlogApp.API.csproj│├── BlogApp.UI/                 # Angular Frontend Project│   ├── src/│   │   ├── app/                # Angular components, services, modules│   │   ├── assets/             # Static assets (images, etc.)│   │   ├── environments/       # Environment configurations│   │   └── ...│   ├── angular.json│   ├── package.json│   └── ...│├── BlogApp.sln                 # Visual Studio Solution File└── README.md
## Prerequisites

* .NET SDK (specify version, e.g., .NET 6.0 or 7.0)
* Node.js and npm (specify versions, e.g., Node.js LTS)
* Angular CLI (globally installed: `npm install -g @angular/cli`)
* Microsoft SQL Server (e.g., Express, Developer, or Standard edition)
* Git

## Setup and Installation

### Backend (BlogApp.API)

1.  **Clone the Repository:**
    ```bash
    git clone [https://github.com/developer-2046/BlogApp.git](https://github.com/developer-2046/BlogApp.git)
    cd BlogApp
    ```

2.  **Configure Database Connection:**
    * Open the backend project (e.g., `BlogApp.API/appsettings.json` or wherever your connection string is stored).
    * Update the `ConnectionString` for SQL Server to point to your local or remote SQL Server instance. Ensure the database specified in the connection string exists or will be created by migrations.
    * Example for `appsettings.json`:
        ```json
        {
          "ConnectionStrings": {
            "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=BlogAppDB;Trusted_Connection=True;MultipleActiveResultSets=true"
          },
          // ... other settings
        }
        ```

3.  **Apply Database Migrations (if using Entity Framework Core):**
    * Navigate to the backend project directory (e.g., `cd BlogApp.API`).
    * Ensure the Entity Framework Core tools are installed (`dotnet tool install --global dotnet-ef` or project-local).
    * Run migrations:
        ```bash
        dotnet ef database update
        ```
    * If migrations don't exist, you might need to create them first:
        ```bash
        dotnet ef migrations add InitialCreate
        dotnet ef database update
        ```

4.  **Build and Run the Backend:**
    * Navigate to the backend project directory.
    * Build:
        ```bash
        dotnet build
        ```
    * Run:
        ```bash
        dotnet run
        ```
    The API should now be running (typically on `http://localhost:5000` or `https://localhost:5001`, check console output).

### Frontend (BlogApp.UI)

1.  **Navigate to the Frontend Directory:**
    ```bash
    cd BlogApp.UI  # Or the actual name of your Angular project folder
    ```

2.  **Install Dependencies:**
    ```bash
    npm install
    ```

3.  **Configure API Endpoint:**
    * Locate the Angular environment file(s) (e.g., `src/environments/environment.ts` and `src/environments/environment.prod.ts`).
    * Update the `apiUrl` (or equivalent variable) to point to your running backend API.
    * Example for `environment.ts`:
        ```typescript
        export const environment = {
          production: false,
          apiUrl: 'http://localhost:5000/api' // Adjust if your API runs on a different port/path
        };
        ```

4.  **Run the Angular Development Server:**
    ```bash
    ng serve -o
    ```
    This will compile the Angular application and open it in your default web browser (typically on `http://localhost:4200/`).

## Usage

1.  Ensure both the backend API and the frontend Angular application are running.
2.  Open your browser and navigate to the Angular application URL (e.g., `http://localhost:4200/`).
3.  (Describe how to register, log in, create posts, etc.)

## Contributing

Contributions are welcome! If you'd like to contribute, please:

1.  Fork the repository.
2.  Create a new branch (`git checkout -b feature/your-feature-name`).
3.  Make your changes.
4.  Commit your changes (`git commit -m 'Add some feature'`).
5.  Push to the branch (`git push origin feature/your-feature-name`).
6.  Open a Pull Request.

---

**Note:** This README is based on common patterns for C# .NET/Angular applications. You'll need to:
* **Verify and fill in specific details:**
    * Exact .NET SDK version, Node.js version.
    * Confirm paths to configuration files (`appsettings.json`, Angular environment files).
    * Confirm actual API base URLs and any specific environment variable names.
    * Add more detail to the "Features" section based on what's implemented.
    * Add more detail to the "Usage" section.
* **Add any specific build steps or deployment notes** if applicable.
* If you have a `.sln` file at the root, mention how to open the solution in Visual Studio.

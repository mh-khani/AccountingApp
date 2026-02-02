# AccountingApp (WinForms) — Simple Accounting Desktop App

A **Windows Forms** desktop application for managing customers and recording **income/expense** transactions, with reporting and a monthly summary dashboard. Implemented with a multi-layer architecture using **Entity Framework Core + SQL Server**.

## Features

- **Customers management**: add/edit/delete, search
- **Transactions**: create and edit **Income (TypeId=1)** and **Expense (TypeId=2)**
- **Reports**:
  - Income/Expense reports with **customer** and **date range** filters
  - **Print preview / printing** for the report screen
  - **Current month summary** (Income, Expense, Balance) on the main form
- **Persian (Shamsi) date** display via `Utility.DateConvertor`
- **Login/settings**: a simple login form and an “edit user info” mode

> Note: this is a learning/practice project. For production use, it needs security hardening (see “Security notes”).

## Tech Stack

- **.NET 9** (UI project targets `net9.0-windows`)
- **Windows Forms**
- **Entity Framework Core 9** + **SQL Server**
- **Repository + UnitOfWork** pattern

## Solution Structure

- `AccountingApp/` : UI layer (WinForms)
- `Business/` : business logic (e.g., monthly report calculation)
- `DataLayer/` : EF Core models, `DbContext`, repositories, `UnitOfWork`
- `ViewModels/` : view models
- `Utility/` : utilities (e.g., Persian date conversion)
- `Test/` and `Test2/` : test/sample projects (currently minimal)

## Screenshots

Some screenshots of the application UI:

![Main Window](images/1.png)
![Customers Management](images/2.png)
![New Transaction](images/3.png)
![Reports](images/4.png)
![Login](images/5.png)

## Database

This project uses **SQL Server** and currently stores the connection string directly in code:

- File: `DataLayer/Models/AccountingDbContext.cs`
- Current default:
  - `Server=.;Database=AccountingDB;Trusted_Connection=True;TrustServerCertificate=True`

### Create/Update the Database (Migrations)

The `DataLayer` project contains EF Core migrations. To create/update the database:

```powershell
dotnet restore
dotnet ef database update --project .\DataLayer\DataLayer.csproj --startup-project .\AccountingApp\AccountingApp.csproj
```

If `dotnet ef` is not installed:

```powershell
dotnet tool install --global dotnet-ef
```

## Running the App

### Prerequisites

- Windows 10/11
- Visual Studio 2022/2025+ (or just the .NET SDK)
- SQL Server (LocalDB / Express / Developer)
- .NET Desktop Runtime for .NET 9 (if the app runs on your machine, you already have it)

### Run with Visual Studio

- Open `AccountingApp.slnx`
- Set `AccountingApp` as the Startup Project
- Run

### Build/Run with CLI

```powershell
dotnet build .\AccountingApp\AccountingApp.csproj -c Release
dotnet run --project .\AccountingApp\AccountingApp.csproj
```

## Security Notes (Before Public Publishing)

- **Passwords are stored and checked in plain text** (`LoginForm.cs` and the `User` model). This is not suitable for production.
- **Connection string is in source code** (`AccountingDbContext`). For public publishing, consider:
  - Moving it to configuration / environment variables
  - Ensuring no secrets are committed to the repository

## Suggested GitHub Settings (Description / Topics)

- **Description**:
  - "Simple accounting WinForms app (.NET 9) + EF Core + SQL Server | Customers & transactions + reporting"
- **Topics**:
  - `dotnet`, `csharp`, `winforms`, `entity-framework-core`, `sql-server`, `accounting`, `desktop-app`, `persian-calendar`

## Publishing to GitHub (Quick Steps)

From the repository root:

```powershell
git init
git add .
git commit -m "Initial commit"
git branch -M main
git remote add origin <GITHUB_REPO_URL>
git push -u origin main
```

## Roadmap (Ideas)

- Move the connection string to config
- Hash passwords (e.g., `BCrypt`) and add basic auth policies
- Add unit tests for repositories and business logic
- Improve form validation and error handling


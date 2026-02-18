# Kando

A simple Kanban-style task board built with ASP.NET Core MVC.

## How to run

1. Open a terminal in the project root (the folder containing `kando`).

2. Restore packages:
   ```bash
   dotnet restore
   ```

3. Run the app:
   ```bash
   dotnet run --project kando/kando.csproj
   ```

4. Open the URL shown in the terminal

The app uses SQLite. The database file is created automatically on first run and migrations are applied at startup.

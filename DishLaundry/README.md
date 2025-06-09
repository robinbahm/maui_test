# DishLaundry

DishLaundry is a sample dating application built with .NET MAUI. It demonstrates a Tinder-like workflow with login, profile editing, swiping through profiles, creating matches and exchanging simple chat messages. Everything runs in-memory for demonstration purposes.

## Project Structure
- `DishLaundry.sln` - Solution file
- `DishLaundry.csproj` - MAUI project targeting Android, iOS, macOS and Windows
- `App.xaml`, `App.xaml.cs` - Application startup
- `AppShell.xaml` - Shell navigation setup
- `Views/` - Pages for login, registration, swiping, matches, chat and profile editing
- `Models/` - Basic data models used by the app
- `Services/` - Simple service containing sample data and business logic

## Building
Install the .NET 7 SDK with the MAUI workload and run:

```bash
dotnet build DishLaundry.sln
```

This will produce builds for Android, iOS, Mac Catalyst and Windows. MAUI does not currently support building the same code for web browsers.

## Limitations
This project is for educational use only. There is no networking, backend or persistent storage, and the UI is intentionally simple.

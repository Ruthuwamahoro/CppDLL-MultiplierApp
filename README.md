# Calling C++ DLL from C# Console Application

This project demonstrates how to create and use a C++ DLL in a C# Console application.

## Project Structure

- **MathLibrary (C++ DLL)**

  - Contains a function that multiplies two integers
  - Built using CMake and Visual Studio toolchain

- **MathClient (C# Console Application)**
  - Prompts user for two numbers
  - Calls the C++ DLL's multiply function
  - Displays the result

## Prerequisites

- Visual Studio 2022 or later
- CMake 3.15 or later
- .NET 9.0 SDK

## Building the Project

1. Clone the repository
2. Run to build both the C++ DLL and C# application
3. The DLL will be automatically copied to the C# application's output directory

## Usage

1. Run the MathClient executable: 

`dotnet run --project MathClient`

2. Enter two integer numbers when prompted
3. The application will display the multiplication result calculated by the C++ DLL

## Error Handling

If you see the error "Could not find the MathLibrary DLL", ensure:

- The C++ project was built successfully
- The DLL was copied to the correct output directory
- You're running the application from the correct directory

## Project Files

- `MathLibrary/` - C++ DLL source code
- `MathClient/` - C# Console application
- `build.bat` - Main build script
- `copy_dll.bat` - Script to copy DLL to output directory


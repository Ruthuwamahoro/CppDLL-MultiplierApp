@echo off
echo Building C++ DLL...
cd MathLibrary
call build.bat
cd ..

echo Building C# Application...
cd MathClient
call copy_dll.bat
dotnet build -c Release
cd ..

echo Build complete!
echo You can run the application with: dotnet run --project MathClient
#!/bin/bash
echo "Building C++ DLL..."
cd MathLibrary
chmod +x build.sh
./build.sh
cd ..

echo "Building C# Application..."
cd MathClient
chmod +x copy_dll.sh
./copy_dll.sh
dotnet build -c Release
cd ..

echo "Build complete!"
echo "You can run the application with: dotnet run --project MathClient"
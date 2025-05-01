@echo off
echo Copying MathLibrary.dll to output directory...
mkdir -p bin\Debug\net9.0
mkdir -p bin\Release\net9.0
copy /Y "..\MathLibrary\build\bin\Release\MathLibrary.dll" "bin\Debug\net9.0\"
copy /Y "..\MathLibrary\build\bin\Release\MathLibrary.dll" "bin\Release\net9.0\"
if %errorlevel% neq 0 echo Error: Failed to copy DLL
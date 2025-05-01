#!/bin/bash
echo "Copying libMathLibrary.so to output directory..."
mkdir -p bin/Debug/net6.0
mkdir -p bin/Release/net6.0
cp ../MathLibrary/build/lib/libMathLibrary.so bin/Debug/net6.0/
cp ../MathLibrary/build/lib/libMathLibrary.so bin/Release/net6.0/
if [ $? -ne 0 ]; then
  echo "Error: Failed to copy shared library"
fi
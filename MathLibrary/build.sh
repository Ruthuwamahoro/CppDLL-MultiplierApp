#!/bin/bash
mkdir -p build
cd build
cmake ..
cmake --build .
cd ..
echo "Done building libMathLibrary.so"
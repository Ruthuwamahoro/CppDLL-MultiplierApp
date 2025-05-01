cmake_minimum_required(VERSION 3.10)
project(MathLibrary)

# Specify C++ standard
set(CMAKE_CXX_STANDARD 14)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

# Create a shared library
add_library(MathLibrary SHARED
    MathLibrary.cpp
    MathLibrary.h
)

# Set output directory
set_target_properties(MathLibrary PROPERTIES
    LIBRARY_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}/lib"
    RUNTIME_OUTPUT_DIRECTORY "${CMAKE_BINARY_DIR}/bin"
)
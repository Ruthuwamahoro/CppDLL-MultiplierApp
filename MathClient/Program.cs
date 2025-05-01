using System;
using System.Runtime.InteropServices;
using System.IO;

namespace MathClient
{
    class Program
    {
        // Import the DLL function
        // For Windows
        [DllImport("MathLibrary.dll", CallingConvention = CallingConvention.Cdecl)]
        private static extern int Multiply(int a, int b);

        // For Linux/macOS (uncomment if needed)
        // [DllImport("libMathLibrary.so", CallingConvention = CallingConvention.Cdecl)]
        // private static extern int Multiply(int a, int b);
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("C# Console Application calling C++ DLL");
                Console.WriteLine("--------------------------------------");
                
                // Ask the user for two numbers
                Console.Write("Enter the first number: ");
                if (!int.TryParse(Console.ReadLine(), out int number1))
                {
                    Console.WriteLine("Invalid input. Using default value 5.");
                    number1 = 5;
                }
                
                Console.Write("Enter the second number: ");
                if (!int.TryParse(Console.ReadLine(), out int number2))
                {
                    Console.WriteLine("Invalid input. Using default value 7.");
                    number2 = 7;
                }
                
                // Call the DLL function
                Console.WriteLine($"Calling C++ DLL to multiply {number1} and {number2}...");
                int result = Multiply(number1, number2);
                
                // Display the result
                Console.WriteLine($"Result from C++ DLL: {number1} * {number2} = {result}");
            }
            catch (DllNotFoundException)
            {
                Console.WriteLine("Error: Could not find the MathLibrary DLL.");
                Console.WriteLine("Make sure the DLL is in the same directory as this executable.");
            }
            catch (EntryPointNotFoundException)
            {
                Console.WriteLine("Error: Could not find the Multiply function in the DLL.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
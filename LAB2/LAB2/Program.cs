// Displaying the sum of two numbers input from the keyboard.
using System;


namespace LAB2

{ public class Multiplication
    {
        // Main method begins execution of C# application
        public static void Main(string[] args)
        {
            int number1; // declare number1 to multiply 
            int number2; // declare number2 to multiply 
            int sum; // declare sum of number1 and number2

            Console.Write("10: "); // propmt user
                                   // read first number from user
            number1 = Convert.ToInt32(10); { Console.ReadLine(); }; 

            Console.Write("5: "); // prompt user
                                  // read second number from user
            number2 = Convert.ToInt32(5); { Console.ReadLine(); };

            sum = 10 * 5; // multiply numbers 

            Console.WriteLine("Sum is {50}", sum); // display sum 
        }
    }
} 

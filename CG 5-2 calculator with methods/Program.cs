using System;

namespace CG_5_2_calculator_with_methods
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Remember our simple calculator program from Class 3? Update the application so each of 
             * the math calculations (add, subtract, multiple, divide) is each in its own method.  
             * The methods should return the value and the main method should print the value.  Make 
             * sure your methods have XML comments for IntelliSense. 
            Upload your program to a new repository called CG 5-2. */

            Console.WriteLine("Calculator");
            Console.WriteLine(); //blank line between name of app and first variable entry to make it easy to read

            /*ask for first number, convert variable type from string to decimal (using this instead of int to 
             * allow for decimal places in variable entries and answer. i skipped separate line of code to declare variable 
             * as a string and just converted user entry to decimal all on one line of code*/

            
            Console.Write("Enter first number: ");
            decimal firstNumber = decimal.Parse(Console.ReadLine());

            //do the same for second number entry as first to convert from string to decimal
            Console.Write("Enter second number: ");
            decimal secondNumber = decimal.Parse(Console.ReadLine());

            Console.Write("Would you like to add, subtract, multiply, or divide these two numbers? Please choose one: ");
            string mathFunction = Console.ReadLine();



        }








    }
}

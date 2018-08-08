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

            /*ask for first number, convert variable type from string to int 
             * (using int in this app, should work for other number types as well.
             * i skipped separate line of code to declare variable 
             * as a string and just converted user entry to int all on one line of code*/


            Console.Write("Enter first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            //do the same for second number entry as first to convert from string to decimal
            Console.Write("Enter second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.Write("Would you like to add, subtract, multiply, or divide these two numbers? Please choose one: ");
            string mathFunction = Console.ReadLine();

            if (mathFunction == "add")
                Console.WriteLine($"Answer: {AddAnswer(firstNumber, secondNumber)}");

            else if (mathFunction == "subtract")
                Console.WriteLine($"Answer: {SubtractAnswer(firstNumber, secondNumber)}");

            else if (mathFunction == "multiply")
                Console.WriteLine($"Answer: {MultiplyAnswer(firstNumber, secondNumber)}");


            Console.ReadLine();

        }

        private static int AddAnswer(int firstNumber, int secondNumber)
          {
            int additionMath = firstNumber + secondNumber;
            return additionMath;
          }

            
        private static int SubtractAnswer(int firstNumber, int secondNumber)
        {
            int subtractionMath = firstNumber - secondNumber;
            return subtractionMath;
        }

        private static int MultiplyAnswer(int firstNumber, int secondNumber)
        {
            int multiplyMath = firstNumber * secondNumber;
            return multiplyMath;
        }

        private static int DivideAnswer(int firstNumber, int secondNumber)
        {
            if (secondNumber > 0)
            {
                int divideMath = firstNumber / secondNumber
                return divideMath;
            }

            
        }

    }
}

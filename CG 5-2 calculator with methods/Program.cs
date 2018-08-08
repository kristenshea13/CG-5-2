using System;

namespace CG_5_2_calculator_with_methods
{
    class Program
    {
        static void Main(string[] args)
        {
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

            //ask user what they would like to do with both numbers, name and declare as a string variable
            Console.Write("Would you like to add, subtract, multiply, or divide these two numbers? Please choose one: ");
            string mathFunction = Console.ReadLine();

            //create exception for a divisor of 0 to print error message and exit program

            if (secondNumber == 0 && mathFunction == "divide")
            {
                Console.WriteLine("Error");
                Console.ReadLine();
                return;
            }

            //create statements to print answer from correct method to console based on user input for mathFunction
            else if (mathFunction == "add")
                Console.WriteLine("Answer: {0}",
                    AddAnswer(firstNumber, secondNumber));

            else if (mathFunction == "subtract")
                Console.WriteLine("Answer: {0}",
                    SubtractAnswer(firstNumber, secondNumber));

            else if (mathFunction == "multiply")
                Console.WriteLine("Answer: {0}",
                    MultiplyAnswer(firstNumber, secondNumber));

            else if (mathFunction == "divide")
                Console.WriteLine("Answer: {0}",
                    DivideAnswer(firstNumber, secondNumber));

            //else statement as a catch all error if user enters something other than add, subtract, multiply, or divide

            else
                Console.WriteLine("Invalid function");

            Console.ReadLine();

        }

        /// <summary>
        /// add two user input numbers together
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>the answer to two user input numbers added together</returns>
        private static int AddAnswer(int firstNumber, int secondNumber)
          {///
            int additionMath = firstNumber + secondNumber;
            return additionMath;
          }

            
        /// <summary>
        /// subtract second user input number from first
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>the answer to first number minus second number</returns>
        private static int SubtractAnswer(int firstNumber, int secondNumber)
        {///
            int subtractionMath = firstNumber - secondNumber;
            return subtractionMath;
        }

        /// <summary>
        /// multiply the two user input numbers together
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>answer to first number multiplied by second number</returns>
        private static int MultiplyAnswer(int firstNumber, int secondNumber)
        {///
            int multiplyMath = firstNumber * secondNumber;
            return multiplyMath;
        }

        /// <summary>
        /// divide first user input number by second
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>answer to first number divided by second number</returns>
        private static int DivideAnswer(int firstNumber, int secondNumber)
        {///
            int divideMath = firstNumber / secondNumber;
            return divideMath;
                 
        }

    }
}

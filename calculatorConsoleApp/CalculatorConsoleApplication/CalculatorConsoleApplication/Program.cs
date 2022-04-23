using System;

namespace Calculator.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartCalculator();
        }

        public static void StartCalculator()
        {
            Console.Clear();

            //Variables
            string wallFrame = "|                                     |";
            dynamic firstNumber;
            dynamic secondNumber;
            string operation;
            dynamic result = 0;
            string useAgain;

            // 1. Show app title
            Console.WriteLine("| - - -  CALCULATOR CONSOLE APP - - - |");
            Console.WriteLine();

            // 2. Ask for first number
            Console.WriteLine("| - - - -  Give first number - - - -  |");
            Console.Write($" First Number:  ");


            // 3. Take first number
            firstNumber = Console.ReadLine();
            Console.WriteLine();


            // 4. Ask for operation
            Console.WriteLine("| - -   Operation: + | - | * | / - -  |");
            Console.Write($" Operation:  ");


            // 5. Select operation
            operation = Console.ReadLine();
            Console.WriteLine();


            // 6. Ask for second number
            Console.WriteLine("| - - - -  Give second number - - - - |");
            Console.Write(" Second Number:  ");


            // 7. Take second number
            secondNumber = Console.ReadLine();
            Console.WriteLine();


            // 8. Make calculations and show result
            result = MakeCalculation(firstNumber, operation, secondNumber);

            // 9. Show result
            Console.WriteLine("| - - - - - -  Show result - - - - - -|");
            Console.WriteLine($" Calculation: {firstNumber} {operation} {secondNumber}");
            Console.WriteLine($" Result: {result}");
            Console.WriteLine();


            // 10. Try again ?
            Console.WriteLine("| - - - -  Use again? : y / n  - - - -|");
            Console.Write(" Your decision:  ");

            //11. Your decision to use again
            useAgain = Console.ReadLine();
            UseCalculatorAgain(useAgain);
            Console.WriteLine();
            Console.WriteLine("| _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ |");


        }

        public static void UseCalculatorAgain(string useAgain)
        {
            if(useAgain == "y")
            {
                StartCalculator();

            }else if(useAgain == "n")
            {
                Environment.Exit(0);
            }

            
        }

      

        public static dynamic MakeCalculation(string firstInput, string operation, string secondInput)
        {
            int result = 0;
            string message = "I got a problem";

            int firstNumber;
            int secondNumber;

            if ((int.TryParse(firstInput, out firstNumber)) != true)
            {
                message = "Problem! Bad first number!";
                return message;
            }

            if ((int.TryParse(secondInput, out secondNumber)) != true)
            {
                message = "Problem! Bad second number!";
                return message;
            }



            if (operation == "+")
            {
                result = firstNumber + secondNumber;
            }else if(operation == "-")
            {
                result = firstNumber - secondNumber;
            }
            else if(operation == "/")
            {
                result = firstNumber / secondNumber;
            }
            else if(operation == "*")
            {
                result = firstNumber * secondNumber;
            }
            else
            {
                message = "Problem! Bad operation!";
                return message;
            }

            return result;



        }
    }
}

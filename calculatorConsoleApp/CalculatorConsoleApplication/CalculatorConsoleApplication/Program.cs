using System;

namespace Calculator.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string wallFrame = "|                                     |";
            int firstNumber = 1;
            int secondNumber;
            string operation;
            int result;

            // 1. Show app title
            Console.WriteLine("| - - -  CALCULATOR CONSOLE APP - - - |");
            Console.WriteLine();

            // 2. Ask for first number
            Console.WriteLine("| - - - -  Give first number - - - -  |");
            Console.Write($" First Number:  ");


            // 3. Take first number
            firstNumber = Int32.Parse(Console.ReadLine());
            checkNumber(firstNumber);
            Console.WriteLine();


            // 4. Ask for operation
            Console.WriteLine("| - -   Operation: + | - | * | / - -  |");
            Console.Write($" Operation:  ");


            // 5. Select operation
            operation = Console.ReadLine();
            checkOperation(operation);
            Console.WriteLine();


            // 6. Ask for second number
            Console.WriteLine("| - - - -  Give second number - - - - |");
            Console.Write(" Second Number:  ");


            // 7. Take second number
            secondNumber = Int32.Parse(Console.ReadLine());
            checkNumber(secondNumber);
            Console.WriteLine();


            // 8. Make calculations
            result = makeCalculation(firstNumber, operation, secondNumber);

            // 9. Show result
            Console.WriteLine("| - - - - - -  Show result - - - - - -|");
            Console.WriteLine($" Calculation: {firstNumber} {operation} {secondNumber}");
            Console.WriteLine($" Result: {result}");
            Console.WriteLine();

            // 10. Try again ?



            Console.WriteLine("| _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ |");

        }

        public static void startCalculator()
        {

        }

        public static void checkNumber(int number)
        {
            if (number.GetType() != typeof(int))
            {
                Console.WriteLine("Bad input! You should restart the calculator.");
                startCalculator();
            }

           
        }

        public static void checkOperation(string operation)
        {

            if (operation != "add" && operation != "sub" && operation != "div" && operation != "mul" )
            {
                Console.WriteLine("Bad operation! You should restart the calculator.");
                startCalculator();
            } 
          
        }


        public static int makeCalculation(int firstNumber, string operation, int secondNumber)
        {
            int result = 0;

           if(operation == "add")
            {
                result = firstNumber + secondNumber;
            }else if(operation == "sub")
            {
                result = firstNumber - secondNumber;
            }
            else if(operation == "div")
            {
                result = firstNumber / secondNumber;
            }
            else if(operation == "mul")
            {
                result = firstNumber * secondNumber;
            }


            return result;
        }
    }
}

using System;

namespace Calculator.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Variables
            string wallFrame = "|                                     |";
            int firstNumber;
            int secondNumber;
            string operation;

            // 1. Show app title
            Console.WriteLine("| - - -  CALCULATOR CONSOLE APP - - - |");
            Console.WriteLine();

            // 2. Ask for first number
            Console.WriteLine("| - - - -  Give first number - - - -  |");
            Console.Write($" First Number:  ");


            // 3. Take first number
            firstNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine();


            // 4. Ask for operation
            Console.WriteLine("| Chose operation: add|sub|mul|div   |");
            Console.Write($" Operation:  ");


            // 5. Select operation
            operation = Console.ReadLine();
            Console.WriteLine();


            // 6. Ask for second number
            Console.WriteLine("| - - - -  Give second number - - - - |");
            Console.Write(" Second Number:  ");
            secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            // 7. Take second number
            secondNumber = Int32.Parse(Console.ReadLine());
            Console.WriteLine();



            // 8. Make calculations

            // 9. Show result



            Console.WriteLine("| _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ |");

        }
    }
}

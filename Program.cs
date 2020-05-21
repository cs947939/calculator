using Microsoft.VisualBasic;
using System;


namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double num1, double num2,double num3, double num4, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" which we use if an operation, such as division, could result in an error.
            
            // Use a switch statement to do the math.
            switch (op)
            {
                case "1":
                    Console.WriteLine("how many numbers?");
                    string answer = Console.ReadLine();

                    if (answer == "2")
                    {
                        result = num1 + num2;
                    }
                    else
                    {
                        if(answer == "3")
                        {
                            result = num1 + num2 + num3;
                        }
                        else
                        {
                            result = num1 + num2 + num3 + num4;
                        }
                    }
                    break;
                case "2":
                    Console.WriteLine("how many numbers?");
                    string answer1 = Console.ReadLine();

                    if (answer1 == "2")
                    {
                        result = num1 - num2;
 }
                    else
                    {
                        if (answer1 == "3")
                        {
                            result = num1 - num2 - num3;
                        }
                        else
                        {
                            result = num1 - num2 - num3 - num4;
                        }
                    }
                    break;
                case "3":
                    Console.WriteLine("how many numbers?");
                    string answer5 = Console.ReadLine();

                    if (answer5 == "2")
                    {
                        result = num1 * num2;
                    }
                    else
                    {
                        if (answer5 == "3")
                        {
                            result = num1 * num2 * num3;
                        }
                        else
                        {
                            result = num1 * num2 * num3 * num4;
                        }
                    }
                    break;
                case "4":
                    // Ask the user to enter a non-zero divisor.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }
    class Program
    {
        

        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\t1 - Add is `1");
                Console.WriteLine("\t2 - Subtract is 2");
                Console.WriteLine("\t3 - Multiply is 3");
                Console.WriteLine("\t4 - Divide is 4");
                Console.Write("Your option? ");
                
                var op = Console.ReadLine();
                


                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                string numInput3 = "";
                string numInput4 = "";
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }
                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput3 = Console.ReadLine();
                double cleanNum3 = 0;
                while (!double.TryParse(numInput3, out cleanNum3))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }
                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput4 = Console.ReadLine();
                double cleanNum4 = 0;
                while (!double.TryParse(numInput4, out cleanNum4))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput4 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

              


                try
                {
                    result = Calculator.DoOperation(cleanNum1, cleanNum2, cleanNum3, cleanNum4, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
    }
}
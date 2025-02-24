using System.Runtime.CompilerServices;

// Flowchart - https://excalidraw.com/#json=aX6X4XdF-4qhe5T2mJgoc,F-8ptHGyWhL2ZSWH7pRxeQ

namespace CS_Basic_Oppgave_3_Basic_Calculator
{
    class Program
    {
        static void ClearLine()
        {
            // Remove the command that got written.
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }

        static void Main(string[] args)
        {
            bool programRun = true;
            Calculator calculator = new();
            string[] validOperators = ["+", "-", "*", "/"];

            while (programRun)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("------------ CALCULATOR -------------");
                Console.WriteLine("Please enter your numbers and symbol");

                string? input = Console.ReadLine();
                string[] spaceSeparatedValues;

                // Validate input
                while (true)
                {
                    // Check if input is not null or empty
                    if (string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("Input cannot be empty...");
                        input = Console.ReadLine();
                        continue;
                    }

                    // Split the input into parts
                    spaceSeparatedValues = input.Split(" ").Select(p => p.Trim()).ToArray();

                    if (spaceSeparatedValues.Length != 3)
                    {
                        Console.WriteLine("Error: Please enter exactly two numbers and one operator.");
                        input = Console.ReadLine();
                        continue;
                    }

                    // Check if first value is a valid number
                    if (!double.TryParse(spaceSeparatedValues[0], out double firstNumber))
                    {
                        Console.WriteLine("Error: The first input is not a valid number. Please try again...");
                        input = Console.ReadLine();
                        continue;
                    }

                    // Check if the operator is valid
                    string operatorInput = spaceSeparatedValues[1];
                    if (!validOperators.Contains(operatorInput))
                    {
                        Console.WriteLine("Error: The operator is not a valid operator. Please try again...");
                        input = Console.ReadLine();
                        continue;
                    }

                    // Check if second value is a valid number
                    if (!double.TryParse(spaceSeparatedValues[2], out double secondNumber))
                    {
                        Console.WriteLine("Error: The second value is not a valid number. Please try again...");
                        input = Console.ReadLine();
                        continue;
                    }

                    // If all checks pass, break out of the loop
                    break;
                }

                // Now perform the operation based on the validated input
                double firstNum = double.Parse(spaceSeparatedValues[0]);
                double secondNum = double.Parse(spaceSeparatedValues[2]);
                string operatorSymbol = spaceSeparatedValues[1];

                switch (operatorSymbol)
                {
                    case "+":
                        Console.WriteLine($"Addition: {firstNum} + {secondNum} = {calculator.Addition(firstNum, secondNum)}");
                        break;
                    case "-":
                        Console.WriteLine($"Subtraction: {firstNum} - {secondNum} = {calculator.Subtraction(firstNum, secondNum)}");
                        break;
                    case "*":
                        Console.WriteLine($"Multiplication: {firstNum} * {secondNum} = {calculator.Multiplication(firstNum, secondNum)}");
                        break;
                    case "/":
                        Console.WriteLine($"Division: {firstNum} / {secondNum} = {calculator.Division(firstNum, secondNum)}");
                        break;
                    default:
                        Console.WriteLine("Error: Invalid symbol used. Please try again...");
                        break;
                }

                // Ask the user if they want to continue
                Console.WriteLine("Would you like to keep using the calculator?");
                Console.WriteLine("Yes | No?");
                string? continueInput = Console.ReadLine();

                while (string.IsNullOrEmpty(continueInput) ||
                      !(continueInput.ToLower() == "yes" || continueInput.ToLower() == "no"))
                {
                    Console.WriteLine("Error: Invalid input, yes | no");
                    continueInput = Console.ReadLine();
                }

                if (continueInput.ToLower() == "no")
                {
                    programRun = false;
                    Console.Clear();
                    Console.WriteLine("See you next time.");
                }
                else if (continueInput.ToLower() == "yes")
                {
                    continue;
                }

            }
        }



    }
}

public class Calculator
{
    public double Addition(double num1, double num2)
    {
        return num1 + num2;
    }

    public int Addition(int num1, int num2)
    {
        return num1 + num2;
    }

    public double Subtraction(double num1, double num2)
    {
        return num1 - num2;
    }
    public int Subtraction(int num1, int num2)
    {
        return num1 - num2;
    }

    public double Multiplication(double num1, double num2)
    {
        return num1 * num2;
    }
    public int Multiplication(int num1, int num2)
    {
        return num1 * num2;
    }

    public double Division(double num1, double num2)
    {
        return num1 / num2;
    }
    public int Division(int num1, int num2)
    {
        return num1 / num2;
    }
};

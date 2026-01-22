using System.Reflection.Metadata;

namespace CalculatorLite;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("=== Calculator Lite ===\n");

        // TODO: Declare variables for storing user input (use descriptive names)
        // Hint: You'll need variables for two numbers, user name, and calculation choice
        string username = "Unidentified";
        bool UseDecimals = false;
        num1 = 0;
        num2 = 0;

        // TODO: Ask for user's name (string) and greet them
        // Example: "Enter your name: " then "Hello, [name]!"
        System.Console.Write("Enter your name: ");
        username = System.Console.ReadLine();
        System.Console.WriteLine("Hello, {0}!", username);

        // TODO: Ask if they want to use decimals (bool)
        // Example: "Use decimal precision? (yes/no): "
        // Store as boolean (true for yes, false for no)
        System.Console.Write("Would you like to use decimals? (yes/no): ");
        if (System.Console.ReadLine() == "yes")
        {
            UseDecimals = true;
        }
        else
        {
            UseDecimals = false;
        }

        // TODO: Prompt user for first number (double or int based on choice)
        // If decimals: use double.Parse()
        // If no decimals: use int.Parse() then cast to double
        if (UseDecimals == true)
        {
            System.Console.Write("Enter your first number: ");
            num1 = double.Parse(System.Console.ReadLine());
        }
        else
        {
            System.Console.Write("Enter your first number: ");
            num1 = int.Parse(System.Console.ReadLine());
        }

        // TODO: Prompt user for second number (same type as first)
        if (UseDecimals == true)
        {
            System.Console.Write("Enter your second number: ");
            num2 = double.Parse(System.Console.ReadLine());
        }
        else
        {
            System.Console.Write("Enter your second number: ");
            num2 = int.Parse(System.Console.ReadLine());
        }

        // TODO: Calculate ALL arithmetic operations:
        // - sum (addition: +)
        double sum = num1 + num2;
        // - difference (subtraction: -)
        double diff = num1 - num2;
        // - product (multiplication: *)
        double prod = num1 * num2;
        // - quotient (division: /)
        double quot = num1 / num2;
        // - remainder (modulus: %)
        double rem = num1 % num2;
        // - average ((num1 + num2) / 2)
        double ave = (num1 + num2) / 2;

        // TODO: Display results with proper formatting
        // Show 2 decimal places: {value:F2}
        // Include descriptive labels for each operation
        if (UseDecimals == true) ;
        {
            Console.WriteLine("\nCalculation Results:");
            System.Console.WriteLine(" {0} + {1} = {2:F2}", num1, num2, sum.ToString());
            System.Console.WriteLine(" {0} - {1} = {2:F2}", num1, num2, diff.ToString());
            System.Console.WriteLine(" {0} * {1} = {2:F2}", num1, num2, prod.ToString());
            System.Console.WriteLine(" {0} / {1} = {2:F2}", num1, num2, quot.ToString());
            System.Console.WriteLine(" {0} % {1} = {2:F2}", num1, num2, rem.ToString());
            System.Console.WriteLine(" Average of {0} and {1} = {2:F2}", num1, num2, ave.ToString());
        }
        else;
        {
            Console.WriteLine("\nCalculation Results:");
            System.Console.WriteLine(" {0} + {1} = {2}", num1, num2, sum.ToString());
            System.Console.WriteLine(" {0} - {1} = {2}", num1, num2, diff.ToString());
            System.Console.WriteLine(" {0} * {1} = {2}", num1, num2, prod.ToString());
            System.Console.WriteLine(" {0} / {1} = {2}", num1, num2, quot.ToString());
            System.Console.WriteLine(" {0} % {1} = {2}", num1, num2, rem.ToString());
            System.Console.WriteLine(" Average of {0} and {1} = {2}", num1, num2, ave.ToString());
        }
        // TODO: Check if second number is zero BEFORE dividing
        // Use if statement: if (num2 == 0) { show error } else { calculate }
        if (num2 == 0)
        {
            System.Console.WriteLine(" ERROR: Cause Division by zero.");
        }
        else
        {
            System.Console.WriteLine(" {0} / {1} = {2:F2}", num1, num2, quotient.ToString());
        }

        // TODO: Count total calculations performed (int)
        // Display: "Performed [count] calculations for [name]!"
        int calcCount = 6;
        System.Console.WriteLine("\nPerformed a total of {0} calculations for {1}!", calcCount, username);

        // TODO: Calculate percentage difference
        // Formula: ((num1 - num2) / num1) * 100
        // Display with % symbol
        double percentDiff = ((num1 - num2) / num1) * 100;
        System.Console.WriteLine(" Percentage difference between {0} and {1} = {2:F2}%", num1, num2, percentDiff);

        Console.WriteLine("\nThank you for using Calculator Lite!");
    }
}

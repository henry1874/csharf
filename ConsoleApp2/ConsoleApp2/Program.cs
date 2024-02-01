using System;

class Program
{
    static void Main()
    {

        double num1, num2, total;


        Console.Write("Enter the first number: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        num2 = Convert.ToDouble(Console.ReadLine());


        total = num1 + num2;
        Console.WriteLine($"Sum: {total}");

        total = num1 - num2;
        Console.WriteLine($"Subtract: {total}");

        total = num1 * num2;
        Console.WriteLine($"Multiplication: {total}");


        if (num2 != 0)
        {
            double division = num1 / num2;
            Console.WriteLine($"Division: {division}");
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }


        Console.ReadLine();
    }
}
using System;
namespace ConsoleApp1;

public class LoopLessons
{
    static void Main(string[] args)
    {
        // boolean variable
        bool allPositive = true;

        // arrays
        double[] numbers = new double[5];
        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(Console.ReadLine());
            if (numbers[i] < 0)
            {
                allPositive = false;
            }
        }
        if (allPositive)
        {
            Console.WriteLine("All numbers are positive.");
        }
        else
        {
            Console.WriteLine("There is at least one negative number.");
        }
    }
}
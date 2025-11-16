using System;
namespace ConsoleApp1;
public class Task3
{
    static void Main(string[] args)
    {
        int[] numbers = { 3, 7, 12, 19, 21, 25, 30 };
        Console.WriteLine("Enter a number to search:");
        int target = int.Parse(Console.ReadLine());
        bool found = false;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                found = true;
                break;
            }
        }

        if (found)
        {
            Console.WriteLine("Number found at position " + Array.IndexOf(numbers, target) + " in the array.");
        }
        else
        {
            Console.WriteLine("Number not found in the array.");
        }
    }
}

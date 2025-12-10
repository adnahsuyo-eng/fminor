using System.Runtime.ConstrainedExecution;

namespace ConsoleApp2.task;

public class Task2
{
    private static void Main(string[] args)
    {
        // Row 0: even numbers
        // Row 1: odd numbers
        int[,] numberMatrix = new int[,]
        {
    { 2, 4, 6, 8, 10 },
    { 1, 3, 5, 7, 9 }
        };
        Console.WriteLine("The number matrix has been initialized");

        // Combine the matrix
        int passcode1 = numberMatrix[1,3];
        int passcode2 = numberMatrix[0,0];
        int passcode3 = numberMatrix[1,4];

        // Combine digits into a single string
        string combineDigits = $"{passcode1}{passcode2}{passcode3}";

                Console.WriteLine("Your password is: " + combineDigits);

                System.Console.WriteLine("final 3 digit key password is " + combineDigits);
            }

        }
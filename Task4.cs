namespace ConsoleApp2;
public class Task4
{
     static double Add(double a, double b) => a + b;
     static double Subtract(double a, double b) => a - b;
     static double Multiply(double a, double b) => a * b;
     static double Divide(double a, double b) => a / b;
     static void Main(string[] args)
    {
        while (true)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Arithmetic Calculator");
            Console.WriteLine("--------------------------------");

            Console.WriteLine("Select Arithmetic Operation:");
            System.Console.WriteLine("Press key to select operation:");
            System.Console.WriteLine("1: Add");
            System.Console.WriteLine("2: Subtract");
            System.Console.WriteLine("3: Multiply");
            System.Console.WriteLine("4: Divide");
            var operation = Console.ReadKey(true).KeyChar;

            Console.WriteLine("Enter first value: ");
            if (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Invalid number entered. Press any key to retry...");
                Console.ReadKey();
                continue;
            }

            Console.WriteLine("Enter second value: ");
            if (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Invalid number entered. Press any key to retry...");
                Console.ReadKey();
                continue;
            }

            switch (operation)
            {
                case '+':
                case '1':
                    result = Add(num1, num2);
                    operation = '+';
                    break;
                case '-':
                case '2':
                    result = Subtract(num1, num2);
                    operation = '-';
                    break;
                case '*':
                case '3':
                    result = Multiply(num1, num2);
                    operation = '*';
                    if (num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("Warning: Multiplying by zero results in zero.");
                    }
                    break;
                case '/':
                case '4':
                    result = Divide(num1, num2);
                    operation = '/';
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by zero.");
                        Console.WriteLine("Press any key to retry...");
                        Console.ReadKey();
                        continue;
                    }
                    result = Divide(num1, num2);
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    Console.WriteLine("Press any key to retry...");
                    Console.ReadKey();
                    continue;
            }

            Console.WriteLine($"{num1} {operation} {num2} = {result}");
            Console.WriteLine("Do you want to continue again? (y/n)");
            var continueChoice = Console.ReadKey(true).KeyChar;
            if (continueChoice == 'y' || continueChoice == 'Y')
            {
                continue;
            }
            else
            {
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
                return;
            }
        }
    }
}
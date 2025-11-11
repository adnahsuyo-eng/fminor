namespace ConsoleApp1;

public class SwitchLesson
{
    static void Main(string[] args)
    {
        int i = 8;
        switch (i % 2)
        {
            case 0:
                System.Console.WriteLine($"{i} is even", i);
                break;
            case 1:
                System.Console.WriteLine($"{i} is odd", i);
                break;
            default:
                break;
        }
        int hourOfTheDay = 18;
        switch (hourOfTheDay)
        {
            case 8:
                System.Console.WriteLine("Good morning");
                break;
            case 12:
                System.Console.WriteLine("Good Afternoon");
                break;
            case 18:
                System.Console.WriteLine("Good Evening");
                System.Console.WriteLine("Nice one");
                break;
            default:
                break;
    }
    }
}
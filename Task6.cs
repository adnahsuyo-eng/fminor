using System;
namespace ConsoleApp2;
public class Task6
{
     class Student
    {
        public string Name{ get; set; }
        public string Age{ get; set; }

        public string Grade{ get; set; }

        public Student(string name, string age, string grade)
        {
            Name = name;
            Age = age;
            Grade = grade;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Student's Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Grade: {Grade}");
        }

        public bool IsPassed()
        {
            return int.TryParse(Grade, out int gradeValue) && gradeValue >= 75;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter name of students:");
        string name = Console.ReadLine()??"";
        Console.WriteLine("Enter age of students:");
        int age = int.Parse(Console.ReadLine()??"0");

        Console.WriteLine("Enter grade of students:");
        int grade = int.Parse(Console.ReadLine()??"0");

        Student student = new Student(name, age.ToString(), grade.ToString());
        student.DisplayInfo();

        Console.WriteLine(student.IsPassed() ? "Status: Passed" : "Status: Failed");
    }

}

using System;

namespace VariablesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Blaine";
            int myAge = 35;
            char anotherOne = '+';
            double myGradeA = 96.5;
            double myGradeB = 84.2;
            decimal courseCostA = 1050;
            decimal courseCostB = 659;
            Console.WriteLine($"My name is {myName}. I am {myAge} years old. Currently I am learning Python {anotherOne} C#. For my first two assignments in the Python course, I scored a {myGradeA} A {anotherOne} {myGradeB} B. The Python course cost ${courseCostA} and the C# course cost ${courseCostB}.");
        }
    }
}


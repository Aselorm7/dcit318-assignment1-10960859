using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A console application of a Grade Calculator

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter your name here
            // Student: Selorm Azoto

            Console.Write("Enter a numerical grade (0-100): ");
            string input = Console.ReadLine();
            int grade;

            // Validate input
            while (!int.TryParse(input, out grade) || grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
                Console.Write("Enter a numerical grade (0-100): ");
                input = Console.ReadLine();
            }

            string letterGrade = GetLetterGrade(grade);
            Console.WriteLine($"The letter grade is: {letterGrade}");
        }

        static string GetLetterGrade(int grade)
        {
            if (grade >= 90)
            {
                return "A";
            }
            else if (grade >= 80)
            {
                return "B";
            }
            else if (grade >= 70)
            {
                return "C";
            }
            else if (grade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}



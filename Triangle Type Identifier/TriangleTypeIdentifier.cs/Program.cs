using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enter your name here
            // Student: Selorm Azoto

            Console.Write("Enter the length of side 1: ");
            double side1 = GetValidSideLength();

            Console.Write("Enter the length of side 2: ");
            double side2 = GetValidSideLength();

            Console.Write("Enter the length of side 3: ");
            double side3 = GetValidSideLength();

            string triangleType = DetermineTriangleType(side1, side2, side3);
            Console.WriteLine($"The triangle is {triangleType}.");
        }

        static double GetValidSideLength()
        {
            double side;
            string input = Console.ReadLine();

            while (!double.TryParse(input, out side) || side <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                Console.Write("Enter the length of the side: ");
                input = Console.ReadLine();
            }

            return side;
        }

        static string DetermineTriangleType(double side1, double side2, double side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}



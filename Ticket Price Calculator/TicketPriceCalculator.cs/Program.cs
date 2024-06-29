using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//A console application of a Ticket Price Calculator


namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Enter your name here
            // Student: [Your Name]

            Console.Write("Enter your age: ");
            string input = Console.ReadLine();
            int age;

            // Validate input
            while (!int.TryParse(input, out age) || age < 0)
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                Console.Write("Enter your age: ");
                input = Console.ReadLine();
            }

            decimal ticketPrice = CalculateTicketPrice(age);
            Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
        }

        static decimal CalculateTicketPrice(int age)
        {
            const decimal regularPrice = 10m;
            const decimal discountPrice = 7m;

            if (age <= 12 || age >= 65)
            {
                return discountPrice;
            }
            else
            {
                return regularPrice;
            }
        }
    }
}

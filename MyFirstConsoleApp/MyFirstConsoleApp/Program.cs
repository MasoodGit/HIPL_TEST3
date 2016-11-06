using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");

            int number = int.Parse(Console.ReadLine());

            string suffix = getOrdinal(number);

            Console.WriteLine("Thats the {0}-{1} item", number, suffix);

            Console.ReadLine();
        }

        public static int getRightMostDigit(int number)
        {
            return number % 10;
        }

        public static string getOrdinal(int number)
        {

            string suffix = "th";

            int rightMostDigit = getRightMostDigit(number);

            if (rightMostDigit == 1 || rightMostDigit == 2 || rightMostDigit == 3)
            {

                int cardinal = number % 100;
                if (cardinal == 11 || cardinal == 12 || cardinal == 13)
                {
                    return suffix;
                }
            }

            if (rightMostDigit == 1)
            {
                suffix = "st";
            }
            else if (rightMostDigit == 2)
            {
                suffix = "nd";
            }
            else if (rightMostDigit == 3)
            {
                suffix = "rd";
            }

            return suffix;
        }
    }
}

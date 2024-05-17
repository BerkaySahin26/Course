using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    public class Program
    {
        static void Main(string[] args)
        {
            var number = 11;
            // single örnek :Console.WriteLine(number == 10 ? "Number is 10" : "Number is not 10");

            if (number == 10)
            {
                Console.WriteLine("Number is 10");
            }
            else if (number == 20)
            {
                Console.WriteLine("Number is 20");

            }
            else
            {
                Console.WriteLine("Number is not 10 or 20");
            }

            switch (number)
            {
                case 10:
                    Console.WriteLine("Number is 10");
                    break;
                case 20:
                    Console.WriteLine("Number is 20");
                    break;
                default:
                    Console.WriteLine("Number is not 10 or 20");
                    break;
            }

            if (number >= 0 && number <= 100)
            {
                Console.WriteLine("Number is between 0-100");
            }
            else if (number > 100 && number <= 200)
            {
                Console.WriteLine("Number is between 101-200");
            }
            else if (number > 200 || number < 0)
            {
                Console.WriteLine("Number is less than 0 or greater than 200");
            }


            if (number < 100)
            {
                if (number > 80 && number < 90)
                {
                    Console.WriteLine("\nNumber is less than 90 or greater than 80.");
                }
                else if (number > 70 && number <= 80)
                {
                    Console.WriteLine("\nNumber is less(equal) than 80 or greater than 70.");
                }
                else
                {
                    Console.WriteLine("\nNumber is less(equal) than 70.");
                }
            }
            else
            {
                Console.WriteLine("\nNumber is greater than 100.");
            }

            Console.ReadLine();

        }
    }
}

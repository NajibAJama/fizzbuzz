using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzzMethodTwo();
            Console.ReadLine();
        }
        //One method to do FizzBuzz:
        private static void FizzBuzzMethodOne()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Second method to do FizzBuzz:
        private static void FizzBuzzMethodTwo()
        {
            for (int i = 1; i <= 100; i++)
            {
                string output = "";
                if (i % 3 == 0)
                {
                    output += "Fizz";
                }
                if (i % 5 == 0)
                {
                    output += "Buzz";
                }
                if (output.Length == 0)
                {
                    output = i.ToString();
                }
                Console.WriteLine(output);

            }
        }
    }
}

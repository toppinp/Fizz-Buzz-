using System;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to begin.");
            Console.ReadLine();

            for (int x = 1; x < 101; x++)
            {
                fizzBuzz(x);
            }

            // Parallel.For(1, 101, fizzBuzz); 
            // creates Tasks 1-100, using "fizzBuzz" method simutaneouslyly, not neccesariously in order.
            // Parallel.For MUST take only one interger variable parameter to work!
        }

        private static void fizzBuzz(int value)
        {
            string fb = "";

            if (value % 3 == 0)
            {
                fb += " Fizz";
            }

            if (value % 5 == 0)
            {
                fb += " Buzz";
            }

            Console.WriteLine(value + fb);
        }
    }
}

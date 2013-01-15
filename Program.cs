using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Projecteuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start!");
            Console.ReadKey(true);
            Console.WriteLine("Mathemating...");
            int final = 0;
            while  ( GetFactorCount( triangleNumber(final) ) < 500) // Iterate until it's fucking done.
            {
                final++;
            }
            Console.WriteLine("Final result is: {0}", triangleNumber(final));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static int triangleNumber(int input) // Input amount of iterations done.
        {
            int last = 0;
            for (int i = 0; i <= input; i++)
                last = last + i; // Eg: Last number was 3. Add 3 + 4, equalling 6. TRIANGLE NUMBERS.
            return last;
        }

        // Yeah, I stole this from Stack Overflow. I suck at factors :(. I'll work out something later.
        public static int GetFactorCount(int numberToCheck)
        {
            int factorCount = 0;
            int sqrt = (int)Math.Ceiling(Math.Sqrt(numberToCheck));

            // Start from 1 as we want our method to also work when numberToCheck is 0 or 1.
            for (int i = 1; i < sqrt; i++)
            {
                if (numberToCheck % i == 0)
                {
                    factorCount += 2; //  We found a pair of factors.
                }
            }

            // Check if our number is an exact square.
            if (sqrt * sqrt == numberToCheck)
            {
                factorCount++;
            }

            return factorCount;
        }
    }
}
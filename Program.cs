using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projecteuler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start!");
            Console.ReadKey();
            Console.WriteLine("Mathemating...");
            double sumsquare = 0; // The sum of every squared number from 1-100
            for (int i = 0; i <= 100; i++)
                sumsquare += Math.Pow(i, 2); // Continue to add the squared result.

            double squaresum = 0; // The sum of every number from 1-100, then squared
            for (int i = 0; i <= 100; i++)
                squaresum += i;
            squaresum = Math.Pow(squaresum, 2); // Square the result.

            double result = squaresum - sumsquare; // Calculate the difference

            Console.WriteLine("Result: {0}", result);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

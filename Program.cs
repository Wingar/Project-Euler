using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projecteuler
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            long last = 0;
            long result = 1;

            for (int i = 0; last <= 4000000; i++)
            {
                last = recFib(i);
                Console.WriteLine(last);
                if (last % 2 == 0) result += last;
            }
            Console.WriteLine("Result: {0}",result - 1);
            Console.ReadKey();
        }
        static long recFib(int n)
        {
            if (n < 2) return n;
            return recFib(n - 1) + recFib(n - 2);
        }
    }
}

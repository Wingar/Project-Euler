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
            long dicks = factors(600851475143);
            Console.WriteLine(dicks);
            Console.ReadKey();
        }
        static long factors(long n)
        {
            long z = 2;
            while (z * z <= n)
            {
                if (n % z == 0)
                {
                    Console.WriteLine( z);
                    n /= z;
                }

                else
                    z++;
            }
            return n;
        }
    }
}

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
            int sum = 1000;
            int a;
            for (a = 1; a <= sum / 3; a++)
            {
                int b;
                for (b = a + 1; b <= sum / 2; b++)
                {
                    int c = sum - a - b;
                    if (c > 0 && (a * a + b * b == c * c))
                        Console.WriteLine("{0} + {1} + {2} = 1000", a, b, c);
                }
            }

            //Console.WriteLine("{0} + {1} + {2} = 1000", a, b, c); // Print Result!
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

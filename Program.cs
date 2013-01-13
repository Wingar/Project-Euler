using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Projecteuler
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to start!");
            Console.ReadKey();
            Console.WriteLine("Mathemating...");
            long total = 0;
            for (long i = 1; i <= 2000000; i++)
            {
                    if (isPrime(i))
                       total += i;
            }
            Console.WriteLine("Result: {0}", total);
            Console.WriteLine("Length: {0}", total.ToString().Length);
            Clipboard.SetText(total.ToString());
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static bool isPrime(long n)
        {
            if (n == 1)
                return false;
            else if (n < 4)
                return true;
            else if (n % 2 == 0)
                return false;
            else if (n < 9)
                return true;
            else if (n % 3 == 0)
                return false;
            else
            {
                long r = (long)Math.Floor(Math.Sqrt(n));
                long f = 5;
                while (f <= r)
                {
                    if (n % f == 0)
                        return false;
                    if (n % (f + 2) == 0)
                        return false;
                    
                    f = f + 6;
                }
                return true;
            }
        }
    }
}

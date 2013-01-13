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
            int large = 0;
            for (int i = 0; i <= 999; i++) //Iterate i 999 times.
            {
                for (int l = 0; l <= 999; l++) // Iterate l 999 times.
                    if (isPalindrome((l * i).ToString()) == true) // If the multiplication of l by i is a palindrome...
                        if ((l * i) > large) // If the palindrome is larger than the previously large palindrome, replace it.
                            large = (i * l);
            }
            Console.WriteLine("Result: {0}", large); // Print Result!
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        static bool isPalindrome(string n)
        {
            int half = n.Length / 2; // Get half of the length of the string
            string half1 = n.Substring(0, half); // Get the first half of the string
            string half2 = Reverse(n.Substring(half, half)); // Get the second half of the string and reverse it
            if (half1 == half2) // If the two strings match, return as true.
                return true;
            else
                return false;
        }
        public static string Reverse(string s)
        {
            // Reverse the given string. Pretty fucking simple you dolt, why are you reading this.
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}

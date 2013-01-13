using System;
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
            int largestResult = 0;
            int largest = 0;
            string number = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            for (int i = 1; i <= (number.Length - 5); i++)
            {
                string sub = number.Substring(i, 5); // Get 5 digits from the string based on where counter is.
                int subInt;
                int.TryParse(sub, out subInt); // Convert string to int
                int[] resultArray = ConvertToArrayOfDigits(subInt); // Convert the number to an int array
                int sum = resultArray[0]; // Set the current sum to the first digit
                foreach (int currentDigit in resultArray.Skip(1)) // Foreach but skip the first digit, as it's already in the sum.
                    sum *= currentDigit; // Multiply every digit together...
                if (sum > largestResult) // If this result is larger than the current largest, replace it.
                {
                    largestResult = sum;
                    largest = subInt;
                }
            }
            
            Console.WriteLine("Largest multiplied number: {0}\nLargest consecutive number: {1}", largestResult, largest );
            Clipboard.SetText("Largest multiplied number: " + largestResult + ". Largest consecutive number: " + largest);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static int[] ConvertToArrayOfDigits(int value)
        {
            // Return amount of digits in the int. Could be sped up with a binary search.
            int size = value < 10 ? 1
                : value < 100 ? 2
                : value < 1000 ? 3
                : value < 10000 ? 4
                : value < 100000 ? 5
                : value < 1000000 ? 6
                : value < 10000000 ? 7
                : value < 100000000 ? 8
                : value < 1000000000 ? 9
                : 10;


            int[] digits = new int[size];

            //I don't know why this is here or what it really does but don't move it.
            for (int index = size - 1; index >= 0; index--)
            {
                digits[index] = value % 10;
                value = value / 10;
            }
            return digits;
        }
    }
}

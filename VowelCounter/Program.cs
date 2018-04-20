using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace VowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            int i;

            while (true)
            {
                Console.Clear();
                i = 0;
                Console.Write("Enter a string: ");

                foreach (char c in Regex.Replace(Console.ReadLine().ToLower(), @"\s+", " "))
                {
                    if (vowels.Contains(c))
                        i++;
                }

                Console.WriteLine("\nYour string contains " + i + " vowels!\n" +
                    "\nWould you like to try again? Type Y or N: ");
                if (Regex.Replace(Console.ReadLine().ToLower(), @"\s+", " ") == "n")
                    break;
            }
        }
    }
}

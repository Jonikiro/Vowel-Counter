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
            int a, e, i, o, u, total;

            while (true)
            {
                Console.Clear();
                a = 0;
                e = 0;
                i = 0;
                o = 0;
                u = 0;
                total = 0;

                Console.Write("Enter a string: ");

                foreach (char c in Regex.Replace(Console.ReadLine().ToLower(), @"\s+", " "))
                {
                    switch (c)
                    {
                        case 'a':
                            a++;
                            total++;
                            break;
                        case 'e':
                            e++;
                            total++;
                            break;
                        case 'i':
                            i++;
                            total++;
                            break;
                        case 'o':
                            o++;
                            total++;
                            break;
                        case 'u':
                            u++;
                            total++;
                            break;
                        default:
                            break;
                    }
                }

                Console.WriteLine("\nYour string contains " + total + " vowels!\n" +
                    "It also contains:\n" +
                    "   " + a + " instance(s) of 'a'.\n" +
                    "   " + e + " instance(s) of 'e'.\n" +
                    "   " + i + " instance(s) of 'i'.\n" +
                    "   " + o + " instance(s) of 'o'.\n" +
                    "   " + u + " instance(s) of 'u'.\n" +
                    "\nWould you like to try again? Type Y or N: ");
                if (Regex.Replace(Console.ReadLine().ToLower(), @"\s+", " ") == "n")
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadNumbers
{
    class Program
    {
        private static int ReadNumbers(int start, int end)
        {
            int number = 0;
            try
            {
                number = int.Parse(Console.ReadLine());

                if (number < start || number > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
                
            }

            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is not in the range [{0}..{1}]!", start, end);
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect format, input must be an integer.");
            }

            catch (OverflowException)
            {
                Console.WriteLine("The number is outside the range of the integer!");
            }
            
            return number;
        }

        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter 10 numbers that follow the rule 1 < a1 < a2 < ... < 100");
            int current = 0;
            int start = 0;
            int range = 0;
            while (range < 10)
            {
                    current = ReadNumbers(start, 100);
                    start = current + 1;
                    range++;
                
            }
        }
    }
}


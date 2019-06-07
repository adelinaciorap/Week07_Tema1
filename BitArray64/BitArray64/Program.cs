using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitArray64
{
    class Program
    {
        static void Main(string[] args)
        {
            BitArray number = new BitArray(34);
            foreach (var bit in number)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            BitArray number2 = new BitArray(23);
            foreach (var bit in number2)
            {
                Console.Write(bit);
            }
            Console.WriteLine();

            Console.WriteLine(number.Equals(number2));
            Console.WriteLine(number!=number2);
            Console.WriteLine(number[2]);

            Console.WriteLine(number.GetHashCode());
           

        }
    }
}

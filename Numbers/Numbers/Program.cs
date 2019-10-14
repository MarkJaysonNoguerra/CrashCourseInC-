using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // NUMBERS

            Console.WriteLine(2 * 3); // Basic Arithemetic: +, -, /, *
            Console.WriteLine(10 % 3); // Modulus Op. : returns remainder
            Console.WriteLine(1 + 2 * 3); // order of operations
            Console.WriteLine(10 / 3.0); // int's and doubles

            int num = 10;
            num += 100; // +=, -=, /=, *=
            Console.WriteLine(num);

            num++;
            Console.WriteLine(num);

            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Sqrt(144));
            Console.WriteLine(Math.Round(2.7));
            Console.ReadLine();
        }
    }
}

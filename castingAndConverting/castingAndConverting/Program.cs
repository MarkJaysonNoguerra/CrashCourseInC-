using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace castingAndConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            // CASTING & CONVERTING

            Console.WriteLine((int)3.14);
            Console.WriteLine((double)3);

            int intFromString = Convert.ToInt32("50");
            double doubleFromString = Convert.ToDouble("50.99");

            Console.WriteLine(100 + intFromString);
            Console.WriteLine(100 + doubleFromString);
            Console.ReadLine();
        }
    }
}

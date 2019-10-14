using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //  ARRAYS

            // int [] LuckyNumbers = new int[10];

            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            //      indexes      : 0  1  2    3   4  5

            luckyNumbers[0] = 90;
            Console.WriteLine(luckyNumbers[0]);
            Console.WriteLine(luckyNumbers[1]);
            Console.WriteLine(luckyNumbers.Length);
            Console.ReadLine();
        }
    }
}

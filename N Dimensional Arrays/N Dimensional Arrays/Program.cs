using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Dimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // N Dimensional Arrays

            int[][] numberGrid = { new int[] { 1, 2 }, new int[] { 3, 4 } };
            numberGrid[0][1] = 99;

            Console.WriteLine(numberGrid[0][0]);
            Console.WriteLine(numberGrid[0][1]);
            Console.ReadLine();
        }
    }
}

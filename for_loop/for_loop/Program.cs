﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            // FOR LOOPS

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
            int[] LuckyNums = { 4, 8, 15, 16, 23, 42 };
            foreach(int LuckyNum in LuckyNums);
            {
                Console.WriteLine(LuckyNum);
            }
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loops
{
    class Program
    {
        static void Main(string[] args)
        {

            // WHILE LOOPS

            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }
            
            // DO WHILE LOOP
            index = 0;
            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // METHODS 

            int sum = AddNumbers(4, 69);
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public static int addNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}

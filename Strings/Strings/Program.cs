using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRINGS

            string greeting = "Hello";
            //       index:    01234

            Console.WriteLine(greeting.Length);
            Console.WriteLine(greeting[0]);
            Console.WriteLine(greeting.IndexOf("llo"));
            Console.WriteLine(greeting.IndexOf("z"));
            Console.WriteLine(greeting.Substring(2));
            Console.WriteLine(greeting.Substring(1, 3));
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // IF STATEMENTS

            bool isStudent = false;
            bool isSmart = false;

            if (isStudent && isSmart)
            {
                Console.WriteLine("You are a student");
            }
            else if (isStudent && !isSmart)
            {
                Console.WriteLine("You are not a smart student");
            }
            else
            {
                Console.WriteLine("You are not a student and not smart");
            }

            // <, >, >=, <=, !=, ==
            if (1 > 3)
            {
                Console.WriteLine("number comparison was true");
            }

            Console.ReadLine();
        }
    }
}

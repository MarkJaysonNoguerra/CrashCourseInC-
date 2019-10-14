using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switct_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // SWITCH STATEMENTS

            char myGrade = 'A';
            switch (myGrade)
            {
                case 'A' :
                    Console.WriteLine("You Pass");
                    break;
                case 'F' :
                    Console.WriteLine("You fail");
                    break;
                default:
                    Console.WriteLine("Invalid grade");
                    break;
            }
            Console.ReadLine();
        }
    }
}

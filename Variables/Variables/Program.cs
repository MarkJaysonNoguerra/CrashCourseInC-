using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // VARIABLES
            /*
                Names are case-sensitive and may begine with:
                    Letters, _, @
                After, may include
                    Letters, numbers, _
                Convetions says
                    Start with a lowecase word, then additional words are capitalize
                    ex. myFirstVariable
            */
            string name = "Mike"; // String's are objects not primitives
            char testGrade = 'A'; // single 16-bit unicode character

            // short, int, long can be pre-pended with 'u' for 'unsigned'
            byte aga0 = 0;   // 8-bit unsigned integer
            short age1 = 10; // 16-bit signed integer.
            int age2 = 20;   // 32-bit signed integer.
            long age3 = 30L; // 64-bit signed integer

            float gpa0 = 2.5F;  // 32-bit floating point
            double gpa1 = 3.5;  // 64-bit double-precision floating point
            decimal gp2 = 4.5M; // 128-bit precise decimal

            bool isTall;      // 1 bit -> true/false
            isTall = true;

            name = "John";

            Console.WriteLine("Your name is " + name);
            Console.ReadLine();
        }
    }
}

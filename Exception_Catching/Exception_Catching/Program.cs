using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Catching
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXCEPTION CATCHING


            try
            {
                int division = 10 / Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(division);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Not best pratice to use general Exception
            }

            
            Console.ReadLine();
        }
    }
}

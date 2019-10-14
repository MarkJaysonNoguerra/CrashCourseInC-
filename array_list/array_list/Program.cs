using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            // ARRAY LIST 

            ArrayList friends = new ArrayList();
            friends.Add("Oscar");
            friends.Add("Angela");
            friends.Add("Kevin");

            // friends.Remove("Oscar");
            Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
            Console.WriteLine(friends.Contains("Oscar"));
            Console.ReadLine();
        }
    }
}

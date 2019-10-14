using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_inheritance
{
    public class Chef
    {
        public String countryOfOrigin;

        public Chef(String name, int age, String countryOfOrigin)
        {
            this.name = name;
            this.age = age;
        }
        

        public string name;
        public int age;
        public void MakeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The chef makes salad");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes a special dish");
        }
    }

    public class ItalianChef : Chef
    {
        public ItalianChef(String name, int age, String countryOfOrigin)
            : base(name, age)
        {
            this.countryOfOrigin = countryOfOrigin;
        }
        public void MakePasta()
        {
            Console.WriteLine("The Chef make's pasta");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes chicken parm");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Chef myChef = new Chef();
            myChef.MakeSpecialDish();

            ItalianChef myItalianChef = new ItalianChef();
            myItalianChef.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}

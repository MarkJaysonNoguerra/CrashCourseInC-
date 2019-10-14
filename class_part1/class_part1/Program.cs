using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_part1


{
    public class Book
    {
        public string title;
        public string author;
        public static string staticAttribute = "My Static Attribute";
        // constructor
        public Book(String title, String author)
        {
            this.title = title;
            this.author = author;
        }

        public void ReadBook() {
            Console.WriteLine("Reading " + this.title + " by " + this.author);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling");
            Console.WriteLine(book1.title);
            Book book2 = new Book("Lord of the Rings", "JRR Tokien");
            Console.WriteLine(book2.title);
            Console.ReadLine();
        }
    }
}

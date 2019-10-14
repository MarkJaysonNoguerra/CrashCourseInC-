using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_getter_and_setter
{
    public class Book
    {
        private String title;
        private String author;
        public Book(String title, String author)
        {
            this.setTitle(title);
            this.setAuthor(author);
        }
        public String getTitle()
        {
            return this.title;
        }
        public void setTitle(String title)
        {
            this.title = title;
        }
        public String getAuthor()
        {
            return this.author;
        }
        public void setAuthor(String author)
        {
            this.author = author;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Harry Potter", "JK Rowling");
            Console.WriteLine(book1.getTitle());
            Book book2 = new Book("Lord of the Rings", "JRR Tolkien");
            Console.WriteLine(book2.getTitle());
            Console.ReadLine();
        }
    }
}

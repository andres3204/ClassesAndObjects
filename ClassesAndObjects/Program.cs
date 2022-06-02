using System;
using System.Threading.Tasks;
using System.Text;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();
            // OBJECTS
            book1.title = "Harry Potter";
            book1.name = "JK Rowling";
            book1.pages = 280;

            book2.title = "Bible";
            book2.name = "God";
            book2.pages = 1250;

            Console.WriteLine(book1.title);
            Console.WriteLine(book2.title);

            Console.ReadLine();
        }
    }
}
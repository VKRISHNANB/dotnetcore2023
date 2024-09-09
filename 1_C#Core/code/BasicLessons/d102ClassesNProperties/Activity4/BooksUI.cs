using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d33ClassesNProperties.Activity4
{
    class BooksUI
    {
        public static void TestBooks()
        {
            Console.WriteLine("Enter Author ID");
            int id = int.Parse(Console.ReadLine());
            Author a = new Author(id);
            Console.WriteLine("Enter Author Name");
            a.Authorname = Console.ReadLine();
            Console.WriteLine("Enter Author City");
            a.City = Console.ReadLine();
            Console.WriteLine("How many Books do u want to add (1-10)");
            int bcount = int.Parse(Console.ReadLine());
            if (bcount > 10) bcount = 10;
            for(int i=0;i<bcount;i++)
            {
                Book b1 = new Book(i, id);
                b1.BookCost=(1+i) * 100;
                TimeSpan ts = new TimeSpan((long)new Random().NextDouble());
                b1.PublishedDate = DateTime.Now.Subtract(ts);
                b1.Title = "Book" + i;
                a.AddBook(b1);
            }
            //---------------Display details--------------
            Console.WriteLine("******************");
            Console.WriteLine("Author ID "+a.AuthorID);
            Console.WriteLine("Author Name "+a.Authorname);
            Console.WriteLine("Author City "+a.City);
            foreach(Book b in a.GetBooks())
            {
                Console.WriteLine("\t----------------------");
                Console.WriteLine("\tBook Title " + b.Title);
                Console.WriteLine("\tBook Cost " + b.BookCost);
                Console.WriteLine("\tBook PublishedDate " + b.PublishedDate.ToShortDateString());
            }
        }
    }
}

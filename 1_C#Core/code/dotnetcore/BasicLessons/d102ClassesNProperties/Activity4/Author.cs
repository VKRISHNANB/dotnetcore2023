using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLessons.d33ClassesNProperties.Activity4
{
    public class Author
    {
        private readonly int authorID;
        private string authorname;
        private string city;
        private Book[] booklist;

        private int bookcount = 0;
        private int maxbookcount = 10;
        public Author(int aid)
        {
            authorID = aid;
            booklist = new Book[maxbookcount];
        }
        public int AuthorID
        {
            get { return authorID; }
        }
        public string Authorname {
            get { return authorname; }
            set {
                    value = value.Trim();
                    if (value == null || value==String.Empty || value == "")
                    {
                        throw new Exception("Name Must Not Be Empty!!!");
                    }
                    if (value.Length < 3)
                    {
                        throw new Exception("Name Must Have atleast 3 char!!!");
                    }
                    if (value.Length > 15) throw new Exception("INVALID NAME!!! Name must be less than 16 char");
                    char[] data = value.ToUpper().ToCharArray();
                    foreach (char c1 in data)
                    {
                        int x = (int)c1;
                        if (x < 65 || x > 90)
                        {
                            if(x!=32)  throw new Exception("INVALID NAME!!! Name must have only Alphabets");
                        }
                    }
                    authorname = value;
            }
        }
        public string City
        {
            get { return city; }
            set
            {
                if (value == null || value.Equals(" ") || value == "")
                {
                    throw new Exception("City Must Not Be Empty!!!");
                }
                if (value.Length < 3)
                {
                    throw new Exception("City Must Have atleast 3 char!!!");
                }
                if (value.Length > 15) throw new Exception("INVALID City!!! Name must be less than 16 char");
                char[] data = value.ToUpper().ToCharArray();
                foreach (char c1 in data)
                {
                    int x = (int)c1;
                    if (x < 65 || x > 90)
                        throw new Exception("INVALID City!!! City Name must have only Alphabets");
                }
                city = value;
            }
        }

        public Book[] GetBooks()
        {
            Book[] b = new Book[bookcount];
            for(int i=0;i<bookcount;i++)
            {
                b[i]=(booklist[i]);
            }
            return b;
        }

        public void AddBook(Book b)
        {
            if (bookcount < booklist.Length)
                booklist[bookcount++] = b;
            else
                Console.WriteLine("Max Count Reached. FAILED to add BOOK!!!");
        }
    }
}

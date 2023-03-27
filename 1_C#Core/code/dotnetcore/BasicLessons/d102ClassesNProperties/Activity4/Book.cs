using System;

namespace BasicLessons.d33ClassesNProperties.Activity4
{
    public class Book
    {
        private readonly  int bookid;
        private string title;
        private readonly int authorid;
        private float cost;
        private DateTime publisheddate;
        public Book(int bid,int aid)
        {
            bookid = bid;
            authorid = aid;
        }
        public String Title
        {
            get { return title; }
            set
            {
                value = value.Trim();
                if (value == null || value == ""||value==String.Empty)
                {
                    throw new Exception("Title Must Not Be Empty!!!");
                }
                //char[] data = value.ToUpper().ToCharArray();
                //foreach (char c1 in data)
                //{
                //    int x = (int)c1;
                //    if (x < 65 || x > 90)
                //    {
                //        if (x != 32) throw new Exception("INVALID Title!!! Title must have only Alphabets");
                //    }
                //}
                title = value;
            }
        }
        public float BookCost
        {
            get { return cost; }
            set
            {
                if (value < 0)
                    throw new Exception("Invalid Cost!!!");
                if(value%5!=0)
                    throw new Exception("Cost must be multiples of 5!!!");
                cost = value;
            }
        }
        public DateTime PublishedDate
        {
            get { return publisheddate; }
            set
            {
                if (value > DateTime.Now)
                    throw new Exception("Date Can not be in the Future");
                publisheddate = value;
            }
        }
    }
}

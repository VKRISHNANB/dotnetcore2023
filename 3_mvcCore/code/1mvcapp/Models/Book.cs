using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleB.Models
{
    public class Book
    {
        public int BookID { set; get; }
        public String Title { set; get; }
        public float Cost { set; get; }
        public String  AuthorName{ set; get; }
    }
}
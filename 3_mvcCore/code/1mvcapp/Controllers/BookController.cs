using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

using SampleB.Models;
namespace SampleB.Controllers
{
    public class BookController : Controller
    {
        private List<Book> GetBookList()
        {
            List<Book> booklist = new List<Book>();
            for(int i=1;i<10;i++)
            {
                Book b = new Book();
                b.BookID = i;
                b.Title = "Book " + i;
                b.Cost = i * 1000;
                b.AuthorName = "CB";
                booklist.Add(b);
            }
            return booklist;
        }
        // GET: Book
        public ActionResult Index()
        {
            List<Book> booklist = GetBookList();
            return View(booklist);
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            List<Book> booklist = GetBookList();               
            Book book = (from b in booklist
            where b.BookID==id
            select b).First();
          
            return View(book);
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        #region 
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        #endregion
        // GET: Book/Edit/5
        public ActionResult Edit(int id)
        {
           List<Book> booklist = GetBookList();               
            Book book = (from b in booklist
            where b.BookID==id
            select b).First();
            return View(book);
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            Book b = new Book();
            b.BookID = id;
            b.Title = "Book " + id;
            b.Cost = id * 1000;
            b.AuthorName = "CB";
            return View(b);
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

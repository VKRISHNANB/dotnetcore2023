using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspwebapp.Pages
{
    public class PageAModel : PageModel
    {
        public String Name { get; set; }

       public void OnGet()
        {
            ViewData["v1"] =DateTime.Now.ToLongTimeString();
        }
        public void OnPost()
        {            
            TryUpdateModelAsync(this);
            ViewData["v1"] = DateTime.Now.ToLongTimeString()+" : "+this.Name;
            // ViewBag.Data="Hello";
            // ViewBag.HireDate=DateTime.Now;
            // ViewBag.Salary=12345;
        }
    }

}

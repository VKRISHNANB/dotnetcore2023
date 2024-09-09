using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class PageAModel : PageModel
    {
        public string Name { get; set; }
        public void OnGet()
        {
            ViewData["name"] = "Elon Musk";
            this.Name = "Haris Monk";
        }
        public void OnPost()
        {
                TryUpdateModelAsync(this);
                ViewData["name"] = this.Name;
        }
       
    }
}

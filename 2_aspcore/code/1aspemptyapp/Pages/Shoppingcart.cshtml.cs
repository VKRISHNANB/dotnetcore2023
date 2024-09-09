using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspemptyapp.Pages
{
    [IgnoreAntiforgeryToken]
    public class ShoppingcartModel : PageModel
    {
        public void OnGet()
        {
            ViewData["name"] = Request.Query["productname"];
        }
        
        public void OnPost()
        {
            ViewData["name"] = Request.Form["productname"];

        }
    }
}

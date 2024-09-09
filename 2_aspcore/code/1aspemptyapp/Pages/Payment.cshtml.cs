using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspemptyapp.Pages
{
    public class PaymentModel : PageModel
    {
        public void OnGet()
        {
            ViewData["name"] = Request.Query["creditcard"];
        }

        public void OnPost()
        {
            ViewData["name"] = Request.Form["creditcard"];

        }
    }
}

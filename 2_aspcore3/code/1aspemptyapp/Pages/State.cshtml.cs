using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspemptyapp.Pages
{
   
    public class StateModel : PageModel
    {
        [BindProperty]
        public String Name { get; set; } = "Un assigned";
        public String City { get; set; } = "City of No where";
        public void OnPost()
        {
           
        }
        public void OnPostSet()
        {
            City = Request.Form["city"];
            ViewData["result"] = "set - " + City;
        }
        public void OnPostGet()
        {
            ViewData["result"] = Name + " " + City;
        }
        public void OnPostPageA()
        {
            String result = String.Empty;
            /*Response.Redirect("PageA");*/
            result="Before Page Redirect \n";

           /* this.RedirectPermanent("PageA");*/
            result += "After Page Redirect";
            ViewData["result"] = result;
            
        }
    }
}

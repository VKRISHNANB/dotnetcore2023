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
        /**
            the [BindProperty] attribute is used to bind a property of a model class to an incoming request parameter. This is particularly useful when working with Razor Pages and model binding.
            Here Name is a BindProperty where as City is not.
            - ASP.NET Core's model binding system automatically maps incoming request data (e.g., form fields, query string parameters, route data) to properties of a model class.
            - The [BindProperty] attribute tells the model binding system to bind the decorated property to an incoming request parameter with the same name.
        */
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
            ViewData["result"] = Name + "  " + City;
        }
        public void OnPostPageA()
        {
            String result = String.Empty;
            result="Before Page Redirect \n";
            ViewData["result"] = result;

            Response.Redirect("PageA");

        //    this.RedirectPermanent("PageA");
            // result += "After Page Redirect";
            
        }
    }
}

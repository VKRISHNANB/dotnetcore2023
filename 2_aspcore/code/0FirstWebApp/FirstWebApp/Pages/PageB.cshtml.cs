using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstWebApp.Pages
{
    public class PageBModel : PageModel
    {
        public void OnGet()
        {
        }
        public void OnPost()
        {
            String requestName = String.Empty;
            String requestCity = String.Empty;
            requestName = Request.Form["txtName"] ;
            requestCity = Request.Form["txtCity"] ;
            ViewData["name"] = requestName;
            ViewData["city"] = requestCity;
        }
        private void ListFormCollection()
        {
            int count = Request.Form.Count;
            ViewData["count"] = count;
            String requestParams = String.Empty;
            foreach (var key in Request.Form.Keys)
            {
                requestParams += key + ":" + Request.Form[key] + ";";
            }
            ViewData["params"] = requestParams;
        }
    }
}

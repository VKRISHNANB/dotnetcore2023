using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstWebApp.Model;
namespace FirstWebApp.Pages
{
    public class LoginModel : PageModel
    {
        [BindProperty] 
        public User Member { get; set; }
        
        public void OnGet()
        {
        }
        public void OnPost()
        {
            TryUpdateModelAsync<User>(this.Member);
            String uName = this.Member.Name;
            String pwd = this.Member.Password;
           
            /// TODO: check User with Database
            UserRepository repo = new UserRepository();
            User found = repo.GetUser(uName, pwd);
            bool flag = (found!=null);
            if (flag)
                Response.Redirect("Welcome");
            else
                ViewData["Error"] = "Invalid USER!!!";
        }
    }
}

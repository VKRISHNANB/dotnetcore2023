using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVC.ViewComponents
{
    public class DisplayViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(String section)
        {
            ViewData.Add("section", section);
            return View("Display");
        }
    }
}

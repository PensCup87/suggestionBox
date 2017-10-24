using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace suggestionBox.Controllers
{
    public class HomeController : Controller
    {
        //there is an action for each page, any new page needs a new action
        //not all actions return a view
        public ActionResult Index()
        {
            return View();
        }

        
    }
}
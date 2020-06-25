using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Commic_Book_Gallery_2.Controllers
{
    public class ComicBooksController : Controller
    {
        //public string Detail()
        //{
            
        //    return "Hello from the comic books controller!";
        //}

        public ActionResult Detail()
        {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            //{
            //    return Redirect("/");
            //}

            //return Content("Hello from the comic books controller!");

            return View();  //this goes to html view, prev does not
        }
    }
}

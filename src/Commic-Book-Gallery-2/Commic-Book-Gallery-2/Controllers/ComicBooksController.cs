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

          

            ViewBag.SeriesTitle = "The amazing Spider-Mann";
            ViewBag.IssueNumber = 700;
            ViewBag.Description = "<p>Fiinal issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            ViewBag.Artists = new string[]
            {
                "Script: Dan Slott",
                "Pencils: Humberto Ramos",
                "Inks: Victor Olazaba",
                "Colors: Edgar Delgado",
                "Letters: Chris Eliopoulos"
            };

            return View();  //this goes to html view, prev does not
        }
    }
}

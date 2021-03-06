﻿using Commic_Book_Gallery_2.Data;
using Commic_Book_Gallery_2.Models;
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

        //private ComicBookRepository _comicBookRepository = null;

        //public ComicBooksController()
        //{
        //    _comicBookRepository = new ComicBookRepository();
        //}

        //public ActionResult Index()
        //{
        //    var comicBooks = _comicBookRepository.GetComicBooks();

        //    return View(comicBooks);
        //}


        public ActionResult Detail(int id)
        {
            //if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            //{
            //    return Redirect("/");
            //}

            //return Content("Hello from the comic books controller!");

            //if (id == null)
            //{
            //    return HttpNotFound();
            //}

            var comicBook = _comicBookRepository.GetComicBook(id); //id.Value also works on nullable
                
                
            //    new ComicBook()
            //{
                
            //    SeriesTitle = "The amazing Spider-Mann",
            //    IssueNumber = 700,
            //    DescriptionHtml = "<p>Fiinal issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
            //    Artists = new Artist[] {
            //        new Artist() { Role = "Script", Name = "Dan Slott" },
            //        new Artist() { Role = "Pencils", Name = "Humberto Ramos" },
            //        new Artist() { Role = "Inks", Name = "Victor Olazaba" },
            //        new Artist() { Role = "Colors", Name = "Edgar Delgado" },
            //        new Artist() { Role = "Letters", Name = "Chris Eliopoulos" }
            //    }
            
            //};

            //ViewBag.Title = "Super Mario 64";
            //ViewBag.Description = "Super Mario 64 is a 1996 platform video game developed and published by Nintendo for the Nintendo 64.";

            //ViewBag.SeriesTitle = "The amazing Spider-Mann";
            //ViewBag.IssueNumber = 700;
            //ViewBag.Description = "<p>Fiinal issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>";
            //ViewBag.Artists = new string[]
            //{
            //    "Script: Dan Slott",
            //    "Pencils: Humberto Ramos",
            //    "Inks: Victor Olazaba",
            //    "Colors: Edgar Delgado",
            //    "Letters: Chris Eliopoulos"
            //};

            return View(comicBook);  //this goes to html view, prev does not
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }
    }
}

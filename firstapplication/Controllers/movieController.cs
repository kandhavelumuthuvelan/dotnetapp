using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using firstapplication.Models;
using firstapplication.ViewModel;

namespace firstapplication.Controllers
{
    public class movieController : Controller
    {
        // GET: movie
        public ActionResult Random()
        {
            var moviee = new Movie() {Name="kandhavelu!"};
            var customers = new List<Customer> {
                new Customer{Id=1,Name="kandhavelu 1" },
                new Customer{Name = "kandhavelu 2"}

        };
            var viewmodel = new RandomMovieViewModdel
            {
                movie = moviee,
                customer = customers

            };
            
            

            return View(viewmodel);
            // return Content("hello kandhavelu");
             //  return RedirectToAction("Index","Home", new {Page=1,sortBy="name" });
        }
        public ActionResult Edit(int id)
        {
            return Content("id" + id);
        }
        public ActionResult Index(int? pageIndex,string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if(string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("PageIndex{0}&SortBy{1}",pageIndex,sortBy));
        }
        
        public ActionResult ByreleaseDate(int? year,int? month)
        {
            if (!year.HasValue)
                year = 1;
            if (!month.HasValue)
                month = 1;
            return Content(year+"/"+month);
        }

       

        //[Route("movie/released/{year}/{month:regex(\\d{4})}")]
        //public ActionResult releasedata(int? year, int? month)
        //{

        //    return Content(year+"//"+month);
        //}

    }
}
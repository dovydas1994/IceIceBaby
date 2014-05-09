using IceSubs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace IceSubs.Controllers
{
    public class FrontPageViewModel
    {
        public List<Medium> MostPopular { get; set; }
        public List<Medium> NewestTV { get; set; }
        public List<Medium> NewestMovies { get; set; }
        public List<Medium> MostSuggested { get; set; }
        public List<Medium> HighestRated { get; set; }
    }


    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            FrontPageViewModel model = new FrontPageViewModel();

            using (MediaRepository repo = new MediaRepository())
            {
                model.MostPopular = repo.GetAllMedia().OrderByDescending(x => x.Translation.Downloads).Take(8).ToList();
            }

            //ViewBag.Username = User.Identity.GetUserName();

            return View(model);
        }

    }
}
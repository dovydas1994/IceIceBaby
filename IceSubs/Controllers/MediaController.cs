using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IceSubs.Models;

namespace IceSubs.Controllers
{
    public class MediaController : Controller
    {

        MediaRepository repository = new MediaRepository();
      
        public ActionResult Newest()
        {
            IQueryable<Medium> newestMedia = (from item in repository.GetAllMedia()
                                              orderby item.DateAdded descending
                                              select item);
            ViewBag.Title = "Newest";
            return View("All", newestMedia);
        }

        public ActionResult Popular()
        {
          
            IQueryable<Medium> mostPopular = (from item in repository.GetAllMedia()
                                              orderby item.Translation.Downloads descending
                                              select item);
            ViewBag.Title = "Popular";
            return View("All", mostPopular);
        }

        public ActionResult All()
        {
            IQueryable<Medium> allMedia = (from item in repository.GetAllMedia()
                                              orderby item.Title ascending
                                              select item);
            ViewBag.Title = "All";
            return View("All", allMedia);
        }

        public ActionResult Movies()
        {
            IQueryable<Medium> movieMedia = (from item in repository.GetAllMedia()
                                                where item.MediaType == "Movie"
                                                orderby item.Title ascending //sorted in alpha order
                                                select item);
            ViewBag.Title = "Movies";
            return View("All", movieMedia);
        }

        public ActionResult TvSeries()
        {
            IQueryable<Medium> movieMedia = (from item in repository.GetAllMedia()
                                                where item.MediaType == "TV Series"
                                                orderby item.Title ascending //sorted in alpha order
                                                select item);
            ViewBag.Title = "TV Series";
            return View("All", movieMedia);
        }


        public ActionResult Detail() //detailed view, TODO: implement
        {
            return View();
        }


	}
}
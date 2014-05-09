using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IceSubs.Models
{
    public class SearchEngineController : Controller
    {
        [HttpPost]
        public ActionResult Browse(string searchBar)
        {
            //String prefix = formData["searchBtn"];

            if (!String.IsNullOrEmpty(searchBar))
            {
                MediaRepository repository = new MediaRepository();

                IQueryable<Medium> allMedia = (from item in repository.GetAllMedia()
                                               orderby item.Title ascending
                                               where item.Title.Contains(searchBar)
                                               select item);

                //List<Medium> vec = new List<Medium>();
                //foreach (var item in allMedia)
                //{
                    //if (searchBar.ToLower() == item.Title.ToLower().Substring(0, searchBar.Length) && searchBar != null)
                    //{
                        //vec.Add(item);
                    //}
                //}

                return View(allMedia);
            }
            return View();
        }
    }
}
using furniturestore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace furniturestore.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        furniturestoreContext db = new furniturestoreContext();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string searchbox, int dropDown)
        {
            List<Product> myItems = db.Products.ToList<Product>();
            ViewBag.Count = myItems.FindAll(x => x.name.Contains(searchbox)&& (x.FoodGroupID==dropDown||dropDown==3)).Count();
            return View(myItems.FindAll(x => x.name.Contains(searchbox)&& (x.FoodGroupID==dropDown||dropDown==3)));
        }
        //[HttpPost]
        //public ActionResult Index(int dropDown)
        //{
        //    List<Product> myItems = db.Products.ToList<Product>();
        //    ViewBag.Count = myItems.FindAll(x => x.FoodGroupID==dropDown);
        //    return View(myItems.FindAll(x => x.FoodGroupID==dropDown));
        //}

        //[HttpPost]
        //public ActionResult Index(int dropDown, string searchBox)
        //{
        //    List<Product> myItems = db.Products.ToList<Product>();
        //    ViewBag.Count = myItems.FindAll(x => x.FoodGroupID == dropDown);
        //    return View(myItems.FindAll(x => x.FoodGroupID == dropDown));
        //}


        [ChildActionOnly]
        public ActionResult ProductMenu()
        {
            var items = db.FoodGroups.ToList();

            return PartialView(items);
        }
    }
}
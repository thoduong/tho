using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExerciseWebRole2.Database;
using ExerciseWebRole2.Models.ViewModel;

namespace ExerciseWebRole2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Data_ShopDataContext dc = new Data_ShopDataContext();
            HomeViewModel hvm = new HomeViewModel();
            hvm.ListCategory = dc.Categories.ToList();
            hvm.ListProductBelong = dc.Products.OrderByDescending(p => p.ProductPrice).Take(5).ToList();           
            return View(hvm);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

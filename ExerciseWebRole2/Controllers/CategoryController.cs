using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExerciseWebRole2.Database;
using ExerciseWebRole2.Models.ViewModel;

namespace ExerciseWebRole2.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        public ActionResult Index()
        {
            Data_ShopDataContext dc = new Data_ShopDataContext();
            ViewBag.ListEntry = dc.Categories.ToList();
            ViewBag.ListProduct = dc.Products.ToList();
            return View();
            
        }
        public ActionResult Detail(string id)
        {
            Data_ShopDataContext dc = new Data_ShopDataContext();
            CategoryDetailViewModel cvm = new CategoryDetailViewModel();
            cvm.ListProductBelong = dc.Products.Where(p => p.CategoryID.Equals(id)).ToList();
            cvm.ListCategory = dc.Categories.ToList();
            return View(cvm);
        }
        public ActionResult DetailProduct(string product)
        {
            Data_ShopDataContext dc = new Data_ShopDataContext();
            ProductDetailViewModel pdvm = new ProductDetailViewModel();
            pdvm.Product = dc.Products.Where(p => p.ProductID.Equals(product)).SingleOrDefault();
            pdvm.ListCategory = dc.Categories.ToList();
            return View(pdvm);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDatabinding.Models;
namespace MvcDatabinding.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        ProductsContext db = new ProductsContext();
        public ActionResult Index()
        {
            Program p = new Program();
            return View(db.ProductsTable.ToList());
        }
    }
}
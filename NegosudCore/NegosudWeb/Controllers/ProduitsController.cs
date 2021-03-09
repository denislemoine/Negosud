using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NegosudWeb.Controllers
{
    public class ProduitsController : Controller
    {
        // GET: Produits
        public ActionResult Index()
        {
            return View();
        }
    }
}
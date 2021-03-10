using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using NegosudWeb.Models;

namespace NegosudWeb.Controllers
{
    public class ProduitsController : Controller
    {
        // GET: /Produits/
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            string requestUrl = Constant.ApiUrl + "Produits/";
            HttpResponseMessage response;

            using (var httpClient = new HttpClient()) {
                response = await httpClient.GetAsync(requestUrl);
            }

            var content = await response.Content.ReadAsStringAsync();
            JArray product2 = JArray.Parse(content);
            List<ProductItems> listProduct = product2.ToObject<List<ProductItems>>();
            //ProductItems product = new System.Web.Script.Serialization.JavaScriptSerializer().Deserialize<ProductItems>(content);

            ViewBag.Produits = listProduct;


            return View();
        }




    }
    
}
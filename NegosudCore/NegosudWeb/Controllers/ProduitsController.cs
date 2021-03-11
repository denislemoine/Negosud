using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using NegosudWeb.Models;
using Newtonsoft.Json;
using System.Web.Script.Serialization;

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
            JArray product = JArray.Parse(content);
            List<ProductItems> listProduct = product.ToObject<List<ProductItems>>();

            requestUrl = Constant.ApiUrl + "Familles/";
            using (var httpClient = new HttpClient())
            {
                response = await httpClient.GetAsync(requestUrl);
            }
            content = await response.Content.ReadAsStringAsync();
            JArray famille = JArray.Parse(content);
            List<Famille> listFamille = famille.ToObject<List<Famille>>();

            for (int i = 0; i < listProduct.Count; i++)
            {
                for (int j = 0; j < listFamille.Count; j++)
                {
                    if(listProduct[i].IdFamille == listFamille[j].Id)
                    {
                        listProduct[i].Famille = listFamille[j].Libelle;
                        j = listFamille.Count;
                    }
                }
            }

            ViewBag.Produits = listProduct;


            return View();
        }

        // GET: /Produit/{Id}
        [HttpGet]
        public async Task<ActionResult> Produit(int id)
        {
            string requestUrl = Constant.ApiUrl + "Produits/" + id.ToString();
            HttpResponseMessage response;

            using (var httpClient = new HttpClient())
            {
                response = await httpClient.GetAsync(requestUrl);
            }

            var content = await response.Content.ReadAsStringAsync();
            ProductItems product = JsonConvert.DeserializeObject<ProductItems>(content);

            ViewBag.Produit = product;

            return View();
        }




    }
    
}
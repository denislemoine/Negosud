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

            //Create Array with JSON
            var content = await response.Content.ReadAsStringAsync();
            JArray product = JArray.Parse(content);

            //Complete ProductItems Object
            List<ProductItems> listProduct = await InfosAllProducts(product.ToObject<List<ProductItems>>());

            //Sending data to view
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
            ProductItems product = await InfoProduct(JsonConvert.DeserializeObject<ProductItems>(content));

            ViewBag.Produit = product;

            return View();
        }
        [HttpGet]
        public async Task<List<Famille>> Famille()
        {
            string requestUrl = Constant.ApiUrl + "Familles/";
            HttpResponseMessage response;
            using (var httpClient = new HttpClient())
            {
                response = await httpClient.GetAsync(requestUrl);
            }
            var content = await response.Content.ReadAsStringAsync();
            JArray famille = JArray.Parse(content);
            List<Famille> listFamille = famille.ToObject<List<Famille>>();
            return listFamille;

        }
        [HttpGet]
        public async Task<List<Stock>> Stock()
        {
            string requestUrl = Constant.ApiUrl + "Stocks/";
            HttpResponseMessage response;
            using (var httpClient = new HttpClient())
            {
                response = await httpClient.GetAsync(requestUrl);
            }
            var content = await response.Content.ReadAsStringAsync();
            JArray stock = JArray.Parse(content);
            List<Stock> listStock = stock.ToObject<List<Stock>>();
            return listStock;
        }
        public async Task<List<ProductItems>> InfosAllProducts(List<ProductItems> listProduct)
        {
            List<Famille> listFamille = await Famille();
            List<Stock> listStock = await Stock();

            for (int i = 0; i < listProduct.Count; i++)
            {
                for (int j = 0; j < listFamille.Count; j++)
                {
                    if (listProduct[i].IdFamille == listFamille[j].Id)
                    {
                        listProduct[i].Famille = listFamille[j].Libelle;
                        j = listFamille.Count;
                    }
                }
                for (int j = 0; j < listStock.Count; j++)
                {
                    if (listProduct[i].Id == listStock[j].IdProduit)
                    {
                        listProduct[i].Quantite = listStock[j].Quantite;
                        j=listFamille.Count;
                    }
                }
            }
            return listProduct;
        }
        public async Task<ProductItems> InfoProduct(ProductItems product)
        {
            List<Famille> listFamille = await Famille();
            List<Stock> listStock = await Stock();

            for (int j = 0; j < listFamille.Count; j++)
            {
                if (product.IdFamille == listFamille[j].Id)
                {
                    product.Famille = listFamille[j].Libelle;
                    j = listFamille.Count;
                }
            }
            for (int j = 0; j < listStock.Count; j++)
            {
                if (product.Id == listStock[j].IdProduit)
                {
                    product.Quantite = listStock[j].Quantite;
                    j = listFamille.Count;
                }
            }
            return product;
        }




    }
    
}
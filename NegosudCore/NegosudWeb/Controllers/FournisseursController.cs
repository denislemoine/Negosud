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
    public class FournisseursController : Controller
    {
        // GET: /Fournisseurs/
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            string requestUrl = Constant.ApiUrl + "Fournisseurs/";
            HttpResponseMessage response;

            using (var httpClient = new HttpClient()) {
                response = await httpClient.GetAsync(requestUrl);
            }

            var content = await response.Content.ReadAsStringAsync();
            JArray fournisseurs = JArray.Parse(content);
            List<Fournisseur> listFournisseurs = fournisseurs.ToObject<List<Fournisseur>>();

            ViewBag.Fournisseurs = listFournisseurs;

            return View();
        }

        // GET: /Fournisseur/{Id}
        [HttpGet]
        public async Task<ActionResult> Fournisseur(int id)
        {
            string requestUrl = Constant.ApiUrl + "Fournisseurs/" + id.ToString();
            HttpResponseMessage response;

            using (var httpClient = new HttpClient())
            {
                response = await httpClient.GetAsync(requestUrl);
            }

            var content = await response.Content.ReadAsStringAsync();
            Fournisseur fournisseur = JsonConvert.DeserializeObject<Fournisseur>(content);

            ViewBag.Fournisseur = fournisseur;

            return View();
        }


    }
    
}
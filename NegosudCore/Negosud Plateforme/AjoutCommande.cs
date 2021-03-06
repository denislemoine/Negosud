using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Negosud_Plateforme
{
    public partial class AjoutCommande : Form
    {
        string produitSelect;
        int quantite;
        int Prix, prixTotale, prixtotaux;
        long idSelect, idFournisseurSelect, maxId, i;
        Dictionary<string, int> listSelect = new Dictionary<string, int>();
        Dictionary<long, int> listSelectCmd = new Dictionary<long, int>();

        private HttpWebRequest webRequest;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
    
            var webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:58841/api/Produits");
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            if ((webResponse.StatusCode == HttpStatusCode.OK))
            {
                var reader = new StreamReader(webResponse.GetResponseStream());
                string s = reader.ReadToEnd();
                var arr = JsonConvert.DeserializeObject<List<ProduitDto>>(s);


                produitSelect = comboBox_Produits_Commande.GetItemText(comboBox_Produits_Commande.SelectedItem);

                if (produitSelect != "")
                {
                    idSelect = arr.FirstOrDefault(x => x.nom == produitSelect).id;
                    Prix = arr.FirstOrDefault(x => x.nom == produitSelect).prixFournisseur;
                    quantite = (int)numericUpDown1.Value;
                    prixTotale = (int)(Prix * quantite);
                    textBox_Prix_Total.Text = prixTotale.ToString() + " €";

                }

            }
            else
            {
                MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
            }
        }


        public AjoutCommande()
        {
            InitializeComponent();
        }

        private void AjoutCommande_Load(object sender, EventArgs e)
        {
            apiComboBOx("http://localhost:58841/api/Produits");      

        }


       private void apiComboBOx(string url)
        {
            if (url == "http://localhost:58841/api/Produits")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<ProduitDto>>(s);
                    var list = new BindingList<ProduitDto>(arr);
                    var data = new BindingSource(list, null);
                    comboBox_Produits_Commande.DataSource = data.DataSource;
                    comboBox_Produits_Commande.DisplayMember = "nom";
                    comboBox_Produits_Commande.ValueMember = "nom";

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }

        }

       
        private void button_Ajout_Commande_Click(object sender, EventArgs e)
        {
            listSelect.Add(produitSelect.ToString() + " x" + quantite.ToString(), prixTotale) ; 
            listSelectCmd.Add(idSelect, quantite); 
          
            dataGridView1.DataSource = (from d in listSelect orderby d.Value select new { d.Key, d.Value }).ToList();
        }

        private void button_Terminer_Commande_Click(object sender, EventArgs e)
        {
            // On créer une commande
            string url = "http://localhost:58841/api/CommandeInternes";

            prixtotaux = 0;
            foreach (KeyValuePair<string, int> entry in listSelect)
            {
                var prixLoop = entry.Value;
                prixtotaux += prixLoop;
            }

            string requestParams = JsonTCommandeInterne();

            webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            AppelApiId();
            // on rucupère la liste des produits et leurs stocks
            url = "http://localhost:58841/api/Stocks";
            webRequest = (HttpWebRequest)WebRequest.Create(url);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            if ((webResponse.StatusCode == HttpStatusCode.OK))
            {
                var reader = new StreamReader(webResponse.GetResponseStream());
                string s = reader.ReadToEnd();
                var arr = JsonConvert.DeserializeObject<List<StockDto>>(s);

                // Pour chaque Article dans la commande
                foreach (KeyValuePair<long, int> entry in listSelectCmd)
                {
                    url = "http://localhost:58841/api/CommandeInterneProduits";
                    var idSelectLoop = entry.Key;
                    var quantiteLoop = entry.Value;
                    var allStockId = from r in arr
                                orderby r.id
                                select r;

                    // On ajoute un le produit a la commande
                    requestParams = JsonTCommandeInterneProduit(idSelectLoop, quantiteLoop);
                    webRequest = (HttpWebRequest)WebRequest.Create(url);
                    webRequest.Method = "POST";
                    webRequest.ContentType = "application/json";

                    byte[] byteArrayy = Encoding.UTF8.GetBytes(requestParams);
                    webRequest.ContentLength = byteArrayy.Length;
                    using (Stream requestStream = webRequest.GetRequestStream())
                    {
                        requestStream.Write(byteArrayy, 0, byteArrayy.Length);
                    }

                    // Mise a jours du stock commandé sur le produit
                    foreach (var std in allStockId)
                    {
                        if (std.idProduit == idSelectLoop)
                        {
                            var idStock = std.id;
                            url = "http://localhost:58841/api/Stocks/" + idStock.ToString();
                            JavaScriptSerializer ser = new JavaScriptSerializer();
                            var jsonData = new StockDto()
                            {
                                id = idStock,
                                idProduit = idSelectLoop,
                                quantite = std.quantite,
                                quantiteCommande = quantiteLoop+std.quantiteCommande,

                            };
                            requestParams = ser.Serialize(jsonData);

                            webRequest = (HttpWebRequest)WebRequest.Create(url);
                            webRequest.Method = "PUT";
                            webRequest.ContentType = "application/json";

                            byte[] byteArray2 = Encoding.UTF8.GetBytes(requestParams);
                            webRequest.ContentLength = byteArray2.Length;
                            using (Stream requestStream = webRequest.GetRequestStream())
                            {
                                requestStream.Write(byteArray2, 0, byteArray2.Length);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
            }
            // On ferme le formulaire de commande
            this.Close();
        }
        public string JsonTCommandeInterne()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            DateTime myDateTime = DateTime.Now;
            string sqlFormattedDate = myDateTime.ToString("yyyy-MM-ddTHH:mm:ss.fff");

            var jsonData = new CommandeInterneDto()
            {
                id = 0,
                prixTotal = prixtotaux,
                dateCommande = sqlFormattedDate,
                isActive = true,
                status = "En cours",

            };

            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonTCommandeInterneProduit(long idSelect, int quantite)
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new CommandeInterneProduitDto()
            {

                idCommandeInterne = i, 
                idProduit = idSelect,
                quantite = quantite,

            };
            var result = ser.Serialize(jsonData);
            return result;
        }

        public void AppelApiId()
        {
           string url = "http://localhost:58841/api/CommandeInternes";

            var webRequest = (HttpWebRequest)WebRequest.Create(url);
            var webResponse = (HttpWebResponse)webRequest.GetResponse();

            if ((webResponse.StatusCode == HttpStatusCode.OK))
            {
             
                var reader = new StreamReader(webResponse.GetResponseStream());
                string s = reader.ReadToEnd();
                var arr = JsonConvert.DeserializeObject<List<CommandeInterneDto>>(s);

                var maxId = from r in arr
                            orderby r.id
                            select r;
                i = 1;

                foreach (var std in maxId)
                {
                    i++;
                    
                }
            }
            else
            {
                MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
            }
        }


    }
}

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
    public partial class AjoutProduit : Form
    {
        private HttpWebRequest webRequest;
        private long idProduit, id;
        private string nameProduit, millesimePorduit, descriptionProduit, domaineProduit,urlPhotoProduit, contenantProduit;
        private int prixProduit, prixFournisseurProduit;
        int i;
        public AjoutProduit()
        {
            InitializeComponent();
        }

        private void AjoutProduit_Load(object sender, EventArgs e)
        {
            Lecture_Fournisseur("http://localhost:58841/api/Fournisseurs");
            Lecture_Famille("http://localhost:58841/api/Familles");

        }

        
        private void TxtBox_Millesime_Produit_TextChanged(object sender, EventArgs e)
        {
            millesimePorduit = TxtBox_Millesime_Produit.Text;
        }

        private void TxtBox_Domaine_TextChanged(object sender, EventArgs e)
        {
            domaineProduit = TxtBox_Domaine.Text;
        }

        private void TxtBox_Description_TextChanged(object sender, EventArgs e)
        {
            descriptionProduit = TxtBox_Description.Text;
        }

        private void TxtBox_URL_Photo_TextChanged(object sender, EventArgs e)
        {
            urlPhotoProduit = TxtBox_URL_Photo.Text;
        }

        private void TxtBox_Contenant_TextChanged(object sender, EventArgs e)
        {
            contenantProduit = TxtBox_Contenant.Text;
        }

        private void textBox_Prix_Fournisseur_TextChanged(object sender, EventArgs e)
        {
            prixFournisseurProduit = Int32.Parse(textBox_Prix_Fournisseur.Text);
        }

        private void textBox_Prix_TextChanged(object sender, EventArgs e)
        {
            prixProduit = Int32.Parse(textBox_Prix.Text);
        }

        private void TxtBox_Nom_Produit_TextChanged(object sender, EventArgs e)
        {
            nameProduit = TxtBox_Nom_Produit.Text;
        }

       


        private void button_Ajout_Produits_Click(object sender, EventArgs e)
        {

            string url = "http://localhost:58841/api/Produits";

            string requestParams = JsonTester();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "POST";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

           
           
                 url = "http://localhost:58841/api/Produits";

                 webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {

                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<ProduitDto>>(s);

                    var maxId = from r in arr
                                orderby r.id
                                select r;
                    i = 1;

                    foreach (var std in maxId)
                    {
                        i++;

                    }

                 url = "http://localhost:58841/api/Stocks";

                 requestParams = JsonStock();

                webRequest = (HttpWebRequest)WebRequest.Create(url);

                webRequest.Method = "POST";
                webRequest.ContentType = "application/json";

                byte[] byteArrayy = Encoding.UTF8.GetBytes(requestParams);
                webRequest.ContentLength = byteArrayy.Length;
                using (Stream requestStream = webRequest.GetRequestStream())
                {
                    requestStream.Write(byteArrayy, 0, byteArrayy.Length);
                }

            }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }

          

            this.Close();


        }
        public string JsonStock()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new StockDto()
            {

                
                idProduit = i,
                quantite = 1,
                quantiteCommande = 0,
                

            };


            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonTester()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ProduitDto()
            {

                nom = nameProduit,
                millesime = millesimePorduit,
                prix = prixProduit,
                prixFournisseur = prixFournisseurProduit,
                description = descriptionProduit,
                domaine = domaineProduit,
                urlPhoto = urlPhotoProduit,
                contenant = contenantProduit,
                isActive = true,
                commandeAuto = true,
              
            };


            var result = ser.Serialize(jsonData);
            return result;
        }

        public void Lecture_Fournisseur(string url)
        {
            if (url == "http://localhost:58841/api/Fournisseurs")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<FournisseurDto>>(s);
                    var list = new BindingList<FournisseurDto>(arr);
                    var data = new BindingSource(list, null);
                    comboBox_Fournisseur.DataSource = data.DataSource;
                    comboBox_Fournisseur.DisplayMember = "nomEntreprise";
                    comboBox_Fournisseur.ValueMember = "nomEntreprise";

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
        }
        public void Lecture_Famille(string url)
        {
            if (url == "http://localhost:58841/api/Familles")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<FamilleDto>>(s);
                    var list = new BindingList<FamilleDto>(arr);
                    var data = new BindingSource(list, null);
                    comboBox_Famille.DataSource = data.DataSource;
                    comboBox_Famille.DisplayMember = "libelle";
                    comboBox_Famille.ValueMember = "libelle";

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
        }
    }
}


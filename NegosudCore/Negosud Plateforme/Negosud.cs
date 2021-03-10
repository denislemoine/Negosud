using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Web.Script.Serialization;

namespace Negosud_Plateforme
{
    public partial class Negosud : Form
    {
        AjoutClient ajoutClient = new AjoutClient();
        AjoutProduit ajoutProduit = new AjoutProduit();
        AjoutFamille ajoutFamille = new AjoutFamille();
        private HttpWebRequest webRequest;

        string id;
        string libel;
        string IsActiv;

        public string CelluleProduitValue { get; private set; }

        public Negosud()
        {
            InitializeComponent();
        }

        private void Negosud_Load(object sender, EventArgs e)
        {


        }


        private void Btn_Ajout_Client_Click(object sender, EventArgs e)
        {
            this.ajoutClient.Show();

        }


        private void appel_Api(string url)
        {
            ClientDto clientDto = new ClientDto();

            if (url == "http://localhost:58841/api/Clients")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<ClientDto>>(s);
                    var list = new BindingList<ClientDto>(arr);
                    var data = new BindingSource(list, null);
                   
            
                        dataGridView_Client.DataSource = data;
                
                    
                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
            else if (url == "http://localhost:58841/api/Produits")
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
                    dataGridView_Produits.DataSource = data;

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }

            }
            else if (url == "http://localhost:58841/api/Familles")
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
                    dataGridView_Familles.DataSource = data;

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
            else if (url == "http://localhost:58841/api/Fournisseurs")
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
                    dataGridView_Fournisseurs.DataSource = data;

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }


        }


        private void tabPage_Fournisseurs_Click(object sender, EventArgs e)
        {
            appel_Api("http://localhost:58841/api/Fournisseurs");
        }

        private void tabPage_Produits_Click(object sender, EventArgs e)
        {
            appel_Api("http://localhost:58841/api/Produits");
        }


        private void tabPage_Clients_Click(object sender, EventArgs e)
        {
            appel_Api("http://localhost:58841/api/Clients");
        }

        private void tabPage_Familles_Click(object sender, EventArgs e)
        {
            appel_Api("http://localhost:58841/api/Familles");
            this.dataGridView_Familles.Columns["IsActive"].Visible = false;
          
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            appel_Api("http://localhost:58841/api/Produits");
        }

        private void Btn_Ajout_Produit_Click_1(object sender, EventArgs e)
        {
            this.ajoutProduit.Show();
        }

        private void Btn_Ajour_Famille_Click(object sender, EventArgs e)
        {
            this.ajoutFamille.Show();
        }

        private void button_Suppr_Click(object sender, EventArgs e)
        {
            MessageBox.Show(IsActiv);

            if (dataGridView_Familles.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Familles.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Familles.Rows[selectedrowindex];

                id = Convert.ToString(selectedRow.Cells["Id"].Value);
                libel = Convert.ToString(selectedRow.Cells["Libelle"].Value);
                IsActiv = Convert.ToString(selectedRow.Cells["IsActive"].Value);

            }

            string url = "http://localhost:58841/api/Familles/" + id;

            string requestParams = JsonFamillesSuppr();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

        }

        private void button_Modifier_Click(object sender, EventArgs e)
        {

           

            if (dataGridView_Familles.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Familles.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Familles.Rows[selectedrowindex];

                id = Convert.ToString(selectedRow.Cells["Id"].Value);
                libel = Convert.ToString(selectedRow.Cells["Libelle"].Value);
                IsActiv = Convert.ToString(selectedRow.Cells["IsActive"].Value);

            }

            string url = "http://localhost:58841/api/Familles/" + id;
            string requestParams = JsonFamilleModif();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

        }
        public string JsonFamilleModif()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new FamilleDto()
            {
                Id = Convert.ToInt64(id),
                libelle = libel,
                isActive = bool.Parse(IsActiv),

            };

            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonFamillesSuppr()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new FamilleDto()
            {
                Id = Convert.ToInt64(id),
                libelle = libel,
                isActive = bool.Parse("false"),

            };

            var result = ser.Serialize(jsonData);
            return result;
        }


    }
}

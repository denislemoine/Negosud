using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.ComponentModel;
using System.Collections.Generic;

namespace Negosud_Plateforme
{
    public partial class Negosud : Form
    {
        AjoutClient ajoutClient = new AjoutClient();
        AjoutProduit ajoutProduit = new AjoutProduit();

        public Negosud()
        {
            InitializeComponent();
        }

        private void Negosud_Load(object sender, EventArgs e)
        {


        }



        private void Btn_Ajout_Client_Click(object sender, EventArgs e)
        {
            ajoutClient.Show();

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

        private void Btn_Ajour_Fournisseur_Click(object sender, EventArgs e)
        {

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
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            appel_Api("http://localhost:58841/api/Produits");
        }

        private void Btn_Ajout_Produit_Click_1(object sender, EventArgs e)
        {
            this.ajoutProduit.Show();
        }
    }
}

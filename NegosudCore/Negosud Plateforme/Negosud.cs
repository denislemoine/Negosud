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

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Gestion_Client.Visible = true;
            panel_Gestion_Produits.Visible = false;
            panel_Gestion_Fournisseur.Visible = false;
            panel_Gestion_Familles.Visible = false;
            appel_Api("http://localhost:58841/api/Clients");

        }
        private void familleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Gestion_Client.Visible = false;
            panel_Gestion_Produits.Visible = false;
            panel_Gestion_Fournisseur.Visible = false;
            panel_Gestion_Familles.Visible = true;
            appel_Api("http://localhost:58841/api/Familles");
        }
        private void fournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel_Gestion_Client.Visible = false;
            panel_Gestion_Produits.Visible = false;
            panel_Gestion_Fournisseur.Visible = true;
            panel_Gestion_Familles.Visible = false;
            appel_Api("http://localhost:58841/api/Fournisseurs");
        }
        private void produitsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_Gestion_Client.Visible = false;
            panel_Gestion_Produits.Visible = true;
            panel_Gestion_Fournisseur.Visible = false;
            panel_Gestion_Familles.Visible = false;
            appel_Api("http://localhost:58841/api/Produits");
        }

        private void dataGridView_Client_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_Ajout_Client_Click(object sender, EventArgs e)
        {
            ajoutClient.Show();

        }

        private void Btn_Ajout_Produit_Click(object sender, EventArgs e)
        {
            ajoutProduit.Show();
        }


        private void appel_Api(string url)
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

  
    }
}

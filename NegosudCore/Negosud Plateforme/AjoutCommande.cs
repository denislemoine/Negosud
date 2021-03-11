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
using System.Windows.Forms;

namespace Negosud_Plateforme
{
    public partial class AjoutCommande : Form
    {
        string produitSelect;
        int quantite;
        int Prix, prixTotal;
        long idSelect;
        Dictionary<string, int> listSelect = new Dictionary<string, int>();



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
                    prixTotal = (int)(Prix * quantite);
                    textBox_Prix_Total.Text = prixTotal.ToString() + " €";

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

            listSelect.Add(produitSelect + " x" + quantite.ToString(), prixTotal);
          
            dataGridView1.DataSource = (from d in listSelect orderby d.Value select new { d.Key, d.Value }).ToList();
        }

 
    }
}

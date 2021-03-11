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
            //else if (url == "http://localhost:58841/api/Fournisseurs")
            //{
            //    var webRequest = (HttpWebRequest)WebRequest.Create(url);
            //    var webResponse = (HttpWebResponse)webRequest.GetResponse();

            //    if ((webResponse.StatusCode == HttpStatusCode.OK))
            //    {
            //        var reader = new StreamReader(webResponse.GetResponseStream());
            //        string s = reader.ReadToEnd();
            //        var arr = JsonConvert.DeserializeObject<List<FournisseurDto>>(s);
            //        var list = new BindingList<FournisseurDto>(arr);
            //        var data = new BindingSource(list, null);
            //        comboBox1.DataSource = data.DataSource;
            //        comboBox1.DisplayMember = "nomEntreprise";
            //        comboBox1.ValueMember = "nomEntreprise";

            //    }
            //    else
            //    {
            //        MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
            //    }
            //}
        }
    }
}

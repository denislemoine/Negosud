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
    public partial class AjoutFamille : Form
    {
        private HttpWebRequest webRequest;
        public string libeleFamille;

        public AjoutFamille()
        {
            InitializeComponent();
        }

        private void button_Ajout_Produits_Click(object sender, EventArgs e)
        {
        
            string url = "http://localhost:58841/api/Familles";

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


            this.Close();


        }
        public string JsonTester()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new FamilleDto()
            {

                libelle = libeleFamille,
                isActive = true,

            };


            var result = ser.Serialize(jsonData);
            return result;
        }

        private void TxtBox_Nom_Famille_TextChanged(object sender, EventArgs e)
        {
            libeleFamille = TxtBox_Nom_Famille.Text;
        }
    }
}

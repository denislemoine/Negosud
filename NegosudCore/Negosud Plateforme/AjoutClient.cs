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
    public partial class AjoutClient : Form
    {
        private string nameClient;
        private string EmailClient;
        private string AdresseClient;
        private string TelClient;

        private HttpWebRequest webRequest;

        public AjoutClient()
        {
            InitializeComponent();
            
        }

        private void AjoutClient_Load(object sender, EventArgs e)
        {
            nameClient = TxtBox_Nom_Client.Text;
            EmailClient = TxtBox_Email_Client.Text;
            AdresseClient = TxtBox_Adresse_Client.Text;
            TelClient = TxtBox_Tel_Client.Text;
        }

        private void button_Ajout_Client_Click(object sender, EventArgs e)
        {

            string url = "http://localhost:58841/api/Clients";

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


            TxtBox_Email_Client.Text = null;
            TxtBox_Nom_Client.Text = null;
            TxtBox_Adresse_Client.Text = null;
            TxtBox_Tel_Client.Text = null;
            


            this.Close();


        }
        public string JsonTester()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ClientDto()
            {

                nom = nameClient,
                mail = EmailClient,
                Adresse = AdresseClient,
                tel = TelClient,
                isActive = true,
            };

            var result = ser.Serialize(jsonData);
            return result;
        }

        private void TxtBox_Nom_Client_TextChanged(object sender, EventArgs e)
        {
            nameClient = TxtBox_Nom_Client.Text;
        }

        private void TxtBox_Email_Client_TextChanged(object sender, EventArgs e)
        {
            EmailClient = TxtBox_Email_Client.Text;
        }

        private void TxtBox_Adresse_Client_TextChanged(object sender, EventArgs e)
        {
            AdresseClient = TxtBox_Adresse_Client.Text;
        }

        private void TxtBox_Tel_Client_TextChanged(object sender, EventArgs e)
        {
            TelClient = TxtBox_Tel_Client.Text;
        }
    }
} 

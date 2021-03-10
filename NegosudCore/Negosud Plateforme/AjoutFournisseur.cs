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
    public partial class AjoutFournisseur : Form
    {
        private string nameFournisseur;
        private string nameContactFournisseur;
        private string EmailFournisseur;
        private string AdresseFournisseur;
        private string TelFournisseur;

        private HttpWebRequest webRequest;

        public AjoutFournisseur()
        {
            InitializeComponent();
        }

        public string JsonTester()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new FournisseurDto()
            {
                mail = EmailFournisseur,
                nomEntreprise = nameFournisseur,
                nomContact = nameContactFournisseur,
                adresse = AdresseFournisseur,
                tel = TelFournisseur,
                isActive = true,
            };

            var result = ser.Serialize(jsonData);
            return result;
        }

        private void AjoutFournisseur_Load(object sender, EventArgs e)
        {
            nameFournisseur = TxtBox_Nom_Fournisseur.Text;
            nameContactFournisseur = TxtBox_Contact_Fournisseur.Text;
            EmailFournisseur = TxtBox_Email_Fournisseur.Text;
            AdresseFournisseur = TxtBox_Adresse_Fournisseur.Text;
            TelFournisseur = TxtBox_Tel_Fournisseur.Text;
        }

        private void button_Ajout_Fournisseur_Click(object sender, EventArgs e)
        {
            string url = "http://localhost:58841/api/Fournisseurs";

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

            TxtBox_Nom_Fournisseur.Text = null;
            TxtBox_Contact_Fournisseur.Text = null;
            TxtBox_Email_Fournisseur.Text = null;
            TxtBox_Adresse_Fournisseur.Text = null;
            TxtBox_Tel_Fournisseur.Text = null;

            this.Close();
        }

        private void TxtBox_Adresse_Fournisseur_TextChanged(object sender, EventArgs e)
        {
            AdresseFournisseur = TxtBox_Adresse_Fournisseur.Text;
        }

        private void TxtBox_Nom_Fournisseur_TextChanged(object sender, EventArgs e)
        {
            nameFournisseur = TxtBox_Nom_Fournisseur.Text;
        }

        private void TxtBox_Contact_Fournisseur_TextChanged(object sender, EventArgs e)
        {
            nameContactFournisseur = TxtBox_Contact_Fournisseur.Text;
        }

        private void TxtBox_Tel_Fournisseur_TextChanged(object sender, EventArgs e)
        {
            TelFournisseur = TxtBox_Tel_Fournisseur.Text;
        }

        private void TxtBox_Email_Fournisseur_TextChanged(object sender, EventArgs e)
        {
            EmailFournisseur = TxtBox_Email_Fournisseur.Text;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Negosud_Plateforme
{
    public partial class AjoutClient : Form
    {
        private string nameClient;
        private string EmailClient;
        private string AdresseClient;
        private string TelClient;


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
    }
}

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

        private void produitsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel_Gestion_Client.Visible = false;
            panel_Gestion_Produits.Visible = true;
        }
    }
}

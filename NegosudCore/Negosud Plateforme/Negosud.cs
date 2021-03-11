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
        AjoutFournisseur ajoutFournisseur = new AjoutFournisseur();
        AjoutCommande ajoutCommande = new AjoutCommande();

        private HttpWebRequest webRequest;

        string id;
        string libel;
        string IsActiv, commandeAuto;

        string idFamille;
        string nameProduit, millesimePorduit, descriptionProduit, domaineProduit, urlPhotoProduit, contenantProduit;
        String prixProduit, prixFournisseurProduit;

        private string idClient, nameClient, EmailClient, AdresseClient, TelClient;
        string idFournisseur, nomFournisseur, nomContact, adresseFournisseur, telFournisseur, mailFournisseur;

        string idStock,quantiteStockCommande, quantiteStock, idProduitStock;

        public string CelluleProduitValue { get; private set; }

        public Negosud()
        {
            InitializeComponent();
        }

        private void Negosud_Load(object sender, EventArgs e)
        {
            // Fonction qui fait appel à L'api, pour afficher les données dans les datagridview correspondantes
            appel_Api("http://localhost:58841/api/Fournisseurs");
            this.dataGridView_Fournisseurs.Columns["IsActive"].Visible = false;
            appel_Api("http://localhost:58841/api/Produits");
            this.dataGridView_Produits.Columns["IsActive"].Visible = false;
            appel_Api("http://localhost:58841/api/Clients");
            this.dataGridView_Client.Columns["IsActive"].Visible = false;
            appel_Api("http://localhost:58841/api/Familles");
            this.dataGridView_Familles.Columns["IsActive"].Visible = false;
            appel_Api("http://localhost:58841/api/CommandeInternes");
            appel_Api("http://localhost:58841/api/Stocks");
            this.dataGridView_Commandes.Columns["IsActive"].Visible = false;


            // Initialisation des combox avec l'api
            apiComboBOx("http://localhost:58841/api/Familles");
            apiComboBOx("http://localhost:58841/api/Fournisseurs");
        }
            

        private void button_Reload_Client_Click(object sender, EventArgs e)
        {

        }
        private void button_load_Click(object sender, EventArgs e)
        {
            appel_Api("http://localhost:58841/api/Produits");
            this.dataGridView_Produits.Columns["IsActive"].Visible = false;
        }

        private void apiComboBOx(string url)
        {
            if (url == "http://localhost:58841/api/Familles")
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
                        comboBox2.DataSource = data.DataSource;
                        comboBox2.DisplayMember = "libelle";
                        comboBox2.ValueMember = "libelle";

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
                    comboBox1.DataSource = data.DataSource;
                    comboBox1.DisplayMember = "nomEntreprise";
                    comboBox1.ValueMember = "nomEntreprise";

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }
            }
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
            else if (url == "http://localhost:58841/api/CommandeInternes")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<CommandeInterneDto>>(s);
                    var list = new BindingList<CommandeInterneDto>(arr);
                    var data = new BindingSource(list, null);
                    dataGridView_Commandes.DataSource = data;

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }

            }
            else if (url == "http://localhost:58841/api/Stocks")
            {
                var webRequest = (HttpWebRequest)WebRequest.Create(url);
                var webResponse = (HttpWebResponse)webRequest.GetResponse();

                if ((webResponse.StatusCode == HttpStatusCode.OK))
                {
                    var reader = new StreamReader(webResponse.GetResponseStream());
                    string s = reader.ReadToEnd();
                    var arr = JsonConvert.DeserializeObject<List<StockDto>>(s);
                    var list = new BindingList<StockDto>(arr);
                    var data = new BindingSource(list, null);
                    dataGridView_Stock.DataSource = data;

                }
                else
                {
                    MessageBox.Show(string.Format("Status code == {0}", webResponse.StatusCode));
                }

            }


        }

        private void Btn_Ajout_Client_Click(object sender, EventArgs e)
        {
            this.ajoutClient.Show();
           
        }

        private void Btn_Ajout_Produit_Click_1(object sender, EventArgs e)
        {
            this.ajoutProduit.Show();
        }

        private void Btn_Ajour_Famille_Click(object sender, EventArgs e)
        {
            this.ajoutFamille.Show();
        }

        private void button_reload_Famille_Click(object sender, EventArgs e)
        {
            this.appel_Api("http://localhost:58841/api/Familles");
        }


        // Boutton reload Fournisseurs
        private void button1_Click(object sender, EventArgs e)
        {
            this.appel_Api("http://localhost:58841/api/Fournisseurs");
        }
       
       
        // Boutton ajout Fournisseurs
        private void Btn_Ajour_Fournisseur_Click_1(object sender, EventArgs e)
        {
            this.ajoutFournisseur.Show();
        }   
        private void Btn_Ajout_Commande_Click(object sender, EventArgs e)
        {
            this.ajoutCommande.Show();
        }

        private void button_reload_Stock_Click(object sender, EventArgs e)
        {
            appel_Api("http://localhost:58841/api/Stocks");
        }

        

        // -------------------------------------------------------------------------------------------------//
        // Button avec fonction Supprimer
        // -------------------------------------------------------------------------------------------------//
        // Boutton suppression Fournisseurs
        private void btn_suppr_fournisseur_Click(object sender, EventArgs e)
        {
            if (dataGridView_Fournisseurs.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Fournisseurs.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Fournisseurs.Rows[selectedrowindex];

                idFournisseur = Convert.ToString(selectedRow.Cells["Id"].Value);
                nomFournisseur = Convert.ToString(selectedRow.Cells["nomEntreprise"].Value);
                nomContact = Convert.ToString(selectedRow.Cells["nomContact"].Value);
                adresseFournisseur = Convert.ToString(selectedRow.Cells["adresse"].Value);
                mailFournisseur = Convert.ToString(selectedRow.Cells["Mail"].Value);
                telFournisseur = Convert.ToString(selectedRow.Cells["tel"].Value);
                IsActiv = Convert.ToString(selectedRow.Cells["IsActive"].Value);
            }

            string url = "http://localhost:58841/api/Fournisseurs/" + idFournisseur;
            string requestParams = JsonFournisseurSuppr();

            webRequest = (HttpWebRequest)WebRequest.Create(url);
            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }
            MessageBox.Show("Vous avez suppprimé " + nomFournisseur);
            appel_Api("http://localhost:58841/api/Fournisseurs");
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            if (comboBox2.Items.ToString() != null)
            {
                var webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:58841/api/Familles");
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

        private void button_Suppr_Client_Click(object sender, EventArgs e)
        {
            if (dataGridView_Client.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Client.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Client.Rows[selectedrowindex];

                idClient = Convert.ToString(selectedRow.Cells["Id"].Value);
                nameClient = Convert.ToString(selectedRow.Cells["nom"].Value);
                EmailClient = Convert.ToString(selectedRow.Cells["mail"].Value);
                AdresseClient = Convert.ToString(selectedRow.Cells["adresse"].Value);
                TelClient = Convert.ToString(selectedRow.Cells["tel"].Value);
                IsActiv = Convert.ToString(selectedRow.Cells["IsActive"].Value);


            }

            string url = "http://localhost:58841/api/Clients/" + idClient;
            string requestParams = JsonClientSuppr();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }
            MessageBox.Show("Vous avez suppprimé " + nameClient);
            appel_Api("http://localhost:58841/api/Clients");
        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_Produits.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Produits.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Produits.Rows[selectedrowindex];

                id = Convert.ToString(selectedRow.Cells["Id"].Value);
                idFamille = Convert.ToString(selectedRow.Cells["idFamille"].Value);
                nameProduit = Convert.ToString(selectedRow.Cells["nom"].Value);
                millesimePorduit = Convert.ToString(selectedRow.Cells["millesime"].Value);
                prixProduit = Convert.ToString(selectedRow.Cells["prix"].Value);
                prixFournisseurProduit = Convert.ToString(selectedRow.Cells["prix"].Value);
                descriptionProduit = Convert.ToString(selectedRow.Cells["description"].Value);
                domaineProduit = Convert.ToString(selectedRow.Cells["domaine"].Value);
                urlPhotoProduit = Convert.ToString(selectedRow.Cells["urlPhoto"].Value);
                contenantProduit = Convert.ToString(selectedRow.Cells["contenant"].Value);
                IsActiv = Convert.ToString(selectedRow.Cells["IsActive"].Value);
                commandeAuto = Convert.ToString(selectedRow.Cells["commandeAuto"].Value);
            }

            string url = "http://localhost:58841/api/Produits/" + id;

            string requestParams = JsonProduitsSuppr();

            webRequest = (HttpWebRequest)WebRequest.Create(url);

            webRequest.Method = "PUT";
            webRequest.ContentType = "application/json";

            byte[] byteArray = Encoding.UTF8.GetBytes(requestParams);
            webRequest.ContentLength = byteArray.Length;
            using (Stream requestStream = webRequest.GetRequestStream())
            {
                requestStream.Write(byteArray, 0, byteArray.Length);
            }

            MessageBox.Show("Vous avez suppprimé " + nameProduit);
            appel_Api("http://localhost:58841/api/Produits");
        }
        private void button_Suppr_Click(object sender, EventArgs e)
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

            MessageBox.Show("Vous avez suppprimé " + libel);
            appel_Api("http://localhost:58841/api/Familles");
        }


        // -------------------------------------------------------------------------------------------------//
        // Button avec fonction modifier
        // -------------------------------------------------------------------------------------------------//
        // Boutton editer Fournisseurs
        private void btn_edit_fournisseur_Click(object sender, EventArgs e)
        {
            if (dataGridView_Fournisseurs.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Fournisseurs.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView_Fournisseurs.Rows[selectedrowindex];

                idFournisseur = Convert.ToString(selectedRow.Cells["Id"].Value);
                nomFournisseur = Convert.ToString(selectedRow.Cells["nomEntreprise"].Value);
                nomContact = Convert.ToString(selectedRow.Cells["nomContact"].Value);
                adresseFournisseur = Convert.ToString(selectedRow.Cells["adresse"].Value);
                mailFournisseur = Convert.ToString(selectedRow.Cells["mail"].Value);
                telFournisseur = Convert.ToString(selectedRow.Cells["tel"].Value);
                IsActiv = Convert.ToString(selectedRow.Cells["IsActive"].Value);
            }

            string url = "http://localhost:58841/api/Fournisseurs/" + idFournisseur;
            string requestParams = JsonFournisseurModif();

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
        private void button_Modif_Client_Click(object sender, EventArgs e)
        {
            if (dataGridView_Client.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Client.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Client.Rows[selectedrowindex];

                idClient = Convert.ToString(selectedRow.Cells["Id"].Value);
                nameClient = Convert.ToString(selectedRow.Cells["nom"].Value);
                EmailClient = Convert.ToString(selectedRow.Cells["mail"].Value);
                AdresseClient = Convert.ToString(selectedRow.Cells["adresse"].Value);
                TelClient = Convert.ToString(selectedRow.Cells["tel"].Value);
                IsActiv = Convert.ToString(selectedRow.Cells["IsActive"].Value);


            }

            string url = "http://localhost:58841/api/Clients/" + idClient;
            string requestParams = JsonClientModif();

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
        private void button_modif_Click(object sender, EventArgs e)
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
        private void button_modif_Produit_Click(object sender, EventArgs e)
        {
            if (dataGridView_Produits.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Produits.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Produits.Rows[selectedrowindex];

                id = Convert.ToString(selectedRow.Cells["Id"].Value);
                idFamille = Convert.ToString(selectedRow.Cells["idFamille"].Value);
                nameProduit = Convert.ToString(selectedRow.Cells["nom"].Value);
                millesimePorduit = Convert.ToString(selectedRow.Cells["millesime"].Value);
                prixProduit = Convert.ToString(selectedRow.Cells["prix"].Value);
                prixFournisseurProduit = Convert.ToString(selectedRow.Cells["prixFournisseur"].Value);
                descriptionProduit = Convert.ToString(selectedRow.Cells["description"].Value);
                domaineProduit = Convert.ToString(selectedRow.Cells["domaine"].Value);
                urlPhotoProduit = Convert.ToString(selectedRow.Cells["urlPhoto"].Value);
                contenantProduit = Convert.ToString(selectedRow.Cells["contenant"].Value);
                IsActiv = Convert.ToString(selectedRow.Cells["IsActive"].Value);
                commandeAuto = Convert.ToString(selectedRow.Cells["commandeAuto"].Value);
            }

            string url = "http://localhost:58841/api/Produits/" + id;
            string requestParams = JsonProduitsModif();

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
        private void button_Modifie_Stock_Click(object sender, EventArgs e)
        {
            if (dataGridView_Stock.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView_Stock.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView_Stock.Rows[selectedrowindex];

                idStock = Convert.ToString(selectedRow.Cells["id"].Value);
                idProduitStock = Convert.ToString(selectedRow.Cells["idProduit"].Value);
                quantiteStock = Convert.ToString(selectedRow.Cells["quantite"].Value);
                quantiteStockCommande = Convert.ToString(selectedRow.Cells["quantiteCommande"].Value);
               
            }

            string url = "http://localhost:58841/api/Stocks/" + idStock;
            string requestParams = JsonStockModif();

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

        // -------------------------------------------------------------------------------------------------//
        // Json pour les fonctions supprimmer
        // -------------------------------------------------------------------------------------------------//

        public string JsonClientSuppr()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ClientDto()
            {
                Id = Convert.ToInt64(idClient),
                nom = nameClient,
                mail = EmailClient,
                Adresse = AdresseClient,
                tel = TelClient,
                isActive = bool.Parse("false"),
            };

            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonProduitsSuppr()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ProduitDto()
            {
                id = Convert.ToInt64(id),
                idFamille = Convert.ToInt64(id),
                nom = nameProduit,
                millesime = millesimePorduit,
                prix = Convert.ToInt32(prixProduit),
                prixFournisseur = Convert.ToInt32(prixFournisseurProduit),
                description = descriptionProduit,
                domaine = domaineProduit,
                urlPhoto = urlPhotoProduit,
                contenant = contenantProduit,
                isActive = bool.Parse("false"),
                commandeAuto = bool.Parse(commandeAuto),

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
        public string JsonFournisseurSuppr()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();
            var jsonData = new FournisseurDto()
            {
                Id = Convert.ToInt64(idFournisseur),
                nomEntreprise = nomFournisseur,
                nomContact = nomContact,
                mail = mailFournisseur,
                adresse = adresseFournisseur,
                tel = telFournisseur,
                isActive = bool.Parse("false"),
            };

            var result = ser.Serialize(jsonData);
            return result;
        }


        // -------------------------------------------------------------------------------------------------//
        // Json pour les fonctions Modifier
        // -------------------------------------------------------------------------------------------------//
        public string JsonFournisseurModif()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new FournisseurDto()
            {
                Id = Convert.ToInt64(idFournisseur),
                nomEntreprise = nomFournisseur,
                nomContact = nomContact,
                mail = mailFournisseur,
                adresse = adresseFournisseur,
                tel = telFournisseur,
                isActive = bool.Parse(IsActiv),
            };

            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonClientModif()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ClientDto()
            {
                Id = Convert.ToInt64(idClient),
                nom = nameClient,
                mail = EmailClient,
                Adresse = AdresseClient,
                tel = TelClient,
                isActive = bool.Parse(IsActiv),
            };

            var result = ser.Serialize(jsonData);
            return result;
        }
        public string JsonProduitsModif()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new ProduitDto()
            {
                id = Convert.ToInt64(id),
                idFamille = Convert.ToInt64(idFamille),
                nom = nameProduit,
                millesime = millesimePorduit,
                prix = Convert.ToInt32(prixProduit),
                prixFournisseur = Convert.ToInt32(prixFournisseurProduit),
                description = descriptionProduit,
                domaine = domaineProduit,
                urlPhoto = urlPhotoProduit,
                contenant = contenantProduit,

                isActive = bool.Parse(IsActiv),
                commandeAuto = bool.Parse(commandeAuto),

            };

            var result = ser.Serialize(jsonData);
            return result;
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
        public string JsonStockModif()
        {
            JavaScriptSerializer ser = new JavaScriptSerializer();

            var jsonData = new StockDto()
            {
                id = Convert.ToInt64(idStock),
                idProduit = Convert.ToInt64(idProduitStock) ,
                quantite = Convert.ToInt32(quantiteStock),
                quantiteCommande = Convert.ToInt32(quantiteStockCommande),

            };

            var result = ser.Serialize(jsonData);
            return result;
        }

    }
}

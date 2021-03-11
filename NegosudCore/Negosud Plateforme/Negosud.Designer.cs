
namespace Negosud_Plateforme
{
    partial class Negosud
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Negosud));
            this.Btn_Ajout_Client = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView_Client = new System.Windows.Forms.DataGridView();
            this.dataGridView_Fournisseurs = new System.Windows.Forms.DataGridView();
            this.Btn_Ajour_Famille = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView_Familles = new System.Windows.Forms.DataGridView();
            this.dataGridView_Produits = new System.Windows.Forms.DataGridView();
            this.tabControl_Produit = new System.Windows.Forms.TabControl();
            this.tabPage_Produits = new System.Windows.Forms.TabPage();
            this.button_modif_Produit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button_Delete_Produit = new System.Windows.Forms.Button();
            this.Btn_Ajout_Produit = new System.Windows.Forms.Button();
            this.button_load = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fournisseurDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox_produits_name = new System.Windows.Forms.TextBox();
            this.label_Produits = new System.Windows.Forms.Label();
            this.tabPage_Fournisseurs = new System.Windows.Forms.TabPage();
            this.button_reloadFournisseur = new System.Windows.Forms.Button();
            this.Btn_Ajour_Fournisseur = new System.Windows.Forms.Button();
            this.label_Fournisseurs = new System.Windows.Forms.Label();
            this.tabPage_Clients = new System.Windows.Forms.TabPage();
            this.button_Modif_Client = new System.Windows.Forms.Button();
            this.button_Reload_Client = new System.Windows.Forms.Button();
            this.button_Suppr_Client = new System.Windows.Forms.Button();
            this.label_Clients = new System.Windows.Forms.Label();
            this.tabPage_Commandes = new System.Windows.Forms.TabPage();
            this.Btn_Ajout_Commande = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView_Commandes = new System.Windows.Forms.DataGridView();
            this.label_Commandes = new System.Windows.Forms.Label();
            this.tabPage_Familles = new System.Windows.Forms.TabPage();
            this.button_modif = new System.Windows.Forms.Button();
            this.button_reload_Famille = new System.Windows.Forms.Button();
            this.button_Suppr_Famille = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_suppr_fournisseur = new System.Windows.Forms.Button();
            this.btn_edit_fournisseur = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fournisseurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Familles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produits)).BeginInit();
            this.tabControl_Produit.SuspendLayout();
            this.tabPage_Produits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurDtoBindingSource)).BeginInit();
            this.tabPage_Fournisseurs.SuspendLayout();
            this.tabPage_Clients.SuspendLayout();
            this.tabPage_Commandes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Commandes)).BeginInit();
            this.tabPage_Familles.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Ajout_Client
            // 
            this.Btn_Ajout_Client.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Client.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Client.DisabledForeColor = System.Drawing.Color.Gray;
            this.Btn_Ajout_Client.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajout_Client.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_Ajout_Client.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_Ajout_Client.HoverTextColor = System.Drawing.Color.White;
            this.Btn_Ajout_Client.IsDerivedStyle = true;
            this.Btn_Ajout_Client.Location = new System.Drawing.Point(46, 93);
            this.Btn_Ajout_Client.Name = "Btn_Ajout_Client";
            this.Btn_Ajout_Client.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Client.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Client.NormalTextColor = System.Drawing.Color.White;
            this.Btn_Ajout_Client.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajout_Client.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajout_Client.PressTextColor = System.Drawing.Color.White;
            this.Btn_Ajout_Client.Size = new System.Drawing.Size(118, 45);
            this.Btn_Ajout_Client.Style = MetroSet_UI.Enums.Style.Custom;
            this.Btn_Ajout_Client.StyleManager = null;
            this.Btn_Ajout_Client.TabIndex = 1;
            this.Btn_Ajout_Client.Text = "Ajout Client";
            this.Btn_Ajout_Client.ThemeAuthor = "Narwin";
            this.Btn_Ajout_Client.ThemeName = "MetroDark";
            this.Btn_Ajout_Client.Click += new System.EventHandler(this.Btn_Ajout_Client_Click);
            // 
            // dataGridView_Client
            // 
            this.dataGridView_Client.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Client.Location = new System.Drawing.Point(0, 170);
            this.dataGridView_Client.Name = "dataGridView_Client";
            this.dataGridView_Client.Size = new System.Drawing.Size(555, 506);
            this.dataGridView_Client.TabIndex = 0;
            // 
            // dataGridView_Fournisseurs
            // 
            this.dataGridView_Fournisseurs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Fournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fournisseurs.Location = new System.Drawing.Point(3, 170);
            this.dataGridView_Fournisseurs.Name = "dataGridView_Fournisseurs";
            this.dataGridView_Fournisseurs.Size = new System.Drawing.Size(1073, 506);
            this.dataGridView_Fournisseurs.TabIndex = 1;
            // 
            // Btn_Ajour_Famille
            // 
            this.Btn_Ajour_Famille.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajour_Famille.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajour_Famille.DisabledForeColor = System.Drawing.Color.Gray;
            this.Btn_Ajour_Famille.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajour_Famille.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_Ajour_Famille.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_Ajour_Famille.HoverTextColor = System.Drawing.Color.White;
            this.Btn_Ajour_Famille.IsDerivedStyle = true;
            this.Btn_Ajour_Famille.Location = new System.Drawing.Point(26, 110);
            this.Btn_Ajour_Famille.Name = "Btn_Ajour_Famille";
            this.Btn_Ajour_Famille.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajour_Famille.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajour_Famille.NormalTextColor = System.Drawing.Color.White;
            this.Btn_Ajour_Famille.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajour_Famille.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajour_Famille.PressTextColor = System.Drawing.Color.White;
            this.Btn_Ajour_Famille.Size = new System.Drawing.Size(118, 45);
            this.Btn_Ajour_Famille.Style = MetroSet_UI.Enums.Style.Custom;
            this.Btn_Ajour_Famille.StyleManager = null;
            this.Btn_Ajour_Famille.TabIndex = 2;
            this.Btn_Ajour_Famille.Text = "Ajout Famille";
            this.Btn_Ajour_Famille.ThemeAuthor = "Narwin";
            this.Btn_Ajour_Famille.ThemeName = "MetroDark";
            this.Btn_Ajour_Famille.Click += new System.EventHandler(this.Btn_Ajour_Famille_Click);
            // 
            // dataGridView_Familles
            // 
            this.dataGridView_Familles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Familles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Familles.Location = new System.Drawing.Point(56, 194);
            this.dataGridView_Familles.Name = "dataGridView_Familles";
            this.dataGridView_Familles.Size = new System.Drawing.Size(336, 223);
            this.dataGridView_Familles.TabIndex = 1;
            // 
            // dataGridView_Produits
            // 
            this.dataGridView_Produits.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Produits.Location = new System.Drawing.Point(3, 170);
            this.dataGridView_Produits.Name = "dataGridView_Produits";
            this.dataGridView_Produits.Size = new System.Drawing.Size(1271, 506);
            this.dataGridView_Produits.TabIndex = 5;
            // 
            // tabControl_Produit
            // 
            this.tabControl_Produit.Controls.Add(this.tabPage_Produits);
            this.tabControl_Produit.Controls.Add(this.tabPage_Fournisseurs);
            this.tabControl_Produit.Controls.Add(this.tabPage_Clients);
            this.tabControl_Produit.Controls.Add(this.tabPage_Commandes);
            this.tabControl_Produit.Controls.Add(this.tabPage_Familles);
            this.tabControl_Produit.ImageList = this.imageList1;
            this.tabControl_Produit.Location = new System.Drawing.Point(1, 0);
            this.tabControl_Produit.Name = "tabControl_Produit";
            this.tabControl_Produit.SelectedIndex = 0;
            this.tabControl_Produit.Size = new System.Drawing.Size(1282, 764);
            this.tabControl_Produit.TabIndex = 6;
            // 
            // tabPage_Produits
            // 
            this.tabPage_Produits.Controls.Add(this.button_modif_Produit);
            this.tabPage_Produits.Controls.Add(this.label3);
            this.tabPage_Produits.Controls.Add(this.button_Delete_Produit);
            this.tabPage_Produits.Controls.Add(this.Btn_Ajout_Produit);
            this.tabPage_Produits.Controls.Add(this.button_load);
            this.tabPage_Produits.Controls.Add(this.button_Search);
            this.tabPage_Produits.Controls.Add(this.label2);
            this.tabPage_Produits.Controls.Add(this.label1);
            this.tabPage_Produits.Controls.Add(this.comboBox2);
            this.tabPage_Produits.Controls.Add(this.comboBox1);
            this.tabPage_Produits.Controls.Add(this.textBox_produits_name);
            this.tabPage_Produits.Controls.Add(this.label_Produits);
            this.tabPage_Produits.Controls.Add(this.dataGridView_Produits);
            this.tabPage_Produits.ImageIndex = 0;
            this.tabPage_Produits.Location = new System.Drawing.Point(4, 55);
            this.tabPage_Produits.Name = "tabPage_Produits";
            this.tabPage_Produits.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Produits.Size = new System.Drawing.Size(1274, 705);
            this.tabPage_Produits.TabIndex = 0;
            this.tabPage_Produits.UseVisualStyleBackColor = true;
            // 
            // button_modif_Produit
            // 
            this.button_modif_Produit.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.modifier;
            this.button_modif_Produit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_modif_Produit.FlatAppearance.BorderSize = 0;
            this.button_modif_Produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modif_Produit.Location = new System.Drawing.Point(782, 58);
            this.button_modif_Produit.Name = "button_modif_Produit";
            this.button_modif_Produit.Size = new System.Drawing.Size(58, 52);
            this.button_modif_Produit.TabIndex = 19;
            this.button_modif_Produit.UseVisualStyleBackColor = true;
            this.button_modif_Produit.Click += new System.EventHandler(this.button_modif_Produit_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // button_Delete_Produit
            // 
            this.button_Delete_Produit.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.Delete;
            this.button_Delete_Produit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Delete_Produit.FlatAppearance.BorderSize = 0;
            this.button_Delete_Produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete_Produit.Location = new System.Drawing.Point(720, 62);
            this.button_Delete_Produit.Name = "button_Delete_Produit";
            this.button_Delete_Produit.Size = new System.Drawing.Size(44, 39);
            this.button_Delete_Produit.TabIndex = 15;
            this.button_Delete_Produit.UseVisualStyleBackColor = true;
            this.button_Delete_Produit.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Btn_Ajout_Produit
            // 
            this.Btn_Ajout_Produit.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.add;
            this.Btn_Ajout_Produit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ajout_Produit.FlatAppearance.BorderSize = 0;
            this.Btn_Ajout_Produit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ajout_Produit.Location = new System.Drawing.Point(660, 62);
            this.Btn_Ajout_Produit.Name = "Btn_Ajout_Produit";
            this.Btn_Ajout_Produit.Size = new System.Drawing.Size(44, 39);
            this.Btn_Ajout_Produit.TabIndex = 14;
            this.Btn_Ajout_Produit.UseVisualStyleBackColor = true;
            this.Btn_Ajout_Produit.Click += new System.EventHandler(this.Btn_Ajout_Produit_Click_1);
            // 
            // button_load
            // 
            this.button_load.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.loading;
            this.button_load.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_load.FlatAppearance.BorderSize = 0;
            this.button_load.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_load.Location = new System.Drawing.Point(607, 63);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(40, 38);
            this.button_load.TabIndex = 13;
            this.button_load.UseVisualStyleBackColor = true;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_Search
            // 
            this.button_Search.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.search;
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Search.FlatAppearance.BorderSize = 0;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Search.Location = new System.Drawing.Point(554, 65);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(37, 38);
            this.button_Search.TabIndex = 12;
            this.button_Search.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Famille :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Fournisseur :";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(409, 74);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.fournisseurDtoBindingSource;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(248, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 8;
            // 
            // fournisseurDtoBindingSource
            // 
            this.fournisseurDtoBindingSource.DataSource = typeof(Negosud_Plateforme.FournisseurDto);
            // 
            // textBox_produits_name
            // 
            this.textBox_produits_name.Location = new System.Drawing.Point(54, 74);
            this.textBox_produits_name.Name = "textBox_produits_name";
            this.textBox_produits_name.Size = new System.Drawing.Size(147, 20);
            this.textBox_produits_name.TabIndex = 7;
            // 
            // label_Produits
            // 
            this.label_Produits.AutoSize = true;
            this.label_Produits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Produits.Location = new System.Drawing.Point(17, 15);
            this.label_Produits.Name = "label_Produits";
            this.label_Produits.Size = new System.Drawing.Size(86, 24);
            this.label_Produits.TabIndex = 6;
            this.label_Produits.Text = "Produits";
            // 
            // tabPage_Fournisseurs
            // 
            this.tabPage_Fournisseurs.Controls.Add(this.btn_edit_fournisseur);
            this.tabPage_Fournisseurs.Controls.Add(this.btn_suppr_fournisseur);
            this.tabPage_Fournisseurs.Controls.Add(this.button_reloadFournisseur);
            this.tabPage_Fournisseurs.Controls.Add(this.Btn_Ajour_Fournisseur);
            this.tabPage_Fournisseurs.Controls.Add(this.label_Fournisseurs);
            this.tabPage_Fournisseurs.Controls.Add(this.dataGridView_Fournisseurs);
            this.tabPage_Fournisseurs.ImageIndex = 1;
            this.tabPage_Fournisseurs.Location = new System.Drawing.Point(4, 55);
            this.tabPage_Fournisseurs.Name = "tabPage_Fournisseurs";
            this.tabPage_Fournisseurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Fournisseurs.Size = new System.Drawing.Size(1274, 705);
            this.tabPage_Fournisseurs.TabIndex = 1;
            this.tabPage_Fournisseurs.UseVisualStyleBackColor = true;
            // 
            // button_reloadFournisseur
            // 
            this.button_reloadFournisseur.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.loading;
            this.button_reloadFournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_reloadFournisseur.FlatAppearance.BorderSize = 0;
            this.button_reloadFournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reloadFournisseur.Location = new System.Drawing.Point(871, 93);
            this.button_reloadFournisseur.Name = "button_reloadFournisseur";
            this.button_reloadFournisseur.Size = new System.Drawing.Size(40, 38);
            this.button_reloadFournisseur.TabIndex = 16;
            this.button_reloadFournisseur.UseVisualStyleBackColor = true;
            this.button_reloadFournisseur.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Ajour_Fournisseur
            // 
            this.Btn_Ajour_Fournisseur.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.add;
            this.Btn_Ajour_Fournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Ajour_Fournisseur.FlatAppearance.BorderSize = 0;
            this.Btn_Ajour_Fournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Ajour_Fournisseur.Location = new System.Drawing.Point(917, 90);
            this.Btn_Ajour_Fournisseur.Name = "Btn_Ajour_Fournisseur";
            this.Btn_Ajour_Fournisseur.Size = new System.Drawing.Size(44, 41);
            this.Btn_Ajour_Fournisseur.TabIndex = 15;
            this.Btn_Ajour_Fournisseur.UseVisualStyleBackColor = true;
            this.Btn_Ajour_Fournisseur.Click += new System.EventHandler(this.Btn_Ajour_Fournisseur_Click_1);
            // 
            // label_Fournisseurs
            // 
            this.label_Fournisseurs.AutoSize = true;
            this.label_Fournisseurs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fournisseurs.Location = new System.Drawing.Point(7, 13);
            this.label_Fournisseurs.Name = "label_Fournisseurs";
            this.label_Fournisseurs.Size = new System.Drawing.Size(132, 24);
            this.label_Fournisseurs.TabIndex = 7;
            this.label_Fournisseurs.Text = "Fournisseurs";
            // 
            // tabPage_Clients
            // 
            this.tabPage_Clients.Controls.Add(this.button_Modif_Client);
            this.tabPage_Clients.Controls.Add(this.button_Reload_Client);
            this.tabPage_Clients.Controls.Add(this.button_Suppr_Client);
            this.tabPage_Clients.Controls.Add(this.label_Clients);
            this.tabPage_Clients.Controls.Add(this.Btn_Ajout_Client);
            this.tabPage_Clients.Controls.Add(this.dataGridView_Client);
            this.tabPage_Clients.ImageIndex = 2;
            this.tabPage_Clients.Location = new System.Drawing.Point(4, 55);
            this.tabPage_Clients.Name = "tabPage_Clients";
            this.tabPage_Clients.Size = new System.Drawing.Size(1274, 705);
            this.tabPage_Clients.TabIndex = 2;
            this.tabPage_Clients.UseVisualStyleBackColor = true;
            // 
            // button_Modif_Client
            // 
            this.button_Modif_Client.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.modifier;
            this.button_Modif_Client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Modif_Client.FlatAppearance.BorderSize = 0;
            this.button_Modif_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Modif_Client.Location = new System.Drawing.Point(359, 78);
            this.button_Modif_Client.Name = "button_Modif_Client";
            this.button_Modif_Client.Size = new System.Drawing.Size(71, 68);
            this.button_Modif_Client.TabIndex = 21;
            this.button_Modif_Client.UseVisualStyleBackColor = true;
            this.button_Modif_Client.Click += new System.EventHandler(this.button_Modif_Client_Click);
            // 
            // button_Reload_Client
            // 
            this.button_Reload_Client.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.loading;
            this.button_Reload_Client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Reload_Client.FlatAppearance.BorderSize = 0;
            this.button_Reload_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Reload_Client.Location = new System.Drawing.Point(301, 94);
            this.button_Reload_Client.Name = "button_Reload_Client";
            this.button_Reload_Client.Size = new System.Drawing.Size(40, 38);
            this.button_Reload_Client.TabIndex = 20;
            this.button_Reload_Client.UseVisualStyleBackColor = true;
            this.button_Reload_Client.Click += new System.EventHandler(this.button_Reload_Client_Click);
            // 
            // button_Suppr_Client
            // 
            this.button_Suppr_Client.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.Delete;
            this.button_Suppr_Client.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Suppr_Client.FlatAppearance.BorderSize = 0;
            this.button_Suppr_Client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Suppr_Client.Location = new System.Drawing.Point(223, 93);
            this.button_Suppr_Client.Name = "button_Suppr_Client";
            this.button_Suppr_Client.Size = new System.Drawing.Size(44, 39);
            this.button_Suppr_Client.TabIndex = 19;
            this.button_Suppr_Client.UseVisualStyleBackColor = true;
            this.button_Suppr_Client.Click += new System.EventHandler(this.button_Suppr_Client_Click);
            // 
            // label_Clients
            // 
            this.label_Clients.AutoSize = true;
            this.label_Clients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Clients.Location = new System.Drawing.Point(7, 19);
            this.label_Clients.Name = "label_Clients";
            this.label_Clients.Size = new System.Drawing.Size(73, 24);
            this.label_Clients.TabIndex = 7;
            this.label_Clients.Text = "Clients";
            // 
            // tabPage_Commandes
            // 
            this.tabPage_Commandes.Controls.Add(this.Btn_Ajout_Commande);
            this.tabPage_Commandes.Controls.Add(this.dataGridView_Commandes);
            this.tabPage_Commandes.Controls.Add(this.label_Commandes);
            this.tabPage_Commandes.ImageIndex = 3;
            this.tabPage_Commandes.Location = new System.Drawing.Point(4, 55);
            this.tabPage_Commandes.Name = "tabPage_Commandes";
            this.tabPage_Commandes.Size = new System.Drawing.Size(1274, 705);
            this.tabPage_Commandes.TabIndex = 3;
            this.tabPage_Commandes.UseVisualStyleBackColor = true;
            this.tabPage_Commandes.Click += new System.EventHandler(this.tabPage_Commandes_Click);
            // 
            // Btn_Ajout_Commande
            // 
            this.Btn_Ajout_Commande.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Commande.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Commande.DisabledForeColor = System.Drawing.Color.Gray;
            this.Btn_Ajout_Commande.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajout_Commande.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_Ajout_Commande.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_Ajout_Commande.HoverTextColor = System.Drawing.Color.White;
            this.Btn_Ajout_Commande.IsDerivedStyle = true;
            this.Btn_Ajout_Commande.Location = new System.Drawing.Point(32, 87);
            this.Btn_Ajout_Commande.Name = "Btn_Ajout_Commande";
            this.Btn_Ajout_Commande.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Commande.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Commande.NormalTextColor = System.Drawing.Color.White;
            this.Btn_Ajout_Commande.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajout_Commande.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajout_Commande.PressTextColor = System.Drawing.Color.White;
            this.Btn_Ajout_Commande.Size = new System.Drawing.Size(118, 45);
            this.Btn_Ajout_Commande.Style = MetroSet_UI.Enums.Style.Custom;
            this.Btn_Ajout_Commande.StyleManager = null;
            this.Btn_Ajout_Commande.TabIndex = 9;
            this.Btn_Ajout_Commande.Text = "Ajout Commande";
            this.Btn_Ajout_Commande.ThemeAuthor = "Narwin";
            this.Btn_Ajout_Commande.ThemeName = "MetroDark";
            this.Btn_Ajout_Commande.Click += new System.EventHandler(this.Btn_Ajout_Commande_Click);
            // 
            // dataGridView_Commandes
            // 
            this.dataGridView_Commandes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Commandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Commandes.Location = new System.Drawing.Point(3, 170);
            this.dataGridView_Commandes.Name = "dataGridView_Commandes";
            this.dataGridView_Commandes.Size = new System.Drawing.Size(524, 532);
            this.dataGridView_Commandes.TabIndex = 8;
            // 
            // label_Commandes
            // 
            this.label_Commandes.AutoSize = true;
            this.label_Commandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Commandes.Location = new System.Drawing.Point(7, 15);
            this.label_Commandes.Name = "label_Commandes";
            this.label_Commandes.Size = new System.Drawing.Size(127, 24);
            this.label_Commandes.TabIndex = 7;
            this.label_Commandes.Text = "Commandes";
            // 
            // tabPage_Familles
            // 
            this.tabPage_Familles.Controls.Add(this.button_modif);
            this.tabPage_Familles.Controls.Add(this.button_reload_Famille);
            this.tabPage_Familles.Controls.Add(this.button_Suppr_Famille);
            this.tabPage_Familles.Controls.Add(this.label4);
            this.tabPage_Familles.Controls.Add(this.Btn_Ajour_Famille);
            this.tabPage_Familles.Controls.Add(this.dataGridView_Familles);
            this.tabPage_Familles.ImageIndex = 4;
            this.tabPage_Familles.Location = new System.Drawing.Point(4, 55);
            this.tabPage_Familles.Name = "tabPage_Familles";
            this.tabPage_Familles.Size = new System.Drawing.Size(1274, 705);
            this.tabPage_Familles.TabIndex = 4;
            this.tabPage_Familles.UseVisualStyleBackColor = true;
            // 
            // button_modif
            // 
            this.button_modif.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.modifier;
            this.button_modif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_modif.FlatAppearance.BorderSize = 0;
            this.button_modif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_modif.Location = new System.Drawing.Point(321, 98);
            this.button_modif.Name = "button_modif";
            this.button_modif.Size = new System.Drawing.Size(71, 68);
            this.button_modif.TabIndex = 18;
            this.button_modif.UseVisualStyleBackColor = true;
            this.button_modif.Click += new System.EventHandler(this.button_modif_Click);
            // 
            // button_reload_Famille
            // 
            this.button_reload_Famille.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.loading;
            this.button_reload_Famille.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_reload_Famille.FlatAppearance.BorderSize = 0;
            this.button_reload_Famille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reload_Famille.Location = new System.Drawing.Point(263, 114);
            this.button_reload_Famille.Name = "button_reload_Famille";
            this.button_reload_Famille.Size = new System.Drawing.Size(40, 38);
            this.button_reload_Famille.TabIndex = 17;
            this.button_reload_Famille.UseVisualStyleBackColor = true;
            this.button_reload_Famille.Click += new System.EventHandler(this.button_reload_Famille_Click);
            // 
            // button_Suppr_Famille
            // 
            this.button_Suppr_Famille.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.Delete;
            this.button_Suppr_Famille.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Suppr_Famille.FlatAppearance.BorderSize = 0;
            this.button_Suppr_Famille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Suppr_Famille.Location = new System.Drawing.Point(187, 113);
            this.button_Suppr_Famille.Name = "button_Suppr_Famille";
            this.button_Suppr_Famille.Size = new System.Drawing.Size(44, 39);
            this.button_Suppr_Famille.TabIndex = 16;
            this.button_Suppr_Famille.UseVisualStyleBackColor = true;
            this.button_Suppr_Famille.Click += new System.EventHandler(this.button_Suppr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Famille";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "téléchargement.png");
            this.imageList1.Images.SetKeyName(1, "Fournisseur.jpg");
            this.imageList1.Images.SetKeyName(2, "Client.png");
            this.imageList1.Images.SetKeyName(3, "commande.png");
            this.imageList1.Images.SetKeyName(4, "type.jpg");
            // 
            // btn_suppr_fournisseur
            // 
            this.btn_suppr_fournisseur.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.Delete;
            this.btn_suppr_fournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_suppr_fournisseur.FlatAppearance.BorderSize = 0;
            this.btn_suppr_fournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_suppr_fournisseur.Location = new System.Drawing.Point(967, 93);
            this.btn_suppr_fournisseur.Name = "btn_suppr_fournisseur";
            this.btn_suppr_fournisseur.Size = new System.Drawing.Size(44, 39);
            this.btn_suppr_fournisseur.TabIndex = 17;
            this.btn_suppr_fournisseur.UseVisualStyleBackColor = true;
            this.btn_suppr_fournisseur.Click += new System.EventHandler(this.btn_suppr_fournisseur_Click);
            // 
            // btn_edit_fournisseur
            // 
            this.btn_edit_fournisseur.BackgroundImage = global::Negosud_Plateforme.Properties.Resources.modifier;
            this.btn_edit_fournisseur.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_edit_fournisseur.FlatAppearance.BorderSize = 0;
            this.btn_edit_fournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit_fournisseur.Location = new System.Drawing.Point(1017, 86);
            this.btn_edit_fournisseur.Name = "btn_edit_fournisseur";
            this.btn_edit_fournisseur.Size = new System.Drawing.Size(58, 52);
            this.btn_edit_fournisseur.TabIndex = 20;
            this.btn_edit_fournisseur.UseVisualStyleBackColor = true;
            this.btn_edit_fournisseur.Click += new System.EventHandler(this.btn_edit_fournisseur_Click);
            // 
            // Negosud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 761);
            this.Controls.Add(this.tabControl_Produit);
            this.Name = "Negosud";
            this.Text = "Négosud";
            this.Load += new System.EventHandler(this.Negosud_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fournisseurs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Familles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produits)).EndInit();
            this.tabControl_Produit.ResumeLayout(false);
            this.tabPage_Produits.ResumeLayout(false);
            this.tabPage_Produits.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fournisseurDtoBindingSource)).EndInit();
            this.tabPage_Fournisseurs.ResumeLayout(false);
            this.tabPage_Fournisseurs.PerformLayout();
            this.tabPage_Clients.ResumeLayout(false);
            this.tabPage_Clients.PerformLayout();
            this.tabPage_Commandes.ResumeLayout(false);
            this.tabPage_Commandes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Commandes)).EndInit();
            this.tabPage_Familles.ResumeLayout(false);
            this.tabPage_Familles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Client;
        private MetroSet_UI.Controls.MetroSetButton Btn_Ajout_Client;
        private System.Windows.Forms.DataGridView dataGridView_Produits;
        private System.Windows.Forms.DataGridView dataGridView_Fournisseurs;
        private MetroSet_UI.Controls.MetroSetButton Btn_Ajour_Famille;
        private System.Windows.Forms.DataGridView dataGridView_Familles;
        private System.Windows.Forms.TabControl tabControl_Produit;
        private System.Windows.Forms.TabPage tabPage_Produits;
        private System.Windows.Forms.TabPage tabPage_Fournisseurs;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabPage_Clients;
        private System.Windows.Forms.TabPage tabPage_Commandes;
        private System.Windows.Forms.TabPage tabPage_Familles;
        private System.Windows.Forms.Label label_Produits;
        private System.Windows.Forms.Label label_Fournisseurs;
        private System.Windows.Forms.Label label_Clients;
        private System.Windows.Forms.Label label_Commandes;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_produits_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button Btn_Ajout_Produit;
        private System.Windows.Forms.Button button_Delete_Produit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource fournisseurDtoBindingSource;
        private System.Windows.Forms.Button button_Suppr_Famille;
        private System.Windows.Forms.Button button_reload_Famille;
        private System.Windows.Forms.Button button_modif;
        private MetroSet_UI.Controls.MetroSetButton Btn_Ajout_Commande;
        private System.Windows.Forms.DataGridView dataGridView_Commandes;
        private System.Windows.Forms.Button button_modif_Produit;
        private System.Windows.Forms.Button button_Modif_Client;
        private System.Windows.Forms.Button button_Reload_Client;
        private System.Windows.Forms.Button button_Suppr_Client;
        private System.Windows.Forms.Button Btn_Ajour_Fournisseur;
        private System.Windows.Forms.Button button_reloadFournisseur;
        private System.Windows.Forms.Button btn_suppr_fournisseur;
        private System.Windows.Forms.Button btn_edit_fournisseur;
    }
}


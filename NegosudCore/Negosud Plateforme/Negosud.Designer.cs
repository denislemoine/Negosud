﻿
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.commandesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inventaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_Gestion_Client = new System.Windows.Forms.Panel();
            this.Btn_Ajout_Client = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView_Client = new System.Windows.Forms.DataGridView();
            this.panel_Gestion_Fournisseur = new System.Windows.Forms.Panel();
            this.Btn_Ajour_Fournisseur = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView_Fournisseurs = new System.Windows.Forms.DataGridView();
            this.panel_Gestion_Familles = new System.Windows.Forms.Panel();
            this.Btn_Ajour_Famille = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView_Familles = new System.Windows.Forms.DataGridView();
            this.panel_Gestion_Produits = new System.Windows.Forms.Panel();
            this.Btn_Ajout_Produit = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView_Produits = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroSetButton1 = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            this.panel_Gestion_Client.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).BeginInit();
            this.panel_Gestion_Fournisseur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fournisseurs)).BeginInit();
            this.panel_Gestion_Familles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Familles)).BeginInit();
            this.panel_Gestion_Produits.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produits)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.commandesToolStripMenuItem,
            this.inventaireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1318, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.fournisseursToolStripMenuItem,
            this.familleToolStripMenuItem,
            this.produitsToolStripMenuItem1});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientToolStripMenuItem.Text = "Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // fournisseursToolStripMenuItem
            // 
            this.fournisseursToolStripMenuItem.Name = "fournisseursToolStripMenuItem";
            this.fournisseursToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fournisseursToolStripMenuItem.Text = "Fournisseurs";
            this.fournisseursToolStripMenuItem.Click += new System.EventHandler(this.fournisseursToolStripMenuItem_Click);
            // 
            // familleToolStripMenuItem
            // 
            this.familleToolStripMenuItem.Name = "familleToolStripMenuItem";
            this.familleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.familleToolStripMenuItem.Text = "Familles";
            this.familleToolStripMenuItem.Click += new System.EventHandler(this.familleToolStripMenuItem_Click);
            // 
            // produitsToolStripMenuItem1
            // 
            this.produitsToolStripMenuItem1.Name = "produitsToolStripMenuItem1";
            this.produitsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.produitsToolStripMenuItem1.Text = "Produits";
            this.produitsToolStripMenuItem1.Click += new System.EventHandler(this.produitsToolStripMenuItem1_Click);
            // 
            // commandesToolStripMenuItem
            // 
            this.commandesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.fournisseursToolStripMenuItem1});
            this.commandesToolStripMenuItem.Name = "commandesToolStripMenuItem";
            this.commandesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.commandesToolStripMenuItem.Text = "Commandes";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            // 
            // fournisseursToolStripMenuItem1
            // 
            this.fournisseursToolStripMenuItem1.Name = "fournisseursToolStripMenuItem1";
            this.fournisseursToolStripMenuItem1.Size = new System.Drawing.Size(140, 22);
            this.fournisseursToolStripMenuItem1.Text = "Fournisseurs";
            // 
            // inventaireToolStripMenuItem
            // 
            this.inventaireToolStripMenuItem.Name = "inventaireToolStripMenuItem";
            this.inventaireToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.inventaireToolStripMenuItem.Text = "Inventaire";
            // 
            // panel_Gestion_Client
            // 
            this.panel_Gestion_Client.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Gestion_Client.Controls.Add(this.Btn_Ajout_Client);
            this.panel_Gestion_Client.Controls.Add(this.dataGridView_Client);
            this.panel_Gestion_Client.Location = new System.Drawing.Point(66, 39);
            this.panel_Gestion_Client.Name = "panel_Gestion_Client";
            this.panel_Gestion_Client.Size = new System.Drawing.Size(996, 600);
            this.panel_Gestion_Client.TabIndex = 1;
            this.panel_Gestion_Client.Visible = false;
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
            this.Btn_Ajout_Client.Location = new System.Drawing.Point(820, 45);
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
            this.dataGridView_Client.Location = new System.Drawing.Point(9, 13);
            this.dataGridView_Client.Name = "dataGridView_Client";
            this.dataGridView_Client.Size = new System.Drawing.Size(735, 561);
            this.dataGridView_Client.TabIndex = 0;
            this.dataGridView_Client.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Client_CellContentClick);
            // 
            // panel_Gestion_Fournisseur
            // 
            this.panel_Gestion_Fournisseur.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_Gestion_Fournisseur.Controls.Add(this.Btn_Ajour_Fournisseur);
            this.panel_Gestion_Fournisseur.Controls.Add(this.dataGridView_Fournisseurs);
            this.panel_Gestion_Fournisseur.Location = new System.Drawing.Point(26, 84);
            this.panel_Gestion_Fournisseur.Name = "panel_Gestion_Fournisseur";
            this.panel_Gestion_Fournisseur.Size = new System.Drawing.Size(986, 587);
            this.panel_Gestion_Fournisseur.TabIndex = 2;
            this.panel_Gestion_Fournisseur.Visible = false;
            // 
            // Btn_Ajour_Fournisseur
            // 
            this.Btn_Ajour_Fournisseur.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajour_Fournisseur.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajour_Fournisseur.DisabledForeColor = System.Drawing.Color.Gray;
            this.Btn_Ajour_Fournisseur.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajour_Fournisseur.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_Ajour_Fournisseur.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_Ajour_Fournisseur.HoverTextColor = System.Drawing.Color.White;
            this.Btn_Ajour_Fournisseur.IsDerivedStyle = true;
            this.Btn_Ajour_Fournisseur.Location = new System.Drawing.Point(832, 66);
            this.Btn_Ajour_Fournisseur.Name = "Btn_Ajour_Fournisseur";
            this.Btn_Ajour_Fournisseur.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajour_Fournisseur.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajour_Fournisseur.NormalTextColor = System.Drawing.Color.White;
            this.Btn_Ajour_Fournisseur.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajour_Fournisseur.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajour_Fournisseur.PressTextColor = System.Drawing.Color.White;
            this.Btn_Ajour_Fournisseur.Size = new System.Drawing.Size(118, 45);
            this.Btn_Ajour_Fournisseur.Style = MetroSet_UI.Enums.Style.Custom;
            this.Btn_Ajour_Fournisseur.StyleManager = null;
            this.Btn_Ajour_Fournisseur.TabIndex = 2;
            this.Btn_Ajour_Fournisseur.Text = "Ajout Fournisseur";
            this.Btn_Ajour_Fournisseur.ThemeAuthor = "Narwin";
            this.Btn_Ajour_Fournisseur.ThemeName = "MetroDark";
            this.Btn_Ajour_Fournisseur.Click += new System.EventHandler(this.Btn_Ajour_Fournisseur_Click);
            // 
            // dataGridView_Fournisseurs
            // 
            this.dataGridView_Fournisseurs.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Fournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Fournisseurs.Location = new System.Drawing.Point(21, 34);
            this.dataGridView_Fournisseurs.Name = "dataGridView_Fournisseurs";
            this.dataGridView_Fournisseurs.Size = new System.Drawing.Size(735, 539);
            this.dataGridView_Fournisseurs.TabIndex = 1;
            // 
            // panel_Gestion_Familles
            // 
            this.panel_Gestion_Familles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel_Gestion_Familles.Controls.Add(this.Btn_Ajour_Famille);
            this.panel_Gestion_Familles.Controls.Add(this.dataGridView_Familles);
            this.panel_Gestion_Familles.Location = new System.Drawing.Point(54, 52);
            this.panel_Gestion_Familles.Name = "panel_Gestion_Familles";
            this.panel_Gestion_Familles.Size = new System.Drawing.Size(995, 595);
            this.panel_Gestion_Familles.TabIndex = 3;
            this.panel_Gestion_Familles.Visible = false;
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
            this.Btn_Ajour_Famille.Location = new System.Drawing.Point(832, 32);
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
            // 
            // dataGridView_Familles
            // 
            this.dataGridView_Familles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Familles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Familles.Location = new System.Drawing.Point(12, 7);
            this.dataGridView_Familles.Name = "dataGridView_Familles";
            this.dataGridView_Familles.Size = new System.Drawing.Size(735, 561);
            this.dataGridView_Familles.TabIndex = 1;
            // 
            // panel_Gestion_Produits
            // 
            this.panel_Gestion_Produits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel_Gestion_Produits.Controls.Add(this.Btn_Ajout_Produit);
            this.panel_Gestion_Produits.Controls.Add(this.dataGridView_Produits);
            this.panel_Gestion_Produits.Location = new System.Drawing.Point(0, 237);
            this.panel_Gestion_Produits.Name = "panel_Gestion_Produits";
            this.panel_Gestion_Produits.Size = new System.Drawing.Size(991, 589);
            this.panel_Gestion_Produits.TabIndex = 4;
            this.panel_Gestion_Produits.Visible = false;
            // 
            // Btn_Ajout_Produit
            // 
            this.Btn_Ajout_Produit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Produit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Produit.DisabledForeColor = System.Drawing.Color.Gray;
            this.Btn_Ajout_Produit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajout_Produit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_Ajout_Produit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.Btn_Ajout_Produit.HoverTextColor = System.Drawing.Color.White;
            this.Btn_Ajout_Produit.IsDerivedStyle = true;
            this.Btn_Ajout_Produit.Location = new System.Drawing.Point(820, 30);
            this.Btn_Ajout_Produit.Name = "Btn_Ajout_Produit";
            this.Btn_Ajout_Produit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Produit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Produit.NormalTextColor = System.Drawing.Color.White;
            this.Btn_Ajout_Produit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajout_Produit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajout_Produit.PressTextColor = System.Drawing.Color.White;
            this.Btn_Ajout_Produit.Size = new System.Drawing.Size(118, 45);
            this.Btn_Ajout_Produit.Style = MetroSet_UI.Enums.Style.Custom;
            this.Btn_Ajout_Produit.StyleManager = null;
            this.Btn_Ajout_Produit.TabIndex = 5;
            this.Btn_Ajout_Produit.Text = "Ajout Produit";
            this.Btn_Ajout_Produit.ThemeAuthor = "Narwin";
            this.Btn_Ajout_Produit.ThemeName = "MetroDark";
            this.Btn_Ajout_Produit.Click += new System.EventHandler(this.Btn_Ajout_Produit_Click);
            // 
            // dataGridView_Produits
            // 
            this.dataGridView_Produits.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView_Produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Produits.Location = new System.Drawing.Point(9, 15);
            this.dataGridView_Produits.Name = "dataGridView_Produits";
            this.dataGridView_Produits.Size = new System.Drawing.Size(735, 486);
            this.dataGridView_Produits.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.metroSetButton1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(988, 688);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(991, 589);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // metroSetButton1
            // 
            this.metroSetButton1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.DisabledForeColor = System.Drawing.Color.Gray;
            this.metroSetButton1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetButton1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.metroSetButton1.HoverTextColor = System.Drawing.Color.White;
            this.metroSetButton1.IsDerivedStyle = true;
            this.metroSetButton1.Location = new System.Drawing.Point(820, 30);
            this.metroSetButton1.Name = "metroSetButton1";
            this.metroSetButton1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.metroSetButton1.NormalTextColor = System.Drawing.Color.White;
            this.metroSetButton1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.metroSetButton1.PressTextColor = System.Drawing.Color.White;
            this.metroSetButton1.Size = new System.Drawing.Size(118, 45);
            this.metroSetButton1.Style = MetroSet_UI.Enums.Style.Custom;
            this.metroSetButton1.StyleManager = null;
            this.metroSetButton1.TabIndex = 5;
            this.metroSetButton1.Text = "Ajout Produit";
            this.metroSetButton1.ThemeAuthor = "Narwin";
            this.metroSetButton1.ThemeName = "MetroDark";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 486);
            this.dataGridView1.TabIndex = 5;
            // 
            // Negosud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 750);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Gestion_Produits);
            this.Controls.Add(this.panel_Gestion_Fournisseur);
            this.Controls.Add(this.panel_Gestion_Familles);
            this.Controls.Add(this.panel_Gestion_Client);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Negosud";
            this.Text = "Négosud";
            this.Load += new System.EventHandler(this.Negosud_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_Gestion_Client.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).EndInit();
            this.panel_Gestion_Fournisseur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fournisseurs)).EndInit();
            this.panel_Gestion_Familles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Familles)).EndInit();
            this.panel_Gestion_Produits.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produits)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commandesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inventaireToolStripMenuItem;
        private System.Windows.Forms.Panel panel_Gestion_Client;
        private System.Windows.Forms.Panel panel_Gestion_Fournisseur;
        private System.Windows.Forms.Panel panel_Gestion_Familles;
        private System.Windows.Forms.Panel panel_Gestion_Produits;
        private System.Windows.Forms.DataGridView dataGridView_Client;
        private MetroSet_UI.Controls.MetroSetButton Btn_Ajout_Client;
        private MetroSet_UI.Controls.MetroSetButton Btn_Ajout_Produit;
        private System.Windows.Forms.DataGridView dataGridView_Produits;
        private MetroSet_UI.Controls.MetroSetButton Btn_Ajour_Fournisseur;
        private System.Windows.Forms.DataGridView dataGridView_Fournisseurs;
        private MetroSet_UI.Controls.MetroSetButton Btn_Ajour_Famille;
        private System.Windows.Forms.DataGridView dataGridView_Familles;
        private System.Windows.Forms.Panel panel1;
        private MetroSet_UI.Controls.MetroSetButton metroSetButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


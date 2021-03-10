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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Negosud));
            this.Btn_Ajout_Client = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView_Client = new System.Windows.Forms.DataGridView();
            this.Btn_Ajour_Fournisseur = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView_Fournisseurs = new System.Windows.Forms.DataGridView();
            this.Btn_Ajour_Famille = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView_Familles = new System.Windows.Forms.DataGridView();
            this.Btn_Ajout_Produit = new MetroSet_UI.Controls.MetroSetButton();
            this.dataGridView_Produits = new System.Windows.Forms.DataGridView();
            this.tabControl_Produit = new System.Windows.Forms.TabControl();
            this.tabPage_Produits = new System.Windows.Forms.TabPage();
            this.tabPage_Fournisseurs = new System.Windows.Forms.TabPage();
            this.tabPage_Clients = new System.Windows.Forms.TabPage();
            this.tabPage_Commandes = new System.Windows.Forms.TabPage();
            this.tabPage_Familles = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label_Produits = new System.Windows.Forms.Label();
            this.label_Fournisseurs = new System.Windows.Forms.Label();
            this.label_Clients = new System.Windows.Forms.Label();
            this.label_Commandes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Client)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Fournisseurs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Familles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Produits)).BeginInit();
            this.tabControl_Produit.SuspendLayout();
            this.tabPage_Produits.SuspendLayout();
            this.tabPage_Fournisseurs.SuspendLayout();
            this.tabPage_Clients.SuspendLayout();
            this.tabPage_Commandes.SuspendLayout();
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
            this.Btn_Ajout_Client.Location = new System.Drawing.Point(572, 19);
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
            this.dataGridView_Client.Size = new System.Drawing.Size(1076, 506);
            this.dataGridView_Client.TabIndex = 0;
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
            this.Btn_Ajour_Fournisseur.Location = new System.Drawing.Point(448, 50);
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
            this.Btn_Ajour_Famille.Location = new System.Drawing.Point(482, 80);
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
            this.dataGridView_Familles.Location = new System.Drawing.Point(0, 170);
            this.dataGridView_Familles.Name = "dataGridView_Familles";
            this.dataGridView_Familles.Size = new System.Drawing.Size(1076, 535);
            this.dataGridView_Familles.TabIndex = 1;
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
            this.Btn_Ajout_Produit.Location = new System.Drawing.Point(485, 64);
            this.Btn_Ajout_Produit.Name = "Btn_Ajout_Produit";
            this.Btn_Ajout_Produit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Produit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.Btn_Ajout_Produit.NormalTextColor = System.Drawing.Color.White;
            this.Btn_Ajout_Produit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajout_Produit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.Btn_Ajout_Produit.PressTextColor = System.Drawing.Color.White;
            this.Btn_Ajout_Produit.Size = new System.Drawing.Size(90, 30);
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
            this.dataGridView_Produits.Location = new System.Drawing.Point(3, 170);
            this.dataGridView_Produits.Name = "dataGridView_Produits";
            this.dataGridView_Produits.Size = new System.Drawing.Size(1073, 506);
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
            this.tabControl_Produit.Size = new System.Drawing.Size(1084, 764);
            this.tabControl_Produit.TabIndex = 6;
            // 
            // tabPage_Produits
            // 
            this.tabPage_Produits.Controls.Add(this.label_Produits);
            this.tabPage_Produits.Controls.Add(this.Btn_Ajout_Produit);
            this.tabPage_Produits.Controls.Add(this.dataGridView_Produits);
            this.tabPage_Produits.ImageIndex = 0;
            this.tabPage_Produits.Location = new System.Drawing.Point(4, 55);
            this.tabPage_Produits.Name = "tabPage_Produits";
            this.tabPage_Produits.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Produits.Size = new System.Drawing.Size(1076, 705);
            this.tabPage_Produits.TabIndex = 0;
            this.tabPage_Produits.UseVisualStyleBackColor = true;
            this.tabPage_Produits.Click += new System.EventHandler(this.tabPage_Produits_Click);
            // 
            // tabPage_Fournisseurs
            // 
            this.tabPage_Fournisseurs.Controls.Add(this.label_Fournisseurs);
            this.tabPage_Fournisseurs.Controls.Add(this.Btn_Ajour_Fournisseur);
            this.tabPage_Fournisseurs.Controls.Add(this.dataGridView_Fournisseurs);
            this.tabPage_Fournisseurs.ImageIndex = 1;
            this.tabPage_Fournisseurs.Location = new System.Drawing.Point(4, 55);
            this.tabPage_Fournisseurs.Name = "tabPage_Fournisseurs";
            this.tabPage_Fournisseurs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Fournisseurs.Size = new System.Drawing.Size(1076, 705);
            this.tabPage_Fournisseurs.TabIndex = 1;
            this.tabPage_Fournisseurs.UseVisualStyleBackColor = true;
            this.tabPage_Fournisseurs.Click += new System.EventHandler(this.tabPage_Fournisseurs_Click);
            // 
            // tabPage_Clients
            // 
            this.tabPage_Clients.Controls.Add(this.label_Clients);
            this.tabPage_Clients.Controls.Add(this.Btn_Ajout_Client);
            this.tabPage_Clients.Controls.Add(this.dataGridView_Client);
            this.tabPage_Clients.ImageIndex = 2;
            this.tabPage_Clients.Location = new System.Drawing.Point(4, 55);
            this.tabPage_Clients.Name = "tabPage_Clients";
            this.tabPage_Clients.Size = new System.Drawing.Size(1076, 705);
            this.tabPage_Clients.TabIndex = 2;
            this.tabPage_Clients.UseVisualStyleBackColor = true;
            this.tabPage_Clients.Click += new System.EventHandler(this.tabPage_Clients_Click);
            // 
            // tabPage_Commandes
            // 
            this.tabPage_Commandes.Controls.Add(this.label_Commandes);
            this.tabPage_Commandes.ImageIndex = 3;
            this.tabPage_Commandes.Location = new System.Drawing.Point(4, 55);
            this.tabPage_Commandes.Name = "tabPage_Commandes";
            this.tabPage_Commandes.Size = new System.Drawing.Size(1076, 705);
            this.tabPage_Commandes.TabIndex = 3;
            this.tabPage_Commandes.UseVisualStyleBackColor = true;
            // 
            // tabPage_Familles
            // 
            this.tabPage_Familles.Controls.Add(this.Btn_Ajour_Famille);
            this.tabPage_Familles.Controls.Add(this.dataGridView_Familles);
            this.tabPage_Familles.ImageIndex = 4;
            this.tabPage_Familles.Location = new System.Drawing.Point(4, 55);
            this.tabPage_Familles.Name = "tabPage_Familles";
            this.tabPage_Familles.Size = new System.Drawing.Size(1076, 705);
            this.tabPage_Familles.TabIndex = 4;
            this.tabPage_Familles.UseVisualStyleBackColor = true;
            this.tabPage_Familles.Click += new System.EventHandler(this.tabPage_Familles_Click);
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
            // label_Produits
            // 
            this.label_Produits.AutoSize = true;
            this.label_Produits.Font = new System.Drawing.Font("Verdana Pro Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Produits.Location = new System.Drawing.Point(17, 15);
            this.label_Produits.Name = "label_Produits";
            this.label_Produits.Size = new System.Drawing.Size(94, 23);
            this.label_Produits.TabIndex = 6;
            this.label_Produits.Text = "Produits";
            // 
            // label_Fournisseurs
            // 
            this.label_Fournisseurs.AutoSize = true;
            this.label_Fournisseurs.Font = new System.Drawing.Font("Verdana Pro Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Fournisseurs.Location = new System.Drawing.Point(7, 13);
            this.label_Fournisseurs.Name = "label_Fournisseurs";
            this.label_Fournisseurs.Size = new System.Drawing.Size(142, 23);
            this.label_Fournisseurs.TabIndex = 7;
            this.label_Fournisseurs.Text = "Fournisseurs";
            // 
            // label_Clients
            // 
            this.label_Clients.AutoSize = true;
            this.label_Clients.Font = new System.Drawing.Font("Verdana Pro Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Clients.Location = new System.Drawing.Point(7, 19);
            this.label_Clients.Name = "label_Clients";
            this.label_Clients.Size = new System.Drawing.Size(80, 23);
            this.label_Clients.TabIndex = 7;
            this.label_Clients.Text = "Clients";
            // 
            // label_Commandes
            // 
            this.label_Commandes.AutoSize = true;
            this.label_Commandes.Font = new System.Drawing.Font("Verdana Pro Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Commandes.Location = new System.Drawing.Point(7, 15);
            this.label_Commandes.Name = "label_Commandes";
            this.label_Commandes.Size = new System.Drawing.Size(134, 23);
            this.label_Commandes.TabIndex = 7;
            this.label_Commandes.Text = "Commandes";
            // 
            // Negosud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 761);
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
            this.tabPage_Fournisseurs.ResumeLayout(false);
            this.tabPage_Fournisseurs.PerformLayout();
            this.tabPage_Clients.ResumeLayout(false);
            this.tabPage_Clients.PerformLayout();
            this.tabPage_Commandes.ResumeLayout(false);
            this.tabPage_Commandes.PerformLayout();
            this.tabPage_Familles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView_Client;
        private MetroSet_UI.Controls.MetroSetButton Btn_Ajout_Client;
        private MetroSet_UI.Controls.MetroSetButton Btn_Ajout_Produit;
        private System.Windows.Forms.DataGridView dataGridView_Produits;
        private MetroSet_UI.Controls.MetroSetButton Btn_Ajour_Fournisseur;
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
    }
}


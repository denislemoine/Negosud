
namespace Negosud_Plateforme
{
    partial class AjoutProduit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtBox_Nom_Produit = new System.Windows.Forms.TextBox();
            this.Label_Nom = new MetroSet_UI.Controls.MetroSetLabel();
            this.comboBox_Fournisseur = new System.Windows.Forms.ComboBox();
            this.Label_fournisseur = new MetroSet_UI.Controls.MetroSetLabel();
            this.Label_famille = new MetroSet_UI.Controls.MetroSetLabel();
            this.comboBox_Famille = new System.Windows.Forms.ComboBox();
            this.TxtBox_Millesime_Produit = new System.Windows.Forms.TextBox();
            this.Label_millesime = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtBox_Domaine = new System.Windows.Forms.TextBox();
            this.Label_Domaine = new MetroSet_UI.Controls.MetroSetLabel();
            this.Label_Description = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtBox_Description = new System.Windows.Forms.TextBox();
            this.Label_Url_Photo = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtBox_URL_Photo = new System.Windows.Forms.TextBox();
            this.Label_Contenant = new MetroSet_UI.Controls.MetroSetLabel();
            this.TxtBox_Contenant = new System.Windows.Forms.TextBox();
            this.button_Ajout_Produits = new System.Windows.Forms.Button();
            this.textBox_Prix = new System.Windows.Forms.TextBox();
            this.Label_Prix = new MetroSet_UI.Controls.MetroSetLabel();
            this.textBox_Prix_Fournisseur = new System.Windows.Forms.TextBox();
            this.Label_Prix_Fournisseur = new MetroSet_UI.Controls.MetroSetLabel();
            this.SuspendLayout();
            // 
            // TxtBox_Nom_Produit
            // 
            this.TxtBox_Nom_Produit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Nom_Produit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Nom_Produit.Location = new System.Drawing.Point(215, 4);
            this.TxtBox_Nom_Produit.MaxLength = 20;
            this.TxtBox_Nom_Produit.Name = "TxtBox_Nom_Produit";
            this.TxtBox_Nom_Produit.Size = new System.Drawing.Size(164, 26);
            this.TxtBox_Nom_Produit.TabIndex = 7;
            this.TxtBox_Nom_Produit.TextChanged += new System.EventHandler(this.TxtBox_Nom_Produit_TextChanged);
            // 
            // Label_Nom
            // 
            this.Label_Nom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nom.IsDerivedStyle = true;
            this.Label_Nom.Location = new System.Drawing.Point(118, 9);
            this.Label_Nom.Name = "Label_Nom";
            this.Label_Nom.Size = new System.Drawing.Size(52, 23);
            this.Label_Nom.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Nom.StyleManager = null;
            this.Label_Nom.TabIndex = 6;
            this.Label_Nom.Text = "Nom : ";
            this.Label_Nom.ThemeAuthor = "Narwin";
            this.Label_Nom.ThemeName = "MetroLite";
            // 
            // comboBox_Fournisseur
            // 
            this.comboBox_Fournisseur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Fournisseur.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Fournisseur.FormattingEnabled = true;
            this.comboBox_Fournisseur.Location = new System.Drawing.Point(215, 49);
            this.comboBox_Fournisseur.Name = "comboBox_Fournisseur";
            this.comboBox_Fournisseur.Size = new System.Drawing.Size(164, 24);
            this.comboBox_Fournisseur.TabIndex = 8;
            // 
            // Label_fournisseur
            // 
            this.Label_fournisseur.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_fournisseur.IsDerivedStyle = true;
            this.Label_fournisseur.Location = new System.Drawing.Point(64, 49);
            this.Label_fournisseur.Name = "Label_fournisseur";
            this.Label_fournisseur.Size = new System.Drawing.Size(106, 23);
            this.Label_fournisseur.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_fournisseur.StyleManager = null;
            this.Label_fournisseur.TabIndex = 9;
            this.Label_fournisseur.Text = "Fournisseur : ";
            this.Label_fournisseur.ThemeAuthor = "Narwin";
            this.Label_fournisseur.ThemeName = "MetroLite";
            // 
            // Label_famille
            // 
            this.Label_famille.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_famille.IsDerivedStyle = true;
            this.Label_famille.Location = new System.Drawing.Point(95, 83);
            this.Label_famille.Name = "Label_famille";
            this.Label_famille.Size = new System.Drawing.Size(75, 23);
            this.Label_famille.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_famille.StyleManager = null;
            this.Label_famille.TabIndex = 11;
            this.Label_famille.Text = "Famille : ";
            this.Label_famille.ThemeAuthor = "Narwin";
            this.Label_famille.ThemeName = "MetroLite";
            // 
            // comboBox_Famille
            // 
            this.comboBox_Famille.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Famille.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Famille.FormattingEnabled = true;
            this.comboBox_Famille.Location = new System.Drawing.Point(215, 83);
            this.comboBox_Famille.Name = "comboBox_Famille";
            this.comboBox_Famille.Size = new System.Drawing.Size(164, 24);
            this.comboBox_Famille.TabIndex = 10;
            // 
            // TxtBox_Millesime_Produit
            // 
            this.TxtBox_Millesime_Produit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Millesime_Produit.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Millesime_Produit.Location = new System.Drawing.Point(215, 113);
            this.TxtBox_Millesime_Produit.MaxLength = 20;
            this.TxtBox_Millesime_Produit.Name = "TxtBox_Millesime_Produit";
            this.TxtBox_Millesime_Produit.Size = new System.Drawing.Size(164, 26);
            this.TxtBox_Millesime_Produit.TabIndex = 13;
            this.TxtBox_Millesime_Produit.TextChanged += new System.EventHandler(this.TxtBox_Millesime_Produit_TextChanged);
            // 
            // Label_millesime
            // 
            this.Label_millesime.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_millesime.IsDerivedStyle = true;
            this.Label_millesime.Location = new System.Drawing.Point(80, 118);
            this.Label_millesime.Name = "Label_millesime";
            this.Label_millesime.Size = new System.Drawing.Size(90, 23);
            this.Label_millesime.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_millesime.StyleManager = null;
            this.Label_millesime.TabIndex = 12;
            this.Label_millesime.Text = "Millésime : ";
            this.Label_millesime.ThemeAuthor = "Narwin";
            this.Label_millesime.ThemeName = "MetroLite";
            // 
            // TxtBox_Domaine
            // 
            this.TxtBox_Domaine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Domaine.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Domaine.Location = new System.Drawing.Point(215, 152);
            this.TxtBox_Domaine.MaxLength = 20;
            this.TxtBox_Domaine.Name = "TxtBox_Domaine";
            this.TxtBox_Domaine.Size = new System.Drawing.Size(164, 26);
            this.TxtBox_Domaine.TabIndex = 15;
            this.TxtBox_Domaine.TextChanged += new System.EventHandler(this.TxtBox_Domaine_TextChanged);
            // 
            // Label_Domaine
            // 
            this.Label_Domaine.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Domaine.IsDerivedStyle = true;
            this.Label_Domaine.Location = new System.Drawing.Point(80, 157);
            this.Label_Domaine.Name = "Label_Domaine";
            this.Label_Domaine.Size = new System.Drawing.Size(90, 23);
            this.Label_Domaine.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Domaine.StyleManager = null;
            this.Label_Domaine.TabIndex = 14;
            this.Label_Domaine.Text = "Domaine : ";
            this.Label_Domaine.ThemeAuthor = "Narwin";
            this.Label_Domaine.ThemeName = "MetroLite";
            // 
            // Label_Description
            // 
            this.Label_Description.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Description.IsDerivedStyle = true;
            this.Label_Description.Location = new System.Drawing.Point(80, 206);
            this.Label_Description.Name = "Label_Description";
            this.Label_Description.Size = new System.Drawing.Size(102, 23);
            this.Label_Description.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Description.StyleManager = null;
            this.Label_Description.TabIndex = 16;
            this.Label_Description.Text = "Description : ";
            this.Label_Description.ThemeAuthor = "Narwin";
            this.Label_Description.ThemeName = "MetroLite";
            // 
            // TxtBox_Description
            // 
            this.TxtBox_Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Description.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Description.Location = new System.Drawing.Point(215, 203);
            this.TxtBox_Description.MaxLength = 20;
            this.TxtBox_Description.Name = "TxtBox_Description";
            this.TxtBox_Description.Size = new System.Drawing.Size(164, 26);
            this.TxtBox_Description.TabIndex = 17;
            this.TxtBox_Description.TextChanged += new System.EventHandler(this.TxtBox_Description_TextChanged);
            // 
            // Label_Url_Photo
            // 
            this.Label_Url_Photo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Url_Photo.IsDerivedStyle = true;
            this.Label_Url_Photo.Location = new System.Drawing.Point(80, 249);
            this.Label_Url_Photo.Name = "Label_Url_Photo";
            this.Label_Url_Photo.Size = new System.Drawing.Size(102, 23);
            this.Label_Url_Photo.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Url_Photo.StyleManager = null;
            this.Label_Url_Photo.TabIndex = 18;
            this.Label_Url_Photo.Text = "URL Photo :";
            this.Label_Url_Photo.ThemeAuthor = "Narwin";
            this.Label_Url_Photo.ThemeName = "MetroLite";
            // 
            // TxtBox_URL_Photo
            // 
            this.TxtBox_URL_Photo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_URL_Photo.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_URL_Photo.Location = new System.Drawing.Point(215, 246);
            this.TxtBox_URL_Photo.MaxLength = 20;
            this.TxtBox_URL_Photo.Name = "TxtBox_URL_Photo";
            this.TxtBox_URL_Photo.Size = new System.Drawing.Size(164, 26);
            this.TxtBox_URL_Photo.TabIndex = 19;
            this.TxtBox_URL_Photo.TextChanged += new System.EventHandler(this.TxtBox_URL_Photo_TextChanged);
            // 
            // Label_Contenant
            // 
            this.Label_Contenant.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Contenant.IsDerivedStyle = true;
            this.Label_Contenant.Location = new System.Drawing.Point(32, 294);
            this.Label_Contenant.Name = "Label_Contenant";
            this.Label_Contenant.Size = new System.Drawing.Size(150, 23);
            this.Label_Contenant.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Contenant.StyleManager = null;
            this.Label_Contenant.TabIndex = 20;
            this.Label_Contenant.Text = "Contenant ( litre) : ";
            this.Label_Contenant.ThemeAuthor = "Narwin";
            this.Label_Contenant.ThemeName = "MetroLite";
            // 
            // TxtBox_Contenant
            // 
            this.TxtBox_Contenant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Contenant.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Contenant.Location = new System.Drawing.Point(215, 291);
            this.TxtBox_Contenant.MaxLength = 20;
            this.TxtBox_Contenant.Name = "TxtBox_Contenant";
            this.TxtBox_Contenant.Size = new System.Drawing.Size(164, 26);
            this.TxtBox_Contenant.TabIndex = 21;
            this.TxtBox_Contenant.TextChanged += new System.EventHandler(this.TxtBox_Contenant_TextChanged);
            // 
            // button_Ajout_Produits
            // 
            this.button_Ajout_Produits.BackColor = System.Drawing.Color.Lime;
            this.button_Ajout_Produits.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Ajout_Produits.FlatAppearance.BorderSize = 0;
            this.button_Ajout_Produits.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Ajout_Produits.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Ajout_Produits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ajout_Produits.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ajout_Produits.Location = new System.Drawing.Point(171, 397);
            this.button_Ajout_Produits.Name = "button_Ajout_Produits";
            this.button_Ajout_Produits.Size = new System.Drawing.Size(135, 52);
            this.button_Ajout_Produits.TabIndex = 22;
            this.button_Ajout_Produits.Text = "Ajout";
            this.button_Ajout_Produits.UseVisualStyleBackColor = false;
            this.button_Ajout_Produits.Click += new System.EventHandler(this.button_Ajout_Produits_Click);
            // 
            // textBox_Prix
            // 
            this.textBox_Prix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Prix.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Prix.Location = new System.Drawing.Point(215, 324);
            this.textBox_Prix.MaxLength = 20;
            this.textBox_Prix.Name = "textBox_Prix";
            this.textBox_Prix.Size = new System.Drawing.Size(164, 26);
            this.textBox_Prix.TabIndex = 24;
            this.textBox_Prix.TextChanged += new System.EventHandler(this.textBox_Prix_TextChanged);
            // 
            // Label_Prix
            // 
            this.Label_Prix.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prix.IsDerivedStyle = true;
            this.Label_Prix.Location = new System.Drawing.Point(32, 327);
            this.Label_Prix.Name = "Label_Prix";
            this.Label_Prix.Size = new System.Drawing.Size(150, 23);
            this.Label_Prix.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Prix.StyleManager = null;
            this.Label_Prix.TabIndex = 23;
            this.Label_Prix.Text = "prix : ";
            this.Label_Prix.ThemeAuthor = "Narwin";
            this.Label_Prix.ThemeName = "MetroLite";
            // 
            // textBox_Prix_Fournisseur
            // 
            this.textBox_Prix_Fournisseur.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Prix_Fournisseur.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Prix_Fournisseur.Location = new System.Drawing.Point(215, 359);
            this.textBox_Prix_Fournisseur.MaxLength = 20;
            this.textBox_Prix_Fournisseur.Name = "textBox_Prix_Fournisseur";
            this.textBox_Prix_Fournisseur.Size = new System.Drawing.Size(164, 26);
            this.textBox_Prix_Fournisseur.TabIndex = 26;
            this.textBox_Prix_Fournisseur.TextChanged += new System.EventHandler(this.textBox_Prix_Fournisseur_TextChanged);
            // 
            // Label_Prix_Fournisseur
            // 
            this.Label_Prix_Fournisseur.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prix_Fournisseur.IsDerivedStyle = true;
            this.Label_Prix_Fournisseur.Location = new System.Drawing.Point(32, 362);
            this.Label_Prix_Fournisseur.Name = "Label_Prix_Fournisseur";
            this.Label_Prix_Fournisseur.Size = new System.Drawing.Size(150, 23);
            this.Label_Prix_Fournisseur.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Prix_Fournisseur.StyleManager = null;
            this.Label_Prix_Fournisseur.TabIndex = 25;
            this.Label_Prix_Fournisseur.Text = "prix fournisseur : ";
            this.Label_Prix_Fournisseur.ThemeAuthor = "Narwin";
            this.Label_Prix_Fournisseur.ThemeName = "MetroLite";
            // 
            // AjoutProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 450);
            this.Controls.Add(this.textBox_Prix_Fournisseur);
            this.Controls.Add(this.Label_Prix_Fournisseur);
            this.Controls.Add(this.textBox_Prix);
            this.Controls.Add(this.Label_Prix);
            this.Controls.Add(this.button_Ajout_Produits);
            this.Controls.Add(this.TxtBox_Contenant);
            this.Controls.Add(this.Label_Contenant);
            this.Controls.Add(this.TxtBox_URL_Photo);
            this.Controls.Add(this.Label_Url_Photo);
            this.Controls.Add(this.TxtBox_Description);
            this.Controls.Add(this.Label_Description);
            this.Controls.Add(this.TxtBox_Domaine);
            this.Controls.Add(this.Label_Domaine);
            this.Controls.Add(this.TxtBox_Millesime_Produit);
            this.Controls.Add(this.Label_millesime);
            this.Controls.Add(this.Label_famille);
            this.Controls.Add(this.comboBox_Famille);
            this.Controls.Add(this.Label_fournisseur);
            this.Controls.Add(this.comboBox_Fournisseur);
            this.Controls.Add(this.TxtBox_Nom_Produit);
            this.Controls.Add(this.Label_Nom);
            this.Name = "AjoutProduit";
            this.Text = "AjoutProduit";
            this.Load += new System.EventHandler(this.AjoutProduit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Nom_Produit;
        private MetroSet_UI.Controls.MetroSetLabel Label_Nom;
        private System.Windows.Forms.ComboBox comboBox_Fournisseur;
        private MetroSet_UI.Controls.MetroSetLabel Label_fournisseur;
        private MetroSet_UI.Controls.MetroSetLabel Label_famille;
        private System.Windows.Forms.ComboBox comboBox_Famille;
        private System.Windows.Forms.TextBox TxtBox_Millesime_Produit;
        private MetroSet_UI.Controls.MetroSetLabel Label_millesime;
        private System.Windows.Forms.TextBox TxtBox_Domaine;
        private MetroSet_UI.Controls.MetroSetLabel Label_Domaine;
        private MetroSet_UI.Controls.MetroSetLabel Label_Description;
        private System.Windows.Forms.TextBox TxtBox_Description;
        private MetroSet_UI.Controls.MetroSetLabel Label_Url_Photo;
        private System.Windows.Forms.TextBox TxtBox_URL_Photo;
        private MetroSet_UI.Controls.MetroSetLabel Label_Contenant;
        private System.Windows.Forms.TextBox TxtBox_Contenant;
        private System.Windows.Forms.Button button_Ajout_Produits;
        private System.Windows.Forms.TextBox textBox_Prix;
        private MetroSet_UI.Controls.MetroSetLabel Label_Prix;
        private System.Windows.Forms.TextBox textBox_Prix_Fournisseur;
        private MetroSet_UI.Controls.MetroSetLabel Label_Prix_Fournisseur;
    }
}
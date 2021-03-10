
namespace Negosud_Plateforme
{
    partial class AjoutFamille
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
            this.TxtBox_Nom_Famille = new System.Windows.Forms.TextBox();
            this.Label_Nom = new MetroSet_UI.Controls.MetroSetLabel();
            this.button_Ajout_Produits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox_Nom_Famille
            // 
            this.TxtBox_Nom_Famille.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtBox_Nom_Famille.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBox_Nom_Famille.Location = new System.Drawing.Point(126, 50);
            this.TxtBox_Nom_Famille.MaxLength = 20;
            this.TxtBox_Nom_Famille.Name = "TxtBox_Nom_Famille";
            this.TxtBox_Nom_Famille.Size = new System.Drawing.Size(164, 26);
            this.TxtBox_Nom_Famille.TabIndex = 8;
            this.TxtBox_Nom_Famille.TextChanged += new System.EventHandler(this.TxtBox_Nom_Famille_TextChanged);
            // 
            // Label_Nom
            // 
            this.Label_Nom.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nom.IsDerivedStyle = true;
            this.Label_Nom.Location = new System.Drawing.Point(36, 53);
            this.Label_Nom.Name = "Label_Nom";
            this.Label_Nom.Size = new System.Drawing.Size(52, 23);
            this.Label_Nom.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Nom.StyleManager = null;
            this.Label_Nom.TabIndex = 9;
            this.Label_Nom.Text = "Nom : ";
            this.Label_Nom.ThemeAuthor = "Narwin";
            this.Label_Nom.ThemeName = "MetroLite";
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
            this.button_Ajout_Produits.Location = new System.Drawing.Point(113, 128);
            this.button_Ajout_Produits.Name = "button_Ajout_Produits";
            this.button_Ajout_Produits.Size = new System.Drawing.Size(135, 52);
            this.button_Ajout_Produits.TabIndex = 23;
            this.button_Ajout_Produits.Text = "Ajout";
            this.button_Ajout_Produits.UseVisualStyleBackColor = false;
            this.button_Ajout_Produits.Click += new System.EventHandler(this.button_Ajout_Produits_Click);
            // 
            // AjoutFamille
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 244);
            this.Controls.Add(this.button_Ajout_Produits);
            this.Controls.Add(this.Label_Nom);
            this.Controls.Add(this.TxtBox_Nom_Famille);
            this.Name = "AjoutFamille";
            this.Text = "AjoutFamille";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox_Nom_Famille;
        private MetroSet_UI.Controls.MetroSetLabel Label_Nom;
        private System.Windows.Forms.Button button_Ajout_Produits;
    }
}
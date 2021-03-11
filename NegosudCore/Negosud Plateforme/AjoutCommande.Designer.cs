
namespace Negosud_Plateforme
{
    partial class AjoutCommande
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
            this.Label_Quantite_Commande = new MetroSet_UI.Controls.MetroSetLabel();
            this.button_Ajout_Commande = new System.Windows.Forms.Button();
            this.Label_Nom_Produit_Commande = new MetroSet_UI.Controls.MetroSetLabel();
            this.comboBox_Produits_Commande = new System.Windows.Forms.ComboBox();
            this.Label_Prix_Total = new MetroSet_UI.Controls.MetroSetLabel();
            this.textBox_Prix_Total = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Label_Date = new MetroSet_UI.Controls.MetroSetLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Terminer_Commande = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Quantite_Commande
            // 
            this.Label_Quantite_Commande.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Quantite_Commande.IsDerivedStyle = true;
            this.Label_Quantite_Commande.Location = new System.Drawing.Point(63, 107);
            this.Label_Quantite_Commande.Name = "Label_Quantite_Commande";
            this.Label_Quantite_Commande.Size = new System.Drawing.Size(84, 23);
            this.Label_Quantite_Commande.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Quantite_Commande.StyleManager = null;
            this.Label_Quantite_Commande.TabIndex = 8;
            this.Label_Quantite_Commande.Text = "Quantité : ";
            this.Label_Quantite_Commande.ThemeAuthor = "Narwin";
            this.Label_Quantite_Commande.ThemeName = "MetroLite";
            // 
            // button_Ajout_Commande
            // 
            this.button_Ajout_Commande.BackColor = System.Drawing.Color.Lime;
            this.button_Ajout_Commande.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Ajout_Commande.FlatAppearance.BorderSize = 0;
            this.button_Ajout_Commande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Ajout_Commande.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Ajout_Commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Ajout_Commande.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ajout_Commande.Location = new System.Drawing.Point(111, 298);
            this.button_Ajout_Commande.Name = "button_Ajout_Commande";
            this.button_Ajout_Commande.Size = new System.Drawing.Size(135, 52);
            this.button_Ajout_Commande.TabIndex = 23;
            this.button_Ajout_Commande.Text = "Ajout";
            this.button_Ajout_Commande.UseVisualStyleBackColor = false;
            this.button_Ajout_Commande.Click += new System.EventHandler(this.button_Ajout_Commande_Click);
            // 
            // Label_Nom_Produit_Commande
            // 
            this.Label_Nom_Produit_Commande.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Nom_Produit_Commande.IsDerivedStyle = true;
            this.Label_Nom_Produit_Commande.Location = new System.Drawing.Point(63, 62);
            this.Label_Nom_Produit_Commande.Name = "Label_Nom_Produit_Commande";
            this.Label_Nom_Produit_Commande.Size = new System.Drawing.Size(84, 23);
            this.Label_Nom_Produit_Commande.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Nom_Produit_Commande.StyleManager = null;
            this.Label_Nom_Produit_Commande.TabIndex = 24;
            this.Label_Nom_Produit_Commande.Text = "Produits : ";
            this.Label_Nom_Produit_Commande.ThemeAuthor = "Narwin";
            this.Label_Nom_Produit_Commande.ThemeName = "MetroLite";
            // 
            // comboBox_Produits_Commande
            // 
            this.comboBox_Produits_Commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Produits_Commande.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Produits_Commande.FormattingEnabled = true;
            this.comboBox_Produits_Commande.Location = new System.Drawing.Point(181, 61);
            this.comboBox_Produits_Commande.Name = "comboBox_Produits_Commande";
            this.comboBox_Produits_Commande.Size = new System.Drawing.Size(164, 24);
            this.comboBox_Produits_Commande.TabIndex = 25;
            // 
            // Label_Prix_Total
            // 
            this.Label_Prix_Total.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Prix_Total.IsDerivedStyle = true;
            this.Label_Prix_Total.Location = new System.Drawing.Point(63, 160);
            this.Label_Prix_Total.Name = "Label_Prix_Total";
            this.Label_Prix_Total.Size = new System.Drawing.Size(94, 23);
            this.Label_Prix_Total.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Prix_Total.StyleManager = null;
            this.Label_Prix_Total.TabIndex = 26;
            this.Label_Prix_Total.Text = "Prix Total : ";
            this.Label_Prix_Total.ThemeAuthor = "Narwin";
            this.Label_Prix_Total.ThemeName = "MetroLite";
            // 
            // textBox_Prix_Total
            // 
            this.textBox_Prix_Total.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Prix_Total.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Prix_Total.Location = new System.Drawing.Point(181, 157);
            this.textBox_Prix_Total.MaxLength = 20;
            this.textBox_Prix_Total.Name = "textBox_Prix_Total";
            this.textBox_Prix_Total.Size = new System.Drawing.Size(164, 26);
            this.textBox_Prix_Total.TabIndex = 27;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(181, 107);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 20);
            this.numericUpDown1.TabIndex = 28;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(181, 222);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // Label_Date
            // 
            this.Label_Date.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Date.IsDerivedStyle = true;
            this.Label_Date.Location = new System.Drawing.Point(63, 222);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(94, 23);
            this.Label_Date.Style = MetroSet_UI.Enums.Style.Light;
            this.Label_Date.StyleManager = null;
            this.Label_Date.TabIndex = 30;
            this.Label_Date.Text = "Date : ";
            this.Label_Date.ThemeAuthor = "Narwin";
            this.Label_Date.ThemeName = "MetroLite";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 383);
            this.dataGridView1.TabIndex = 31;
            // 
            // button_Terminer_Commande
            // 
            this.button_Terminer_Commande.BackColor = System.Drawing.Color.Lime;
            this.button_Terminer_Commande.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Terminer_Commande.FlatAppearance.BorderSize = 0;
            this.button_Terminer_Commande.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Terminer_Commande.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button_Terminer_Commande.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Terminer_Commande.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Terminer_Commande.Location = new System.Drawing.Point(649, 462);
            this.button_Terminer_Commande.Name = "button_Terminer_Commande";
            this.button_Terminer_Commande.Size = new System.Drawing.Size(263, 52);
            this.button_Terminer_Commande.TabIndex = 32;
            this.button_Terminer_Commande.Text = "Finaliser Commande";
            this.button_Terminer_Commande.UseVisualStyleBackColor = false;
            // 
            // AjoutCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 526);
            this.Controls.Add(this.button_Terminer_Commande);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label_Date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox_Prix_Total);
            this.Controls.Add(this.Label_Prix_Total);
            this.Controls.Add(this.comboBox_Produits_Commande);
            this.Controls.Add(this.Label_Nom_Produit_Commande);
            this.Controls.Add(this.button_Ajout_Commande);
            this.Controls.Add(this.Label_Quantite_Commande);
            this.Name = "AjoutCommande";
            this.Text = "AjoutCommande";
            this.Load += new System.EventHandler(this.AjoutCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetLabel Label_Quantite_Commande;
        private System.Windows.Forms.Button button_Ajout_Commande;
        private MetroSet_UI.Controls.MetroSetLabel Label_Nom_Produit_Commande;
        private System.Windows.Forms.ComboBox comboBox_Produits_Commande;
        private MetroSet_UI.Controls.MetroSetLabel Label_Prix_Total;
        private System.Windows.Forms.TextBox textBox_Prix_Total;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroSet_UI.Controls.MetroSetLabel Label_Date;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_Terminer_Commande;
    }
}
namespace Gestion_Stock_Final.PL
{
    partial class FRM_Ajouter_Modifier_Produit
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbltitre = new System.Windows.Forms.Label();
            this.picProduit = new System.Windows.Forms.PictureBox();
            this.lblimage = new System.Windows.Forms.Label();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.comboboxcategorie = new System.Windows.Forms.ComboBox();
            this.btnparcourir = new System.Windows.Forms.Button();
            this.btnactualiser = new System.Windows.Forms.Button();
            this.btnenregistrer = new System.Windows.Forms.Button();
            this.txtnomproduit = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.btnquitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 4);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 590);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 4);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 586);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(710, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 586);
            this.panel4.TabIndex = 3;
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.Color.Snow;
            this.lbltitre.Location = new System.Drawing.Point(243, 25);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(208, 31);
            this.lbltitre.TabIndex = 7;
            this.lbltitre.Text = "Ajouter Produit";
            // 
            // picProduit
            // 
            this.picProduit.BackColor = System.Drawing.Color.White;
            this.picProduit.Location = new System.Drawing.Point(128, 113);
            this.picProduit.Name = "picProduit";
            this.picProduit.Size = new System.Drawing.Size(260, 192);
            this.picProduit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProduit.TabIndex = 8;
            this.picProduit.TabStop = false;
            // 
            // lblimage
            // 
            this.lblimage.AutoSize = true;
            this.lblimage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblimage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblimage.Location = new System.Drawing.Point(66, 113);
            this.lblimage.Name = "lblimage";
            this.lblimage.Size = new System.Drawing.Size(56, 17);
            this.lblimage.TabIndex = 9;
            this.lblimage.Text = "Image:";
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(438, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Categorie:";
            // 
            // comboboxcategorie
            // 
            this.comboboxcategorie.FormattingEnabled = true;
            this.comboboxcategorie.Location = new System.Drawing.Point(528, 113);
            this.comboboxcategorie.Name = "comboboxcategorie";
            this.comboboxcategorie.Size = new System.Drawing.Size(121, 21);
            this.comboboxcategorie.TabIndex = 11;
            // 
            // btnparcourir
            // 
            this.btnparcourir.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnparcourir.FlatAppearance.BorderSize = 0;
            this.btnparcourir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnparcourir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnparcourir.ForeColor = System.Drawing.Color.White;
            this.btnparcourir.Location = new System.Drawing.Point(235, 311);
            this.btnparcourir.Name = "btnparcourir";
            this.btnparcourir.Size = new System.Drawing.Size(153, 41);
            this.btnparcourir.TabIndex = 12;
            this.btnparcourir.Text = "Parcourir";
            this.btnparcourir.UseVisualStyleBackColor = false;
            this.btnparcourir.Click += new System.EventHandler(this.btnparcourir_Click);
            // 
            // btnactualiser
            // 
            this.btnactualiser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnactualiser.FlatAppearance.BorderSize = 0;
            this.btnactualiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnactualiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnactualiser.ForeColor = System.Drawing.Color.White;
            this.btnactualiser.Location = new System.Drawing.Point(69, 457);
            this.btnactualiser.Name = "btnactualiser";
            this.btnactualiser.Size = new System.Drawing.Size(255, 41);
            this.btnactualiser.TabIndex = 13;
            this.btnactualiser.Text = "Actualiser";
            this.btnactualiser.UseVisualStyleBackColor = false;
            this.btnactualiser.Click += new System.EventHandler(this.btnactualiser_Click);
            // 
            // btnenregistrer
            // 
            this.btnenregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnenregistrer.FlatAppearance.BorderSize = 0;
            this.btnenregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnenregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnenregistrer.ForeColor = System.Drawing.Color.White;
            this.btnenregistrer.Location = new System.Drawing.Point(425, 457);
            this.btnenregistrer.Name = "btnenregistrer";
            this.btnenregistrer.Size = new System.Drawing.Size(255, 41);
            this.btnenregistrer.TabIndex = 14;
            this.btnenregistrer.Text = "Enregistrer";
            this.btnenregistrer.UseVisualStyleBackColor = false;
            this.btnenregistrer.Click += new System.EventHandler(this.btnenregistrer_Click);
            // 
            // txtnomproduit
            // 
            this.txtnomproduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtnomproduit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnomproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomproduit.ForeColor = System.Drawing.Color.White;
            this.txtnomproduit.Location = new System.Drawing.Point(504, 171);
            this.txtnomproduit.Name = "txtnomproduit";
            this.txtnomproduit.Size = new System.Drawing.Size(176, 16);
            this.txtnomproduit.TabIndex = 15;
            this.txtnomproduit.Text = "Nom Produit";
            this.txtnomproduit.Enter += new System.EventHandler(this.txtnomproduit_Enter);
            this.txtnomproduit.Leave += new System.EventHandler(this.txtnomproduit_Leave);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(504, 193);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 3);
            this.panel5.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.Image = global::Gestion_Stock_Final.Properties.Resources.product_32;
            this.label2.Location = new System.Drawing.Point(450, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 37);
            this.label2.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Image = global::Gestion_Stock_Final.Properties.Resources.Quantie_32;
            this.label3.Location = new System.Drawing.Point(454, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 37);
            this.label3.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(508, 287);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 3);
            this.panel6.TabIndex = 19;
            // 
            // txtquantite
            // 
            this.txtquantite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtquantite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtquantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtquantite.ForeColor = System.Drawing.Color.White;
            this.txtquantite.Location = new System.Drawing.Point(508, 265);
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(176, 16);
            this.txtquantite.TabIndex = 18;
            this.txtquantite.Text = "Quantité";
            this.txtquantite.Enter += new System.EventHandler(this.txtquantite_Enter);
            this.txtquantite.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtquantite_KeyPress);
            this.txtquantite.Leave += new System.EventHandler(this.txtquantite_Leave);
            // 
            // label4
            // 
            this.label4.Image = global::Gestion_Stock_Final.Properties.Resources.prix_32;
            this.label4.Location = new System.Drawing.Point(450, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 37);
            this.label4.TabIndex = 23;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(508, 387);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 3);
            this.panel7.TabIndex = 22;
            // 
            // txtprix
            // 
            this.txtprix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtprix.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtprix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprix.ForeColor = System.Drawing.Color.White;
            this.txtprix.Location = new System.Drawing.Point(508, 365);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(176, 16);
            this.txtprix.TabIndex = 21;
            this.txtprix.Text = "Prix";
            this.txtprix.Enter += new System.EventHandler(this.txtprix_Enter);
            this.txtprix.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtprix_KeyPress);
            this.txtprix.Leave += new System.EventHandler(this.txtprix_Leave);
            // 
            // btnquitter
            // 
            this.btnquitter.FlatAppearance.BorderSize = 0;
            this.btnquitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitter.Image = global::Gestion_Stock_Final.Properties.Resources.Button_Delete_icon;
            this.btnquitter.Location = new System.Drawing.Point(661, 12);
            this.btnquitter.Name = "btnquitter";
            this.btnquitter.Size = new System.Drawing.Size(43, 44);
            this.btnquitter.TabIndex = 24;
            this.btnquitter.UseVisualStyleBackColor = true;
            this.btnquitter.Click += new System.EventHandler(this.btnquitter_Click);
            // 
            // FRM_Ajouter_Modifier_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(714, 594);
            this.Controls.Add(this.btnquitter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtprix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtquantite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtnomproduit);
            this.Controls.Add(this.btnenregistrer);
            this.Controls.Add(this.btnactualiser);
            this.Controls.Add(this.btnparcourir);
            this.Controls.Add(this.comboboxcategorie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblimage);
            this.Controls.Add(this.picProduit);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRM_Ajouter_Modifier_Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_Ajouter_Modifier_Produit";
            ((System.ComponentModel.ISupportInitialize)(this.picProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label lbltitre;
        private System.Windows.Forms.Label lblimage;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnparcourir;
        private System.Windows.Forms.Button btnenregistrer;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnquitter;
        public System.Windows.Forms.Button btnactualiser;
        public System.Windows.Forms.ComboBox comboboxcategorie;
        public System.Windows.Forms.PictureBox picProduit;
        public System.Windows.Forms.TextBox txtnomproduit;
        public System.Windows.Forms.TextBox txtquantite;
        public System.Windows.Forms.TextBox txtprix;
    }
}
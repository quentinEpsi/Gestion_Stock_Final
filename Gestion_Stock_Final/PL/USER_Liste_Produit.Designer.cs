namespace Gestion_Stock_Final.PL
{
    partial class USER_Liste_Produit
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dvgproduit = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtrecherche = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnimprimertout = new System.Windows.Forms.Button();
            this.btnexcel = new System.Windows.Forms.Button();
            this.btnImprimerSelection = new System.Windows.Forms.Button();
            this.btnafficherphoto = new System.Windows.Forms.Button();
            this.btnmodifproduit = new System.Windows.Forms.Button();
            this.btnsupprimproduit = new System.Windows.Forms.Button();
            this.btnajouteproduit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgproduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgproduit
            // 
            this.dvgproduit.AllowUserToAddRows = false;
            this.dvgproduit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgproduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgproduit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dvgproduit.Location = new System.Drawing.Point(64, 183);
            this.dvgproduit.Name = "dvgproduit";
            this.dvgproduit.Size = new System.Drawing.Size(1000, 441);
            this.dvgproduit.TabIndex = 15;
            // 
            // column1
            // 
            this.column1.HeaderText = "Select";
            this.column1.Name = "column1";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Id";
            this.Column9.Name = "Column9";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantité";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prix";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Categorie";
            this.Column5.Name = "Column5";
            // 
            // txtrecherche
            // 
            this.txtrecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtrecherche.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtrecherche.Location = new System.Drawing.Point(251, 94);
            this.txtrecherche.Multiline = true;
            this.txtrecherche.Name = "txtrecherche";
            this.txtrecherche.Size = new System.Drawing.Size(386, 28);
            this.txtrecherche.TabIndex = 13;
            this.txtrecherche.Text = "Recherche";
            this.txtrecherche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtrecherche.TextChanged += new System.EventHandler(this.txtrecherche_TextChanged);
            this.txtrecherche.Enter += new System.EventHandler(this.txtrecherche_Enter);
            this.txtrecherche.Leave += new System.EventHandler(this.txtrecherche_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel2.Location = new System.Drawing.Point(64, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 2);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel1.Location = new System.Drawing.Point(64, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 2);
            this.panel1.TabIndex = 11;
            // 
            // btnimprimertout
            // 
            this.btnimprimertout.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnimprimertout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnimprimertout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnimprimertout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnimprimertout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnimprimertout.Image = global::Gestion_Stock_Final.Properties.Resources.Imprimer;
            this.btnimprimertout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnimprimertout.Location = new System.Drawing.Point(592, 630);
            this.btnimprimertout.Name = "btnimprimertout";
            this.btnimprimertout.Size = new System.Drawing.Size(296, 50);
            this.btnimprimertout.TabIndex = 19;
            this.btnimprimertout.Text = "Imprimer Tous";
            this.btnimprimertout.UseVisualStyleBackColor = false;
            this.btnimprimertout.Click += new System.EventHandler(this.btnimprimertout_Click);
            // 
            // btnexcel
            // 
            this.btnexcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnexcel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexcel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnexcel.Image = global::Gestion_Stock_Final.Properties.Resources.Excel_icon;
            this.btnexcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexcel.Location = new System.Drawing.Point(1109, 630);
            this.btnexcel.Name = "btnexcel";
            this.btnexcel.Size = new System.Drawing.Size(306, 50);
            this.btnexcel.TabIndex = 18;
            this.btnexcel.Text = "Sauvegarder dans Excel";
            this.btnexcel.UseVisualStyleBackColor = false;
            this.btnexcel.Click += new System.EventHandler(this.btnexcel_Click);
            // 
            // btnImprimerSelection
            // 
            this.btnImprimerSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImprimerSelection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnImprimerSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimerSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimerSelection.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnImprimerSelection.Image = global::Gestion_Stock_Final.Properties.Resources.Imprimer;
            this.btnImprimerSelection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimerSelection.Location = new System.Drawing.Point(64, 630);
            this.btnImprimerSelection.Name = "btnImprimerSelection";
            this.btnImprimerSelection.Size = new System.Drawing.Size(284, 50);
            this.btnImprimerSelection.TabIndex = 17;
            this.btnImprimerSelection.Text = "  Imprimer Produit coché";
            this.btnImprimerSelection.UseVisualStyleBackColor = false;
            this.btnImprimerSelection.Click += new System.EventHandler(this.btnImprimerSelection_Click);
            // 
            // btnafficherphoto
            // 
            this.btnafficherphoto.AutoSize = true;
            this.btnafficherphoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnafficherphoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnafficherphoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnafficherphoto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnafficherphoto.Image = global::Gestion_Stock_Final.Properties.Resources.Pictures_icon;
            this.btnafficherphoto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnafficherphoto.Location = new System.Drawing.Point(856, 17);
            this.btnafficherphoto.Name = "btnafficherphoto";
            this.btnafficherphoto.Size = new System.Drawing.Size(255, 56);
            this.btnafficherphoto.TabIndex = 16;
            this.btnafficherphoto.Text = "Afficher Photo";
            this.btnafficherphoto.UseVisualStyleBackColor = false;
            this.btnafficherphoto.Click += new System.EventHandler(this.btnafficherphoto_Click);
            // 
            // btnmodifproduit
            // 
            this.btnmodifproduit.AutoSize = true;
            this.btnmodifproduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnmodifproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmodifproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmodifproduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnmodifproduit.Image = global::Gestion_Stock_Final.Properties.Resources.Recycle_iconaaa;
            this.btnmodifproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnmodifproduit.Location = new System.Drawing.Point(286, 17);
            this.btnmodifproduit.Name = "btnmodifproduit";
            this.btnmodifproduit.Size = new System.Drawing.Size(247, 56);
            this.btnmodifproduit.TabIndex = 10;
            this.btnmodifproduit.Text = "Modifier";
            this.btnmodifproduit.UseVisualStyleBackColor = false;
            this.btnmodifproduit.Click += new System.EventHandler(this.btnmodifproduit_Click);
            // 
            // btnsupprimproduit
            // 
            this.btnsupprimproduit.AutoSize = true;
            this.btnsupprimproduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnsupprimproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsupprimproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsupprimproduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsupprimproduit.Image = global::Gestion_Stock_Final.Properties.Resources.Close_2_icon;
            this.btnsupprimproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsupprimproduit.Location = new System.Drawing.Point(562, 17);
            this.btnsupprimproduit.Name = "btnsupprimproduit";
            this.btnsupprimproduit.Size = new System.Drawing.Size(268, 56);
            this.btnsupprimproduit.TabIndex = 9;
            this.btnsupprimproduit.Text = "Supprimer";
            this.btnsupprimproduit.UseVisualStyleBackColor = false;
            this.btnsupprimproduit.Click += new System.EventHandler(this.btnsupprimproduit_Click);
            // 
            // btnajouteproduit
            // 
            this.btnajouteproduit.AutoSize = true;
            this.btnajouteproduit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnajouteproduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnajouteproduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnajouteproduit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnajouteproduit.Image = global::Gestion_Stock_Final.Properties.Resources.Actions_list_add_icon;
            this.btnajouteproduit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnajouteproduit.Location = new System.Drawing.Point(14, 17);
            this.btnajouteproduit.Name = "btnajouteproduit";
            this.btnajouteproduit.Size = new System.Drawing.Size(239, 56);
            this.btnajouteproduit.TabIndex = 8;
            this.btnajouteproduit.Text = "Ajouter";
            this.btnajouteproduit.UseVisualStyleBackColor = false;
            this.btnajouteproduit.Click += new System.EventHandler(this.btnajouteproduit_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Image = global::Gestion_Stock_Final.Properties.Resources.Refresh_icon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(856, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 56);
            this.button1.TabIndex = 20;
            this.button1.Text = "Actualiser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // USER_Liste_Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnimprimertout);
            this.Controls.Add(this.btnexcel);
            this.Controls.Add(this.btnImprimerSelection);
            this.Controls.Add(this.btnafficherphoto);
            this.Controls.Add(this.dvgproduit);
            this.Controls.Add(this.txtrecherche);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnmodifproduit);
            this.Controls.Add(this.btnsupprimproduit);
            this.Controls.Add(this.btnajouteproduit);
            this.Name = "USER_Liste_Produit";
            this.Size = new System.Drawing.Size(1458, 683);
            this.Load += new System.EventHandler(this.USER_Liste_Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgproduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgproduit;
        private System.Windows.Forms.TextBox txtrecherche;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmodifproduit;
        private System.Windows.Forms.Button btnsupprimproduit;
        private System.Windows.Forms.Button btnajouteproduit;
        private System.Windows.Forms.Button btnafficherphoto;
        private System.Windows.Forms.Button btnimprimertout;
        private System.Windows.Forms.Button btnexcel;
        private System.Windows.Forms.Button btnImprimerSelection;
        private System.Windows.Forms.DataGridViewCheckBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button button1;
    }
}

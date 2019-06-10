using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stock_Final.PL
{
    public partial class FRM_Ajoute_Modifier_Categorie : Form
    {
        private UserControl usercategorie;

        public FRM_Ajoute_Modifier_Categorie(UserControl userCategorie)
        {
            InitializeComponent();
            this.usercategorie = userCategorie;
        }

        private void FRM_Ajoute_Modifier_Categorie_Load(object sender, EventArgs e)
        {

        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public int idCategorie;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            BL.CLS_Categorie clcat = new BL.CLS_Categorie();
            if(txtNomCategorie.Text==""|| txtNomCategorie.Text=="Nom de Categorie")
            {
                MessageBox.Show("Entrer Nom de Catégorie", "Ajoute Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if(lbltitre.Text == "Ajouter Catégorie")
                {
                    if(clcat.Ajouter_Categorie(txtNomCategorie.Text) == false)
                    {
                        MessageBox.Show("Categorie existe déjà", "Ajoute Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Categorie ajouté avec succes", "Ajoute Catégorie", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usercategorie as USER_Liste_Categorie).remplirdatagrid();
                    }
                }
                if(lbltitre.Text =="Modifier Categorie")
                {
                    DialogResult DR = MessageBox.Show("Voulez-vous vraiment modifier ?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(DR == DialogResult.Yes)
                    {
                        clcat.Modifier_Categorie(idCategorie, txtNomCategorie.Text);
                        MessageBox.Show("Categorie Modifier avec succes","Modification",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (usercategorie as USER_Liste_Categorie).remplirdatagrid();
                    }
                    else
                    {
                        MessageBox.Show("Modification annulé","Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
         
        }
    }
}

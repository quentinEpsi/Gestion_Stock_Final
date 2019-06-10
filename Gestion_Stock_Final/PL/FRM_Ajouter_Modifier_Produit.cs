using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Gestion_Stock_Final.PL
{
    public partial class FRM_Ajouter_Modifier_Produit : Form
    {
        private dbStockContext db;
        private UserControl userProduit;

        public FRM_Ajouter_Modifier_Produit(UserControl User)
        {
            InitializeComponent();
            db = new dbStockContext();
            this.userProduit = User;
            //Afficher les catégories dans le combobox
            comboboxcategorie.DataSource = db.Categories.ToList();
            comboboxcategorie.DisplayMember = "Nom_Categorie"; //Afficher les noms des catégories
            comboboxcategorie.ValueMember = "ID_Categorie";

        }
        //Test de champs obligatoires
        string testobligatoire()
        {
            if (txtnomproduit.Text == "" || txtnomproduit.Text == "Nom Produit")
            {
                return "Entrer le nom du Produit";
            }
            if (txtquantite.Text == "" || txtquantite.Text == "Quantité")
            {
                return "Entrer la quantité de Produit";
            }
            if (txtprix.Text == "" || txtprix.Text == "Prix")
            {
                return "Entrer le prix du Produit";
            }
            if(picProduit.Image==null)
            {
                return "Veuillez mettre une image";
            }
            return null;
        }

        private void txtnomproduit_Enter(object sender, EventArgs e)
        {
            if(txtnomproduit.Text=="Nom Produit")
            {
                txtnomproduit.Text = "";
            }
        }

        private void txtquantite_Enter(object sender, EventArgs e)
        {
            if (txtquantite.Text == "Quantité")
            {
                txtquantite.Text = "";
            }
        }

        private void txtprix_Enter(object sender, EventArgs e)
        {
            if (txtprix.Text == "Prix")
            {
                txtprix.Text = "";
            }
        }

        private void txtnomproduit_Leave(object sender, EventArgs e)
        {
            if (txtnomproduit.Text == "")
            {
                txtnomproduit.Text = "Nom Produit";
            }
        }

        private void txtquantite_Leave(object sender, EventArgs e)
        {
            if(txtquantite.Text=="")
            {
                txtquantite.Text = "Quantité";
            }
        }

        private void txtprix_Leave(object sender, EventArgs e)
        {
            if(txtprix.Text=="")
            {
                txtprix.Text = "Prix";
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnparcourir_Click(object sender, EventArgs e)
        {
            //Afficher fichier Image
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "|*.JPG;*.PNG;*.GIF;*BMP"; // pour afficher seulement les images avec ces extensions
            if(OP.ShowDialog()==DialogResult.OK)
            {
                picProduit.Image = Image.FromFile(OP.FileName);
            }
        }

        private void btnactualiser_Click(object sender, EventArgs e)
        {
            //Bouton pour vider le formulaire
            txtnomproduit.Text = "";
            txtquantite.Text = "";
            txtprix.Text = "";
            comboboxcategorie.Text = "";
            picProduit.Image = null;
        }

        private void txtquantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if(e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void txtprix_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
        public int IDPRODUIT;
        private void btnenregistrer_Click(object sender, EventArgs e)
        {
            if(testobligatoire()!=null)
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                if(lbltitre.Text == "Ajouter Produit")
                {
                    BL.CLS_Produit clproduit = new BL.CLS_Produit();
                    //convertir image en format byte
                    //Ajouter Systeme.IO
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteImageP = MR.ToArray(); // convertir image en format byte[]
                    if (clproduit.Ajouter_Produit(txtnomproduit.Text, int.Parse(txtquantite.Text), txtprix.Text, byteImageP, Convert.ToInt32(comboboxcategorie.SelectedValue))== true)
                    {
                        MessageBox.Show("Produit ajouté avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        (userProduit as USER_Liste_Produit).Actualisedatagrid();
                    }
                    else
                    {
                        MessageBox.Show("Produit Existe déjà", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }else // Si c'est Modifier Produit
                {
                    MemoryStream MR = new MemoryStream();
                    picProduit.Image.Save(MR, picProduit.Image.RawFormat);
                    byte[] byteImageP = MR.ToArray(); // convertir image en format byte[]
                    BL.CLS_Produit clproduit = new BL.CLS_Produit();
                    DialogResult R = MessageBox.Show("Etes vous sur de vouloir modifier ce produit ?","Modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    if(R == DialogResult.Yes)
                    {
                        clproduit.Modifier_Produit(IDPRODUIT, txtnomproduit.Text, int.Parse(txtquantite.Text), txtprix.Text, byteImageP, Convert.ToInt32(comboboxcategorie.SelectedValue));
                        MessageBox.Show("Produit Modifier avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //Actualiser le datagrid
                        (userProduit as USER_Liste_Produit).Actualisedatagrid();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Modification annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }
    }
}

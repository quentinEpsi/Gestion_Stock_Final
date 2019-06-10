using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Stock_Final.PL
{
    public partial class USER_Liste_Categorie : UserControl
    {
        private static dbStockContext db;
        private static USER_Liste_Categorie Usercategorie;

        public static USER_Liste_Categorie Instance
        {
            get
            {
                if(Usercategorie == null)
                {
                    Usercategorie = new USER_Liste_Categorie();
                }
                return Usercategorie;
            }
        }

        public USER_Liste_Categorie()
        {
            InitializeComponent();
            db = new dbStockContext();
        }

        public void remplirdatagrid() // Remplir datagridView
        {
            db = new dbStockContext();
            dvgcategorie.Rows.Clear();
            foreach(var Cat in db.Categories)
            {
                dvgcategorie.Rows.Add(false, Cat.ID_Categorie, Cat.Nom_Categorie);
            }
        }

        private void USER_Liste_Categorie_Load(object sender, EventArgs e)
        {
            remplirdatagrid();
        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
            }
        }

        private void btnajouteclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Categorie frmcat = new PL.FRM_Ajoute_Modifier_Categorie(this);
            frmcat.ShowDialog();
        }

        //Tout ce que je vais envoyer au formulaire quand j'appuie sur la touche modifier
        private void dvgcategorie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Categorie frmcat = new FRM_Ajoute_Modifier_Categorie(this);
            if(dvgcategorie.Columns[e.ColumnIndex].Name=="Modifier") // Si j'ai cliquer sur le boutton modifier
            {
                //J'envoie mon id categorie au formulaire
                frmcat.idCategorie = (int)dvgcategorie.Rows[e.RowIndex].Cells[1].Value;
                frmcat.lbltitre.Text = "Modifier Categorie";
                frmcat.txtNomCategorie.Text = dvgcategorie.Rows[e.RowIndex].Cells[2].Value.ToString(); // e.RowIndex c'est l'index de la ligne où tu as cliquer
                frmcat.ShowDialog();
            }
            if(dvgcategorie.Columns[e.ColumnIndex].Name== "Supprimer") // si je clique sur le bouton supprimer
            {
                BL.CLS_Categorie clscat = new BL.CLS_Categorie();
                DialogResult DR = MessageBox.Show("Voulez vous vraiment supprimer ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DR == DialogResult.Yes)
                {
                    //Vérifier s'il y a des produits dans cette catégorie
                    int idCat = (int)dvgcategorie.Rows[e.RowIndex].Cells[1].Value;
                    int P = db.Produits.Count(s => s.ID_Categorie == idCat); // Count = combien de produit dans categorie
                    if(P == 0) //Pas de produit associé à cette catégorie
                    {
                        clscat.Supprimer_Categorie(idCat);
                        MessageBox.Show("Catégorie supprimée avec Succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        //Actualisation du datagridView
                        remplirdatagrid();
                    }
                    else //Sinon il y a des produits dans la catégorie
                    {
                        DialogResult PDP = MessageBox.Show("Il y a " +P+ "Produit dans cette catégorie, voulez vous vraiment supprimer","Suppression",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                        if (PDP == DialogResult.Yes)
                        {
                            clscat.Supprimer_Categorie(idCat);
                            MessageBox.Show("Catégorie supprimée avec Succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            //Actualisation du datagridView
                            remplirdatagrid();
                        }
                        else
                        {
                            MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            var maliste = db.Categories.ToList(); //Je récupère toutes mes catégories
            maliste = maliste.Where(s => s.Nom_Categorie.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList(); //Je fais la requête sur le champ Nom
            dvgcategorie.Rows.Clear(); //Je clear les lignes du datagridView
            foreach (var l in maliste) //Je boucle sur ce que je trouve
            {
                dvgcategorie.Rows.Add(false, l.ID_Categorie, l.Nom_Categorie); //Je rempli le datagridview
            }
        }
    }
}

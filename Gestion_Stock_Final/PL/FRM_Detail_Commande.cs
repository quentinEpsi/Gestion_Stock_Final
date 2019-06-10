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
    public partial class FRM_Detail_Commande : Form
    {
        private dbStockContext db;

        public FRM_Detail_Commande()
        {
            InitializeComponent();
            db = new dbStockContext();
        }
        //Remplir DataGridView de Commande par liste
        public void Actualise_DetailCommande()
        {
            dvgdetailCommande.Rows.Clear();
            foreach (var L in BL.D_Commande.listeDetail)
            {
                dvgdetailCommande.Rows.Add(L.Id, L.Nom, L.Quantite, L.Prix, L.Remise, L.Total);
            }
        }
        //Fonction remplir le datagridView de Produit

        public void RemplirdvgProduit()
        {
            db = new dbStockContext();
            foreach(var l in db.Produits)
            {
                dvgproduit.Rows.Add(l.ID_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);
            }
            /*//Colorer Stock vide en rouge  COLORATION STOCK
            for(int i =0; i<dvgproduit.Rows.Count;i++)
            {
                if((int)dvgproduit.Rows[i].Cells[2].Value == 0) // si le stock est égal à 0
                {
                    dvgproduit.Rows[i].Cells[2].Style.BackColor = Color.Red;
                }
                else
                {
                    dvgproduit.Rows[i].Cells[2].Style.BackColor = Color.LightGreen;

                }
                //Vider ligne selectionner
                dvgProduit.ClearSelection();
            }*/

        }



        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if (txtrecherche.Text == "Recherche")
            {
                txtrecherche.Text = "";
            }
        }

        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Ajoute_Modifier_Commande_Load(object sender, EventArgs e)
        {
            RemplirdvgProduit();
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.Produits.ToList(); // listerecherche = liste des produits de la base de données
            listerecherche = listerecherche.Where(s => s.Nom_Produit.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            //!=-1 existe dans la base de donnée

            //Vider le datagridView
            dvgproduit.Rows.Clear();

            //Ajouter listerecherche dans datagridView Produit
            foreach (var l in listerecherche)
            {
                dvgproduit.Rows.Add(l.ID_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit);
            }
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            PL.FRM_Client_Commande frmC = new FRM_Client_Commande();
            frmC.ShowDialog();
            //Afficher les informations des clients
            txtNomClient.Text = frmC.dvgclient.CurrentRow.Cells[1].Value.ToString();
            txtPrenomClient.Text = frmC.dvgclient.CurrentRow.Cells[2].Value.ToString();
            txtTelephoneClient.Text = frmC.dvgclient.CurrentRow.Cells[3].Value.ToString();
            txtEmailClient.Text = frmC.dvgclient.CurrentRow.Cells[4].Value.ToString();
            txtPaysClient.Text = frmC.dvgclient.CurrentRow.Cells[5].Value.ToString();
            txtVilleClient.Text = frmC.dvgclient.CurrentRow.Cells[6].Value.ToString();
            
        }

        private void dvgproduit_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FRM_Produit_Commande frmp = new FRM_Produit_Commande(this);
            //Si le stock est vide
            if((int)dvgproduit.CurrentRow.Cells[2].Value==0)
            {
                MessageBox.Show("Stock Vide", "Stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Afficher information de produit
                frmp.lblid.Text = dvgproduit.CurrentRow.Cells[0].Value.ToString();
                frmp.lblNom.Text = dvgproduit.CurrentRow.Cells[1].Value.ToString();
                frmp.lblStock.Text = dvgproduit.CurrentRow.Cells[2].Value.ToString();
                frmp.lblPrix.Text = dvgproduit.CurrentRow.Cells[3].Value.ToString();
                frmp.txtTotal.Text = dvgproduit.CurrentRow.Cells[3].Value.ToString();
                frmp.ShowDialog();
            }
        }
    }
}

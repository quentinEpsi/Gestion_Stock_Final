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
    public partial class FRM_Produit_Commande : Form
    {
        public Form frmdetail;
        public FRM_Produit_Commande(Form frm)
        {
            InitializeComponent();
            frmdetail = frm;
        }

        private void FRM_Produit_Commande_Load(object sender, EventArgs e)
        {

        }

        private void txtQuantite_KeyPress(object sender, KeyPressEventArgs e)
        {
            //text numerique
            if(!char.IsDigit(e.KeyChar) && e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtQuantite_TextChanged(object sender, EventArgs e)
        {
            if(txtQuantite.Text!="") //Si pas vide
            {

                int quantite = int.Parse(txtQuantite.Text);
                int prix = int.Parse(lblPrix.Text);
                if(int.Parse(txtQuantite.Text) > int.Parse(lblStock.Text))
                {
                    MessageBox.Show("Il y a seulement " + lblStock.Text + " dans Stock","Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //vider textbox Quantite
                    txtQuantite.Text = "";
                }
                //Calculer le total
                txtTotal.Text = (quantite * prix).ToString();
            }else
            {
                txtTotal.Text = lblPrix.Text;
            }
            
        }

        private void txtRemise_TextChanged(object sender, EventArgs e)
        {
            if(txtRemise.Text!="")
            {
                int quantite;
                if(txtQuantite.Text !="")
                {
                    quantite = int.Parse(txtQuantite.Text);
                    
                }else
                {
                    quantite = 1;
                }
                int prix = int.Parse(lblPrix.Text);
                int total = quantite * prix;
                int remise = int.Parse(txtRemise.Text);
                txtTotal.Text = (total - (total * remise / 100)).ToString();

            }
            else
            {
                int quantite;
                if(txtQuantite.Text != "")
                {
                    quantite = int.Parse(txtQuantite.Text);
                }
                else
                {
                    quantite = 1;
                }
                int prix = int.Parse(lblPrix.Text);
                txtTotal.Text = (quantite * prix).ToString();
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            //Si textbox Quantite et txtBox remise sont vides 
            int Quant, Remise;
            if(txtQuantite.Text!="")
            {
                Quant = int.Parse(txtQuantite.Text);
            }
            else
            {
                Quant = 1;
            }
            if(txtRemise.Text!="")
            {
                Remise = int.Parse(txtRemise.Text);
            }else
            {
                Remise = 0; 
            }
            //Ajouter Produit dans Commande
            BL.D_Commande DETAIL = new BL.D_Commande
            {
                Id = int.Parse(lblid.Text),
                Nom = lblNom.Text,
                Quantite = Quant,
                Prix = lblPrix.Text,
                Remise = Remise.ToString(),
                Total = txtTotal.Text,
            };
            //Ajouter dans liste
            if(BL.D_Commande.listeDetail.SingleOrDefault(s=>s.Id == DETAIL.Id)!=null)
            {
                MessageBox.Show("Produit existe déjà dans la commande", "Produit",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }else
            {
                BL.D_Commande.listeDetail.Add(DETAIL);
                //Actualiser datagridview
                (frmdetail as FRM_Detail_Commande).Actualise_DetailCommande();
            }
            
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace Gestion_Stock_Final.PL
{
    public partial class FRM_Ajoute_Modifier_Client : Form
    {
        private UserControl usclient;
        public FRM_Ajoute_Modifier_Client(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC;
        }

        string testobligatoire()
        {
            if(txtNomClient.Text==""||txtNomClient.Text=="Nom de Client")
            {
                return "Entrer le nom de Client";
            }
            if (txtAdresseClient.Text == "" || txtAdresseClient.Text == "Adresse de Client")
            {
                return "Entrer l'adresse de Client";
            }
            if (txtPaysClient.Text == "" || txtPaysClient.Text == "Pays Client")
            {
                return "Entrer le Pays Client";
            }
            if (txtTelephoneClient.Text == "" || txtTelephoneClient.Text == "Téléphone de Client")
            {
                return "Entrer le téléphone de Client";
            }
            if (txtPrenomClient.Text == "" || txtPrenomClient.Text == "Prénom de Client")
            {
                return "Entrer le prénom de Client";
            }
            if (txtEmailClient.Text == "" || txtEmailClient.Text == "Email de Client")
            {
                return "Entrer l'Email de Client";
            }
            if (txtVilleClient.Text == "" || txtVilleClient.Text == "Ville de Client")
            {
                return "Entrer la ville de Client";
            }
            //Verifier email valide ou non
            if (txtEmailClient.Text != "" || txtEmailClient.Text != "Email de Client")
            {
                try
                {
                    new MailAddress(txtEmailClient.Text);
                }catch
                {
                    return "Email Invalide";
                }
            
            }
                return null;
        }

        private void FRM_Ajoute_Modifier_Client_Load(object sender, EventArgs e)
        {

        }
        public int IdSELECT;
        private void btnquitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNomClient_Enter(object sender, EventArgs e)
        {
            if(txtNomClient.Text=="Nom de Client")
            {
                txtNomClient.Text = "";
            }
        }
        
        private void txtAdresseClient_Enter(object sender, EventArgs e)
        {
            if (txtAdresseClient.Text == "Adresse de Client")
            {
                txtAdresseClient.Text = "";
            }
        }

        private void txtPaysClient_Enter(object sender, EventArgs e)
        {
            if (txtPaysClient.Text == "Pays Client")
            {
                txtPaysClient.Text = "";
            }
        }

        private void txtPrenomClient_Enter(object sender, EventArgs e)
        {
            if (txtPrenomClient.Text == "Prénom de Client")
            {
                txtPrenomClient.Text = "";
            }
        }

        private void txtTelephoneClient_Enter(object sender, EventArgs e)
        {
            if (txtTelephoneClient.Text == "Téléphone de Client")
            {
                txtTelephoneClient.Text = "";
            }
        }

        private void txtEmailClient_Enter(object sender, EventArgs e)
        {
            if (txtEmailClient.Text == "Email de Client")
            {
                txtEmailClient.Text = "";
            }
        }

       
        private void txtVilleClient_Enter(object sender, EventArgs e)
        {
            if (txtVilleClient.Text == "Ville de Client")
            {
                txtVilleClient.Text = "";
            }
        }

        private void txtNomClient_Leave(object sender, EventArgs e)
        {
            if (txtNomClient.Text == "")
            {
                txtNomClient.Text = "Nom de Client";
            }
        }

        private void txtAdresseClient_Leave(object sender, EventArgs e)
        {
            if (txtAdresseClient.Text == "")
            {
                txtAdresseClient.Text = "Adresse de Client";
            }
        }

        private void txtPaysClient_Leave(object sender, EventArgs e)
        {
            if (txtPaysClient.Text == "")
            {
                txtPaysClient.Text = "Pays Client";
            }
        }

        private void txtPrenomClient_Leave(object sender, EventArgs e)
        {
            if (txtPrenomClient.Text == "")
            {
                txtPrenomClient.Text = "Prénom de Client";
            }
        }

        private void txtEmailClient_Leave(object sender, EventArgs e)
        {
            if (txtEmailClient.Text == "")
            {
                txtEmailClient.Text = "Email de Client";
            }
        }

        private void txtTelephoneClient_Leave(object sender, EventArgs e)
        {
            if (txtTelephoneClient.Text == "")
            {
                txtTelephoneClient.Text = "Téléphone de Client";
            }
        }

        private void txtVilleClient_Leave(object sender, EventArgs e)
        {
            if (txtVilleClient.Text == "")
            {
                txtVilleClient.Text = "Ville de Client";
            }
        }

        private void txtTelephoneClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Vérifier pour le téléphone
            if(e.KeyChar<48 || e.KeyChar>57) // code asci des numéros
            {
                e.Handled = true;
            }
            if(e.KeyChar==8) //Barre d'espace
            {
                e.Handled = false;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if(this.testobligatoire()!=null)
            {
                MessageBox.Show(testobligatoire(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }else

            if(lbltitre.Text == "Ajouter Client")
            {
                BL.CLS_Client clclient = new BL.CLS_Client();
                if(clclient.Ajouter_Client(txtNomClient.Text,txtPrenomClient.Text,txtAdresseClient.Text,txtTelephoneClient.Text,txtEmailClient.Text,txtPaysClient.Text,txtVilleClient.Text)==true)
                {
                    MessageBox.Show("Client Ajouter avec succès", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usclient as USER_Liste_Client).Actualisedatagrid();
                }else
                {
                    MessageBox.Show("Nom et Prénom de client déjà existant", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else // si le lbltitre = "Modifier Client"
            {

                BL.CLS_Client clclient = new BL.CLS_Client();

                DialogResult R = MessageBox.Show("Voulez-vous vraiment modifier ce client?", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R==DialogResult.Yes)
                {
                    clclient.Modifier_Client(IdSELECT, txtNomClient.Text, txtPrenomClient.Text, txtAdresseClient.Text, txtTelephoneClient.Text, txtEmailClient.Text, txtPaysClient.Text, txtVilleClient.Text);
                    // Pour actualiser le datagridView
                    (usclient as USER_Liste_Client).Actualisedatagrid();
                    MessageBox.Show("Client Modifier avec succès", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Close();
                }else
                {
                    MessageBox.Show("Modification annulée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            //vider les textbox
            txtNomClient.Text = "Nom de Client";
            txtPrenomClient.Text = "Prénom de Client";
            txtAdresseClient.Text = "Adresse de Client";
            txtTelephoneClient.Text = "Téléphone de Client";
            txtEmailClient.Text = "Email de Client";
            txtPaysClient.Text = "Pays Client";
            txtVilleClient.Text = "Ville de Client";
        }

        
    }
}

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
    public partial class USER_Liste_Client : UserControl
    {
        private static USER_Liste_Client Userclient;
        private dbStockContext db;
        //créer une intance pour le contrôle
        public static USER_Liste_Client Instance
        {
            get
            {
                if(Userclient == null)
                {
                    Userclient = new USER_Liste_Client();
                }
                return Userclient;
            }
        }

    public USER_Liste_Client()
        {
            InitializeComponent();
            db = new dbStockContext();
            //Désactive textbox de recherche
            txtrecherche.Enabled = false;
        }

        //Fonction pour actualiser le datagridView
        public void Actualisedatagrid()
        {
            db = new dbStockContext();
            dvgclient.Rows.Clear(); // On vide le datagridview
            foreach(var S in db.Clients)
            {
                //Ajouter les lignes dans datagrid
                dvgclient.Rows.Add(false,S.ID_Client,S.Nom_Client,S.Prenom_Client, S.Adresse_Client, S.Telephone_Client, S.Email_Client, S.Ville_Client,S.Pays_Client);
            }
        }

        //Vérifier combien de lignes sont sélectionnées
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for(int i = 0; i<dvgclient.Rows.Count;i++)
            {
                if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                {
                    Nombreligneselect++;
                }
            }
            if(Nombreligneselect == 0)
            {
                return "Veuillez sélectionner le client que vous voulez modifier";
            }
            if(Nombreligneselect >1)
            {
                return "Veuillez ne sélectionner qu'un seul client à modifier";
            }
            return null;
        }

        private void USER_Liste_Client_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.Clients.ToList(); // listerecherche = liste des clients de la base de données
            if(txtrecherche.Text!="")//Si le champ n'est pas vide
            {
                switch(comborecherche.Text)
                {
                    case "Nom":
                        listerecherche = listerecherche.Where(s => s.Nom_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        //stringComparison.CurrentCultureIgnoreCase permet de pouvoir sans se soucier de la casse
                        //!=-1 ça veut dire existe dans la base de données
                        break;

                    case "Prenom":
                        listerecherche = listerecherche.Where(s => s.Prenom_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;

                    case "Telephone":
                        listerecherche = listerecherche.Where(s => s.Telephone_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Email":
                        listerecherche = listerecherche.Where(s => s.Email_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Pays":
                        listerecherche = listerecherche.Where(s => s.Pays_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                    case "Ville":
                        listerecherche = listerecherche.Where(s => s.Ville_Client.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
                        break;
                }
            }
            //on vide le datagridView
            dvgclient.Rows.Clear();
            //Ajouter listerecherche dans datagridview client
            foreach(var l in listerecherche)
            {
                dvgclient.Rows.Add(false, l.ID_Client, l.Nom_Client, l.Prenom_Client, l.Adresse_Client, l.Telephone_Client, l.Email_Client, l.Pays_Client, l.Ville_Client);
            }
        }

        private void btnajouteclient_Click(object sender, EventArgs e)
        {
            //Afficher formulaire de saisie
            PL.FRM_Ajoute_Modifier_Client frmClient = new FRM_Ajoute_Modifier_Client(this);
            frmClient.ShowDialog();
        }

        private void btnmodifclient_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajoute_Modifier_Client frmClient = new FRM_Ajoute_Modifier_Client(this);
            if(SelectVerif()==null)
            {
                for(int i = 0; i<dvgclient.Rows.Count;i++)
                {
                    if((bool)dvgclient.Rows[i].Cells[0].Value==true)// si le checkbox est coché on va afficher les informations dans le formulaire
                    {
                        frmClient.IdSELECT = (int)dvgclient.Rows[i].Cells[1].Value;
                        frmClient.txtNomClient.Text = dvgclient.Rows[i].Cells[2].Value.ToString();
                        frmClient.txtPrenomClient.Text = dvgclient.Rows[i].Cells[3].Value.ToString();
                        frmClient.txtAdresseClient.Text = dvgclient.Rows[i].Cells[4].Value.ToString();
                        frmClient.txtTelephoneClient.Text = dvgclient.Rows[i].Cells[5].Value.ToString();
                        frmClient.txtEmailClient.Text = dvgclient.Rows[i].Cells[6].Value.ToString();
                        frmClient.txtPaysClient.Text = dvgclient.Rows[i].Cells[7].Value.ToString();
                        frmClient.txtVilleClient.Text = dvgclient.Rows[i].Cells[8].Value.ToString();
                    }
                }
                frmClient.lbltitre.Text = "Modifier Client";
                frmClient.btnActualiser.Visible = false;
                frmClient.ShowDialog();
            }else
            {
                MessageBox.Show(SelectVerif(),"Modification",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnsupprimclient_Click(object sender, EventArgs e)
        {
            //Pour supprimer tous les clients sélectionnés
            int select = 0;
            BL.CLS_Client clclient = new BL.CLS_Client();
            for(int i = 0; i<dvgclient.Rows.Count;i++)
            {
                if((bool)dvgclient.Rows[i].Cells[0].Value==true)
                {
                    select++; //Permet de savoir combien de lignes ont été sélectionné
                }
            }
            if(select ==0)
            {
                MessageBox.Show("Aucun client sélectionné", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                DialogResult R = MessageBox.Show("Voulez vous vraiment supprimer?", "Supprimer", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R==DialogResult.Yes)
                {
                    //Pour supprimer tous les clients sélectionnés
                    for (int i = 0; i < dvgclient.Rows.Count; i++)
                    {
                        if ((bool)dvgclient.Rows[i].Cells[0].Value == true)
                        {
                            clclient.Supprimer_Client(int.Parse(dvgclient.Rows[i].Cells[1].Value.ToString())); //Id Client
                        }
                    }
                    //Actualisation du datagrid view
                    Actualisedatagrid();
                    MessageBox.Show("Suppression effectuée avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }else
                {
                    MessageBox.Show("Suppression annulée", "Suppression",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comborecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Activation de la textbox si j'ai choisie un champ
            txtrecherche.Enabled = true;
            txtrecherche.Text = ""; //on vide la recherche

        }

        private void txtrecherche_Leave(object sender, EventArgs e)
        {

        }
    }
}

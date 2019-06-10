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
    public partial class FRM_Connexion : Form
    {
        private dbStockContext db;
        private Form frmmenu;
        //classe connexion
        BL.CLS_Connexion C = new BL.CLS_Connexion();

       
        public FRM_Connexion(Form Menu)
        {
            InitializeComponent();
            this.frmmenu = Menu;
            //initialisation de la base de donnée
            db = new dbStockContext();
        }

        //Pour vérifier les champs obligatoires
        string testobligatoire()
        {
            if (txtNom.Text=="" || txtNom.Text=="Nom d'utilisateur") // si le nom d'utilisateur est vide ou  le text de textbos est "Nom d'utilisateur"
            {
                return "Entrer votre Nom";
            }
            if (txtmdp.Text == "" || txtmdp.Text == "Mot de Passe") // si le nom d'utilisateur est vide ou  le text de textbos est "Nom d'utilisateur"
            {
                return "Entrer votre mot de passe";
            }
            else
            {
                return null;
            }
        }
    

        private void btnquitter_Click(object sender, EventArgs e)
        {
            //Permet de quitter le formulaire
            this.Close();
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            //Pour vider le texteBox
            if(txtNom.Text == "Nom d'utilisateur")
            {
                txtNom.Text = "";
            }
        }

        private void txtmdp_Enter(object sender, EventArgs e)
        {
            if (txtmdp.Text == "Mot de Passe")
            {
                txtmdp.Text = "";
                txtmdp.UseSystemPasswordChar = false;
                txtmdp.PasswordChar = '*';
            }
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            if(txtNom.Text == "")
            {
                txtNom.Text = "Nom d'utilisateur";
            }
        }

        private void txtmdp_Leave(object sender, EventArgs e)
        {
            if (txtmdp.Text == "")
            {
                txtmdp.Text = "Mot de Passe";
                txtmdp.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.testobligatoire() == null)
            {
                if(C.ConnexionValide(db,txtNom.Text,txtmdp.Text) == true) // si l'utilisateur existe
                {
                    MessageBox.Show("Connexion a réussi", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (frmmenu as FRM_Menu).activerForm();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Connexion a échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }   
            }else
            {
                MessageBox.Show(testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

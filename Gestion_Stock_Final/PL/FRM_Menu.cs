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
    public partial class FRM_Menu : Form
    {
        public FRM_Menu()
        {
            InitializeComponent();
            panel1.Size = new Size(208, 573);
            pnlParamettre.Visible = false;
        }
        //Désactiver le formulaire
        public void desactiverForm()
        {
            btnclient.Enabled = false;
            btnproduit.Enabled = false;
            btncategorie.Enabled = false;
            btncommande.Enabled = false;
            btnutilisateur.Enabled = false;
            btndeconnecter.Enabled = false;
            pnlBut.Visible = false;
            btnconnecte.Enabled = true;
        }
        //Active le formulaire
        public void activerForm()
        {
            btnclient.Enabled = true;
            btnproduit.Enabled = true;
            btncategorie.Enabled = true;
            btncommande.Enabled = true;
            btnutilisateur.Enabled = true;
            btndeconnecter.Enabled = true;
            pnlBut.Visible = true;
            btnconnecte.Enabled = false;
            pnlParamettre.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(panel1.Size == new Size(208, 573))
            {
                panel1.Size = new Size(77, 573);
            }else
            {
                panel1.Size = new Size(208, 573);
            }
        }

        private void FRM_Menu_Load(object sender, EventArgs e)
        {
            desactiverForm();
        }

        //Permet de mettre la vue des différents UserControls dans le panel du Menu
        private void btnproduit_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnproduit.Top;
            if (!pnlafficher.Controls.Contains(USER_Liste_Produit.Instance))
            {
                pnlafficher.Controls.Add(USER_Liste_Produit.Instance);
                USER_Liste_Produit.Instance.Dock = DockStyle.Fill;
                USER_Liste_Produit.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Produit.Instance.BringToFront();
            }
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnclient.Top;
            if(!pnlafficher.Controls.Contains(USER_Liste_Client.Instance))
            {
                pnlafficher.Controls.Add(USER_Liste_Client.Instance);
                USER_Liste_Client.Instance.Dock = DockStyle.Fill;
                USER_Liste_Client.Instance.BringToFront();
            }else
            {
                USER_Liste_Client.Instance.BringToFront();
            }

        }

        private void btncategorie_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncategorie.Top;
            if (!pnlafficher.Controls.Contains(USER_Liste_Categorie.Instance))
            {
                pnlafficher.Controls.Add(USER_Liste_Categorie.Instance);
                USER_Liste_Categorie.Instance.Dock = DockStyle.Fill;
                USER_Liste_Categorie.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Categorie.Instance.BringToFront();
            }

        }

        private void btncommande_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btncommande.Top;
            if (!pnlafficher.Controls.Contains(USER_Liste_Commande.Instance))
            {
                pnlafficher.Controls.Add(USER_Liste_Commande.Instance);
                USER_Liste_Commande.Instance.Dock = DockStyle.Fill;
                USER_Liste_Commande.Instance.BringToFront();
            }
            else
            {
                USER_Liste_Commande.Instance.BringToFront();
            }
        }

        private void btnutilisateur_Click(object sender, EventArgs e)
        {
            pnlBut.Top = btnutilisateur.Top;

        }

        private void btnparametre_Click(object sender, EventArgs e)
        {
            if(pnlParamettre.Visible == true)
            {
                pnlParamettre.Visible = false;
            }else
            {
                pnlParamettre.Visible = true;
                pnlParamettre.Size = new Size(270, 101);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Afficher le formulaire de connexion
            FRM_Connexion frmC = new FRM_Connexion(this); // this = FRM_Menu
            frmC.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btndeconnecter_Click(object sender, EventArgs e)
        {
            desactiverForm();
        }
    }
}

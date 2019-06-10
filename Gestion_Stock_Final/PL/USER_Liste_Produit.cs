using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Reporting.WinForms;
using Microsoft.Office.Interop.Excel;

namespace Gestion_Stock_Final.PL
{
    public partial class USER_Liste_Produit : UserControl
    {
        private static dbStockContext db;

        private static USER_Liste_Produit Userproduit;

        //Créer une instance pour le usercontrôle
        public static USER_Liste_Produit Instance
        {
            get
            {
                if(Userproduit == null)
                {
                    Userproduit = new USER_Liste_Produit();
                }
                return Userproduit;
            }
        }
        public USER_Liste_Produit()
        {
            InitializeComponent();
            db = new dbStockContext();
            txtrecherche.Enabled = false;
        }

        //Fonction pour actualiser le datagridView de Produit
        public void Actualisedatagrid()
        {
            db = new dbStockContext();
            dvgproduit.Rows.Clear(); // On vide le datagridview
            //Pour afficher le nom de catégorie à partir de idCategorie
            Categorie Cat = new Categorie();
            foreach(var List in db.Produits)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == List.ID_Categorie); //Si l'id categorie dans categorie = idcategorie dans produit
                if(Cat != null)
                {
                    dvgproduit.Rows.Add(false, List.ID_Produit, List.Nom_Produit, List.Quantite_Produit, List.Prix_Produit, Cat.Nom_Categorie);
                }
            }
            /*//Colorer Stock vide en rouge  COLORATION STOCK
            for(int i =0; i<dvgproduit.Rows.Count;i++)
            {
                if((int)dvgproduit.Rows[i].Cells[3].Value == 0) // si le stock est égal à 0
                {
                    dvgproduit.Rows[i].Cells[3].Style.BackColor = Color.Red;
                }
                else
                {
                    dvgproduit.Rows[i].Cells[3].Style.BackColor = Color.LightGreen;

                }
            }*/
           
        }

        //Vérifier combien de lignes sont sélectionnées
        public string SelectVerif()
        {
            int Nombreligneselect = 0;
            for (int i = 0; i < dvgproduit.Rows.Count; i++)
            {
                if ((bool)dvgproduit.Rows[i].Cells[0].Value == true)
                {
                    Nombreligneselect++;
                }
            }
            if (Nombreligneselect == 0)
            {
                return "Selectionner Produit";
            }
            if (Nombreligneselect > 1)
            {
                return "Sélectionner seulement 1 Produit";
            }
            return null;
        }

        private void txtrecherche_Enter(object sender, EventArgs e)
        {
            if(txtrecherche.Text=="Recherche")
            {
                txtrecherche.Text = "";
            }
        }

        private void txtrecherche_Leave(object sender, EventArgs e)
        {

        }

        private void comborecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtrecherche.Enabled = true;
        }

        private void btnajouteproduit_Click(object sender, EventArgs e)
        {
            PL.FRM_Ajouter_Modifier_Produit frmProduit = new FRM_Ajouter_Modifier_Produit(this);
            frmProduit.ShowDialog();
        }

        private void btnmodifproduit_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            if(SelectVerif()!=null)
            {
                MessageBox.Show(SelectVerif(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                PL.FRM_Ajouter_Modifier_Produit frmProduit = new FRM_Ajouter_Modifier_Produit(this);
                frmProduit.lbltitre.Text = "Modifier Produit";
                for (int i = 0; i <dvgproduit.Rows.Count;i++) // vérifie la ligne sélectionner
                {
                    if((bool) dvgproduit.Rows[i].Cells[0].Value == true) // si la ligne est sélectionné"
                    {
                        int MYIDSELECT = (int)dvgproduit.Rows[i].Cells[1].Value; //MYIDSELECT = id de ligne sélectionner
                        PR = db.Produits.SingleOrDefault(s => s.ID_Produit == MYIDSELECT); //Vérification si l'id de produit = id sélectionner dans le datagrid View
                        if(PR != null)//if existe
                        {
                            frmProduit.comboboxcategorie.Text = dvgproduit.Rows[i].Cells[5].Value.ToString();
                            frmProduit.txtnomproduit.Text = dvgproduit.Rows[i].Cells[2].Value.ToString();
                            frmProduit.txtquantite.Text = dvgproduit.Rows[i].Cells[3].Value.ToString();
                            frmProduit.txtprix.Text = dvgproduit.Rows[i].Cells[4].Value.ToString();
                            frmProduit.IDPRODUIT = (int)dvgproduit.Rows[i].Cells[1].Value;
                            //Afficher image de produit pour modifier
                            MemoryStream MS = new MemoryStream(PR.Image_Produit); // pour convertir image de produit pour afficher dans pictbox
                            frmProduit.picProduit.Image = Image.FromStream(MS);
                        }
                        
                    }
                }
                frmProduit.btnactualiser.Visible = false;
                frmProduit.ShowDialog();
            }
            
        }

        private void USER_Liste_Produit_Load(object sender, EventArgs e)
        {
            Actualisedatagrid();
        }

        private void btnafficherphoto_Click(object sender, EventArgs e)
        {
            Produit PR = new Produit();
            if (SelectVerif() != null)
            {
                MessageBox.Show(SelectVerif(), "Selectionner", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for(int i =0; i<dvgproduit.Rows.Count;i++)//vérifie ligne sélectionner
                {
                    if((bool)dvgproduit.Rows[i].Cells[0].Value==true) //si la ligne est sélectionnée
                    {
                        int MYIDSELECT = Convert.ToInt32(dvgproduit.Rows[i].Cells[1].Value); //MYIDSELECT = id de la ligne sélectionnée
                        PR = db.Produits.SingleOrDefault(s => s.ID_Produit == MYIDSELECT); //Vérifier si id de produit = id sélectionner dans le datagridView
                        if(PR!=null) // si le produit existe
                        {
                            FRM_Photo_Produit frmphoto = new FRM_Photo_Produit();
                            //déclarer systeme.IO
                            MemoryStream MS = new MemoryStream(PR.Image_Produit); // Pour convertir image de produit pour afficher dans la pictbox
                            frmphoto.produitImage.Image = Image.FromStream(MS);
                            frmphoto.produitNom.Text = dvgproduit.Rows[i].Cells[2].Value.ToString();
                            //Afficher formulaire
                            frmphoto.ShowDialog();
                        }
                    }
                }
            }
        }

        private void btnsupprimproduit_Click(object sender, EventArgs e)
        {
            if(SelectVerif() == "Selectionner Produit")
            {
                MessageBox.Show(SelectVerif(), "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                DialogResult DR = MessageBox.Show("Vous êtes sur de vouloir supprimer", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DR == DialogResult.Yes)
                {
                    //on vérifie combien on a de lignes sélectionnées
                    for (int i = 0; i < dvgproduit.Rows.Count; i++)
                    {
                        if ((bool)dvgproduit.Rows[i].Cells[0].Value == true) //si la ligne est cochée
                        {
                            BL.CLS_Produit clproduit = new BL.CLS_Produit();
                            int idselect = (int)dvgproduit.Rows[i].Cells[1].Value;//id de la ligne cochée
                            clproduit.Supprimer_Produit(idselect);
                        }
                    }
                    //Actualisation du datagridView
                    Actualisedatagrid();
                    MessageBox.Show("Produit Supprimer avec succès", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression annulée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }

        private void txtrecherche_TextChanged(object sender, EventArgs e)
        {
            db = new dbStockContext();
            var listerecherche = db.Produits.ToList(); // listerecherche = liste des produits de la base de données

            //Recherche seulement par Nom de produit
            listerecherche = listerecherche.Where(s => s.Nom_Produit.IndexOf(txtrecherche.Text, StringComparison.CurrentCultureIgnoreCase) != -1).ToList();
            //!=-1 existe dans la base de donnée

            //Vider le datagridView
            dvgproduit.Rows.Clear();

            //Ajouter listerecherche dans datagridView Produit
            Categorie Cat = new Categorie();
            foreach(var l in listerecherche)
            {
                Cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == l.ID_Categorie); // Pour afficher le nom des catégories
                dvgproduit.Rows.Add(false, l.ID_Produit, l.Nom_Produit, l.Quantite_Produit, l.Prix_Produit, Cat.Nom_Categorie);
            }
        }

        private void btnImprimerSelection_Click(object sender, EventArgs e)
        {
            db = new dbStockContext();
            int idselect = 0;
            string Nomcategorie=null;
            RAP.FRM_RAPPORT frmrpt = new RAP.FRM_RAPPORT();
            Produit PR = new Produit();
            if(SelectVerif()!=null)
            {
                MessageBox.Show(SelectVerif(), "Imprimer Produit", MessageBoxButtons.OK, MessageBoxIcon.Error); // Permet de vérifier si l'utilisateur a coché plusieurs lignes
            }
            else
            {
                for (int i = 0; i<dvgproduit.Rows.Count; i++)
                {
                    if((bool) dvgproduit.Rows[i].Cells[0].Value==true) // si la ligne est cochée
                    {
                        idselect = (int)dvgproduit.Rows[i].Cells[1].Value; // id de la ligne sélectionnée
                        Nomcategorie = dvgproduit.Rows[i].Cells[5].Value.ToString(); // nom catégorie de la ligne sélectionnée
                    }
                    ////////////////////////////////////////
                    PR = db.Produits.SingleOrDefault(s => s.ID_Produit == idselect);
                    if(PR != null) //si le produit existe
                    {
                        //Donner le rapport
                        frmrpt.RPAfficher.LocalReport.ReportEmbeddedResource = "Gestion_Stock_Final.RAP.RPT_Produit.rdlc"; //Chemin de rapport
                        //Ajouter using Microsoft.Reporting.Winforms
                        ReportParameter Pcategorie = new ReportParameter("RPCategorie",Nomcategorie); //Nom de Categorie
                        ReportParameter PNom = new ReportParameter("RPNom",PR.Nom_Produit); //Nom de Categorie
                        ReportParameter Pquantite = new ReportParameter("RPQuantité", PR.Quantite_Produit.ToString());//Quantité
                        ReportParameter PPrix = new ReportParameter("RPPrix", PR.Prix_Produit);//Prix
                        //Image de Produit
                        string ImageString = Convert.ToBase64String(PR.Image_Produit);
                        ReportParameter Pimage = new ReportParameter("RPImage", ImageString); // Image doit être converti en string base64
                        //Sauvegarder les nouveaux paramètres dans le rapport
                        frmrpt.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { Pcategorie, PNom, Pquantite, PPrix, Pimage });
                        frmrpt.RPAfficher.RefreshReport();
                        frmrpt.ShowDialog(); //Affiche le rapport

                    
                        
                    }
                }
            }

        }

        private void btnimprimertout_Click(object sender, EventArgs e)
        {
            RAP.FRM_RAPPORT frmrpt = new RAP.FRM_RAPPORT();
            db = new dbStockContext();
            try
            {
                var listeProduit = db.Produits.ToList(); //Récupère la liste de tous les produits
                frmrpt.RPAfficher.LocalReport.ReportEmbeddedResource = "Gestion_Stock_Final.RAP.RPT_LISTES_PRODUITS.rdlc"; //chemin du rapport
                //On ajoute la data Source
                frmrpt.RPAfficher.LocalReport.DataSources.Add(new ReportDataSource("databaseproduit", listeProduit)); //on lui donne la liste des produits
                ReportParameter date = new ReportParameter("Date", DateTime.Now.ToString()); //Date Système
                frmrpt.RPAfficher.LocalReport.SetParameters(new ReportParameter[] { date });
                frmrpt.RPAfficher.RefreshReport();
                frmrpt.ShowDialog();
            }catch(Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
            

        }

        //BOUTON EXCEL
        private void btnexcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SFD = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", ValidateNames = true }) //Filtrer seulement les fichiers excel
            {
                if(SFD.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                    Workbook wb = app.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet ws = (Worksheet)app.ActiveSheet;
                    app.Visible = false;
                    //Ajouter les lignes de fichier excel
                    ws.Cells[1, 1] = "Id Produit";
                    ws.Cells[1, 2] = "Nom Produit";
                    ws.Cells[1, 3] = "Quantité";
                    ws.Cells[1, 4] = "Prix";
                    //Ajouter liste de produit de base de données dans fichier excel
                    var ListeProduit = db.Produits.ToList(); //listes de produit
                    int i = 2;
                    foreach (var L in ListeProduit)
                    {
                        //Rajoute dans les cellules d'Excel
                        ws.Cells[i, 1] = L.ID_Produit;
                        ws.Cells[i, 2] = L.Nom_Produit;
                        ws.Cells[i, 3] = L.Quantite_Produit;
                        ws.Cells[i, 4] = L.Prix_Produit;
                        i++;
                    }
                    //Changer le style de fichier
                    ws.Range["A1:D1"].Interior.Color = Color.Teal;
                    wb.SaveAs(SFD.FileName); //Sauvegarder dans fichier excel
                    app.Quit();
                    MessageBox.Show("Sauvegardé avec succes dans Excel", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Pour actualiser le datagridview
            Actualisedatagrid();
        }
    }
}

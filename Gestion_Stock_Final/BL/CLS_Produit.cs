using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_Final.BL
{
    class CLS_Produit
    {
        private dbStockContext db = new dbStockContext();
        private Produit P;
        //Fonction qui ajoute Produit
        public bool Ajouter_Produit(string NomP, int quantite, string prix, byte[] imageP, int idcategorie) //Pour sauvegarder une image dans la bdd elle doit être dans le format byte
        {
            P = new Produit();
            P.Nom_Produit = NomP;
            P.Quantite_Produit = quantite;
            P.Prix_Produit = prix;
            P.Image_Produit = imageP;
            P.ID_Categorie = idcategorie;
            //Vérifier si le produit existe déjà
            if(db.Produits.SingleOrDefault(a=>a.Nom_Produit==NomP)==null)//si il n'existe pas
            {
                db.Produits.Add(P);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        //Fonnction pour modifier Produit
        public void Modifier_Produit(int idP, string NomP, int quantite, string prix, byte[] imageP, int idcategorie)
        {
            P = new Produit();
            P = db.Produits.SingleOrDefault(s => s.ID_Produit == idP); // On vérifie si le produit existe dans la base de donnée
            if(P!=null) //si le produit existe
            {
                P.Nom_Produit = NomP;
                P.Quantite_Produit = quantite;
                P.Prix_Produit = prix;
                P.Image_Produit = imageP;
                P.ID_Categorie = idcategorie;
                db.SaveChanges();

            }
        }

        public void Supprimer_Produit(int idP)
        {
            P = new Produit();
            P = db.Produits.SingleOrDefault(s => s.ID_Produit == idP);
            if(P!= null)
            {
                db.Produits.Remove(P);
                db.SaveChanges();
            }
        }
    }

}

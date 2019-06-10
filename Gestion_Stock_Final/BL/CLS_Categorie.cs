using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_Final.BL
{
    class CLS_Categorie
    {
        private dbStockContext db = new dbStockContext();
        private Categorie cat; //Table Catégorie

        //Fonction ajouter Catégorie

        public bool Ajouter_Categorie(string nomCat)
        {
            cat = new Categorie();
            cat.Nom_Categorie = nomCat;
            //On vérifie si le nom de la catégorie n'existe pas déja dans la base 

            if(db.Categories.SingleOrDefault(s=>s.Nom_Categorie == nomCat) == null) //si ça n'existe pas
            {
                db.Categories.Add(cat);
                db.SaveChanges();
                return true;
            }
            return false;
            
        }

        public void Modifier_Categorie(int idCategorie, string nomCategorie)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == idCategorie);
            if(cat != null) // s'il existe
            {
                cat.Nom_Categorie = nomCategorie;
                db.SaveChanges();
            }
            
        }

        public void Supprimer_Categorie(int idCategorie)
        {
            cat = new Categorie();
            cat = db.Categories.SingleOrDefault(s => s.ID_Categorie == idCategorie);
            if (cat != null)
            {
                db.Categories.Remove(cat);
                db.SaveChanges();
            }
        }
    }
}

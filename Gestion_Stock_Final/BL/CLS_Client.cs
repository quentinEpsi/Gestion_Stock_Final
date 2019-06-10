using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_Final.BL
{
    class CLS_Client
    {
        private dbStockContext db = new dbStockContext();
        private Client C; //Table Client

        //fonction pour ajouter Client dans la base de donnée

        public bool Ajouter_Client(string nom, string prenom, string adresse, string telephone, string email, string pays, string ville)
        {
            C = new Client(); //Nouveau Client
            C.Nom_Client = nom;
            C.Prenom_Client = prenom;
            C.Adresse_Client = adresse;
            C.Telephone_Client = telephone;
            C.Email_Client = email;
            C.Pays_Client = pays;
            C.Ville_Client = ville;
            //Vérifier si le nom et le prénom existe déjà dans la base de donnée
            if(db.Clients.SingleOrDefault(s=>s.Nom_Client ==nom && s.Prenom_Client == prenom)==null) //s'il n'existe pas
            {
                db.Clients.Add(C); // On ajoute le client dans la table Client
                db.SaveChanges(); // Enregistrement dans la base de données
                return true;
            }else //s'il existe déjà dans la base de donnée
            {
                return false;
            }
        }

        // Fonction pour modifier Client dans la base de donnée
        public void Modifier_Client(int id, string nom, string prenom, string adresse, string telephone, string email, string pays, string ville)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id); // on vérifie si l'id client est présent dans la base
            if (C!=null)// s'il existe
            {
                C.Nom_Client = nom;
                C.Prenom_Client = prenom;
                C.Adresse_Client = adresse;
                C.Telephone_Client = telephone;
                C.Email_Client = email;
                C.Pays_Client = pays;
                C.Ville_Client = ville;
                db.SaveChanges(); // Sauvegarde les données dans la base de données
            }
        }

        public void Supprimer_Client(int id)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id); // je vérifie si l'id client est présent dans la base
            if (C!=null)
            {
                db.Clients.Remove(C); //On supprime le client
                db.SaveChanges();
            }
        }
    }
}

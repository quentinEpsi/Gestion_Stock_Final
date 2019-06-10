﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Stock_Final.BL
{
    class CLS_Connexion
    {
        //fonction pour vérifier la connexion
        public bool ConnexionValide(dbStockContext db, string Nom, string Mot_de_passe)
        {
            Utilisateur U = new Utilisateur();
            U.Nom_Utilisateur = Nom;
            U.Mot_De_Passe = Mot_de_passe;
            if(db.Utilisateurs.SingleOrDefault(s=>s.Nom_Utilisateur == Nom && s.Mot_De_Passe == Mot_de_passe)!=null) //si l'utilisateur et le mot de passe existe dans la bdd
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}

//-----------------------------------------------------------
// Fichier: Personnel.cs    Auteur: Simon DÉSAULNIERS
//                                  Christophe Diammond
//                                  Daniel St-Pierre
//                                  Jordan Blanchette
//-----------------------------------------------------------
// Classe représentant une personne remplissant la tâche
// d'un certain type de personnel.
//-----------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Personnel : DonneeBD
    {
        // Variables d'instances
        public string Nom{get ; set;}
        public string Courriel { get; set; }
        public DateTime DateNaissance { get; set; }

        //----------------
        // Constructeurs
        //----------------
        public Personnel(string nom, DateTime dateNaissance, string courriel)
        {
            this.Nom = nom;
            this.Courriel = courriel;
            this.DateNaissance = dateNaissance;
        }
        public Personnel(int id, string nom, DateTime dateNaissance, string courriel )
        {
            this.Nom = nom;
            this.Courriel = courriel;
            this.DateNaissance = dateNaissance;
            this.Id = id;
        }


        
    }
}

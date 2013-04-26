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
        private string nom,courriel,dateNaissance;

        //----------------
        // Constructeurs
        //----------------
        public Personnel(string nom, string courriel, string dateNaissance)
        {
            this.nom = nom;
            this.courriel = courriel;
            this.dateNaissance = dateNaissance;
        }
        public Personnel(string nom, string courriel, string dateNaissance, int id)
        {
            this.nom = nom;
            this.courriel = courriel;
            this.dateNaissance = dateNaissance;
            this.Id = id;
        }


        // Accesseurs, mutateurs
        public string Nom
        {
            get
            {
                return this.nom;
            }
        }

        public string Courriel
        {
            get
            {
                return this.courriel;
            }
        }

        public string DateNaissance
        {
            get
            {
                return this.dateNaissance;
            }
        }
        //----------------------
    }
}

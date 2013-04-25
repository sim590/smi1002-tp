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

        // Constructeur
        public Personnel(int id, string nom, string courriel, string dateNaissance)
        {
            this.id = id;
            this.nom = nom;
            this.courriel = courriel;
            this.dateNaissance = dateNaissance;
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

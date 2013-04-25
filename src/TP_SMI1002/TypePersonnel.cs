//-----------------------------------------------------------
// Fichier: TypePersonnel.cs    Auteur: Simon DÉSAULNIERS
//                                      Christophe Diammond
//                                      Daniel St-Pierre
//                                      Jordan Blanchette
//-----------------------------------------------------------
// Classe représentant un type de personnel requis pour
// l'événement (p. ex: technicien serveurs, animation, etc).
//-----------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class TypePersonnel : DonneeBD
    {
        // Variables d'instances
        private int couleur;
        private string nom;

        // Constructeur
        public TypePersonnel(byte A, byte R, byte G, byte B, string nom)
        {
            this.couleur = A*6*0x10+R*4*0x10+G*2*0x10+B; // Entier codé selon le standard ARGB (4*1octet = 4octet = sizeof(int))
            this.nom = nom;
        }

        // Accesseurs, mutateurs
        public int Couleur
        {
            get
            {
                return this.couleur;
            }
        }

        public string Nom
        {
            get
            {
                return this.nom;
            }
        }
        //------------------------
    }
}

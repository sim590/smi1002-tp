//-----------------------------------------------------
// Fichier: InterfaceBD.cs  Auteur: Simon DÉSAULNIERS
//                                  Daniel St-Pierre
//
//-----------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class TypeJeu : DonneeBD
    {
        public string NomTypeJeu {get; set;}

        //constructeur
        public TypeJeu(string NomTypeJeu)
        {
            this.NomTypeJeu = NomTypeJeu;
        }

        public TypeJeu(int Id, string NomTypeJeu)
        {
            this.Id = Id;
            this.NomTypeJeu = NomTypeJeu;
        }

        //override ToString
        public override string ToString()
        {
            return this.NomTypeJeu;
        }
    }
}

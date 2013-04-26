using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class TypeJeu :DonneeBD
    {
        string NomTypeJeu {get; set;}

        //constructeur
        public TypeJeu(string NomTypeJeu)
        {
            this.NomTypeJeu = NomTypeJeu;
        }

        //override ToString
        public override string ToString()
        {
            return this.NomTypeJeu;
        }
    }
}

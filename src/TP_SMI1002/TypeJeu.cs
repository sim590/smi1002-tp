using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class TypeJeu : DonneeBD
    {
        int ID{get; set;}
        string NomTypeJeu {get; set;}
        public TypeJeu(int ID, string NomTypeJeu)
        {
            this.ID = ID;
            this.NomTypeJeu = NomTypeJeu;
        }

        public override string ToString()
        {
            return this.NomTypeJeu;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Jeu : DonneeBD
    {       
        String Nom {get; set;}
        int IDTypeJeu{get; set;}
        public Jeu(String Nom,int IDTypeJeu)
        {
            this.Nom = Nom;
            this.IDTypeJeu = IDTypeJeu;
        }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}


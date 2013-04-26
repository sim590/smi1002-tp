using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Equipe : DonneeBD
    {
        public string nom {get; set;}
        public string siteWeb{get; set;}        

        //------------------------------------------------------
        // Constructeur
        //------------------------------------------------------
        public Equipe(int id, string nom, string siteWeb)
        {
            this.nom = nom;
            this.siteWeb = siteWeb;
        }

        public override string ToString()
        {
            return this.nom + "\t" + this.siteWeb;
        }
    }
}

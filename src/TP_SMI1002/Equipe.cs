using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Equipe : DonneeBD
    {
        public string Nom {get; set;}
        public string SiteWeb{get; set;}

        //------------------------------------------------------
        // Constructeur
        //------------------------------------------------------
        public Equipe(string nom, string siteWeb)
        {
            this.Nom = nom;
            this.SiteWeb = siteWeb;
        }

        public Equipe(int Id, string Nom, string SiteWeb)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.SiteWeb = SiteWeb;
        }

        public override string ToString()
        {
            return this.Nom + "\t" + this.SiteWeb;
        }
    }
}

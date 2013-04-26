using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Joueur : DonneeBD
    {
        public string Nom{get; set;}
        public string GamerTag { get; set; }
        public string Courriel { get; set; }
        public string Sexe { get; set; }
        public DateTime Date { get; set; }

        //------------------------------------------------------
        // Constructeur
        //------------------------------------------------------
        public Joueur(string nom, string gamerTag, string courriel, string sexe, DateTime date)
        {
            this.Nom = nom;
            this.GamerTag = gamerTag;
            this.Courriel = courriel;
            this.Sexe = sexe;
            this.Date = date;
        }

        public override string ToString()
        {
            return this.Nom + "\t" + this.GamerTag + "\t" + this.Courriel + "\t" + this.Sexe + "\t" + this.Date;
        }

    }
}

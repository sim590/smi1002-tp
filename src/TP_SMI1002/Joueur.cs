using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Joueur : DonneeBD
    {
        private string Nom{get; set;}
        private string GamerTag { get; set; }
        private string Courriel { get; set; }
        public string sexe;
        public DateTime date;

        public Joueur(string nom, string gamerTag, string courriel, string sexe, DateTime date)
        {
            this.Nom = nom;
            this.GamerTag = gamerTag;
            this.Courriel = courriel;
            this.sexe = sexe;
            this.date = date;
        }

        public override string ToString()
        {
            return this.Nom + "\t" + this.GamerTag + "\t" + this.Courriel + "\t" + this.sexe + "\t" + this.date;
        }

    }
}

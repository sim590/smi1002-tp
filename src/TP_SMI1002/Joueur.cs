using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Joueur : DonneeBD
    {
        public string Nom { get; set; }
        public string GamerTag { get; set; }
        public string Courriel { get; set; }
        public string Sexe {get; set; }
        public DateTime Date {get; set;}

        //------------------------------------------------------
        // Constructeur
        //------------------------------------------------------
        public Joueur(string Nom, string GamerTag, string Courriel, string Sexe, DateTime Date)
        {
            this.Nom = Nom;
            this.GamerTag = GamerTag;
            this.Courriel = Courriel;
            this.Sexe = Sexe;
            this.Date = Date;
        }

        public Joueur(int Id, string Nom, string GamerTag, string Courriel, string Sexe, DateTime Date)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.GamerTag = GamerTag;
            this.Courriel = Courriel;
            this.Sexe = Sexe;
            this.Date = Date;
        }

        public override string ToString()
        {
            return this.Nom + "\t" + this.GamerTag + "\t" + this.Courriel + "\t" + this.Sexe + "\t" + this.Date;
        }

    }
}

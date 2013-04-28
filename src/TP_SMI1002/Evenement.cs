using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{

    class Evenement : DonneeBD
    {
        public string Nom {get; set; }
        public DateTime Debut {get; set;}
        public DateTime Fin {get; set;}
        public string Lieu {get; set;}
        public string Adresse {get; set;}
        public int NbrPlace {get; set;}
        public double Prix { get; set; }

        public Evenement(int Id, string Nom, DateTime Debut, DateTime Fin, string Lieu, string Adresse, int NbrPlace, Double Prix)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Debut = Debut;
            this.Fin = Fin;
            this.Lieu = Lieu;
            this.Adresse = Adresse;
            this.NbrPlace = NbrPlace;
            this.Prix = Prix;
        }

        public Evenement(string Nom, DateTime Debut, DateTime Fin, string Lieu, string Adresse, int NbrPlace, Double Prix)
        {
            this.Nom = Nom;
            this.Debut = Debut;
            this.Fin = Fin;
            this.Lieu = Lieu;
            this.Adresse = Adresse;
            this.NbrPlace = NbrPlace;
            this.Prix = Prix;
        }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}

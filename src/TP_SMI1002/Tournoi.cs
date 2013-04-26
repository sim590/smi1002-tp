using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Tournoi : DonneeBD
    {
        public int IdTournoi { get; set; }
        public int nbJoueur { get; set; }
        public int IdJeu { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public int idEvenement { get; set; }
        public String Nom { get; set; }

        public Tournoi(int IdTournoi, int nbJoueur, int IdJeu, DateTime dateDebut, DateTime dateFin, int IdEvenement, string Nom)
        {
            this.IdTournoi = IdTournoi;
            this.nbJoueur = nbJoueur;
            this.IdJeu = IdJeu;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.idEvenement = idEvenement;
            this.Nom = Nom;
        }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}

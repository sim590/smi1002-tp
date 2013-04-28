using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Tournoi : DonneeBD
    {
        public int nbJoueur { get; set; }
        public int IdJeu { get; set; }
        public DateTime dateDebut { get; set; }
        public DateTime dateFin { get; set; }
        public int idEvenement { get; set; }
        public String Nom { get; set; }

        //----------------
        // Constructeurs
        //----------------
        public Tournoi(int nbJoueur, int IdJeu, DateTime dateDebut, DateTime dateFin, int IdEvenement, string Nom)
        {
            this.nbJoueur = nbJoueur;
            this.IdJeu = IdJeu;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
            this.idEvenement = idEvenement;
            this.Nom = Nom;
        }
        //...
        public Tournoi(int Id, int nbJoueur, int IdJeu, DateTime dateDebut, DateTime dateFin, int IdEvenement, string Nom)
        {
            this.Id = Id;
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

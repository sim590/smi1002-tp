using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Jeu : DonneeBD
    {       
        public String Nom {get; set;}
        public int IDTypeJeu{get; set;}

        public Jeu(String Nom,int IDTypeJeu)
        {
            this.Nom = Nom;
            this.IDTypeJeu = IDTypeJeu;
        }
        public Jeu(int Id, String Nom, int IDTypeJeu)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.IDTypeJeu = IDTypeJeu;
        }

        public override string ToString()
        {
            return this.Nom;
        }
    }

    class JeuAvecType : Jeu
    {
        public String TypeJeu { get; set; }

        public JeuAvecType(int Id, String Nom, int IDTypeJeu, string TypeJeu)
            :base(Id, Nom, IDTypeJeu)
        {
            this.TypeJeu = TypeJeu;
        }
    }

}


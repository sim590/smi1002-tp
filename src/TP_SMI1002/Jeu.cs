using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Jeu : DonneeBD
    {       
        public string Nom {get; set;}
        public int IDTypeJeu{get; set;}

        //----------------
        // Constructeurs
        //----------------
        public Jeu(String Nom,int IDTypeJeu)
        {
            this.Nom = Nom;
            this.IDTypeJeu = IDTypeJeu;
        }
        //...
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

        /*
         * Implémenter le predicate<T> afin d'utiliser
         * la méthode find de List<Jeu>.. http://msdn.microsoft.com/fr-fr/library/vstudio/x0b5b5bc.aspx
         */
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


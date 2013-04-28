using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class Personnel : DonneeBD
    {
        // Variables d'instances
        public string Nom{get ; set;}
        public string Courriel { get; set; }
        public DateTime DateNaissance { get; set; }

        //----------------
        // Constructeurs
        //----------------
        public Personnel(string nom, DateTime dateNaissance, string courriel)
        {
            this.Nom = nom;
            this.Courriel = courriel;
            this.DateNaissance = dateNaissance;
        }
        public Personnel(int id, string nom, DateTime dateNaissance, string courriel )
        {
            this.Nom = nom;
            this.Courriel = courriel;
            this.DateNaissance = dateNaissance;
            this.Id = id;
        }        
    }

    class PersonnelAvecType : Personnel
    {
        public string TypePersonnel { get; set; }

        public PersonnelAvecType(int id, string nom, DateTime dateNaissance, string courriel, string typePersonnel)
            :base(id, nom, dateNaissance, courriel)
        {
            this.TypePersonnel = typePersonnel;
        }
            
    }
}

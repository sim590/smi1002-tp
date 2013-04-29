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
        public int IdTypePersonnel { get; set; }

        //----------------
        // Constructeurs
        //----------------
        public Personnel(string nom, DateTime dateNaissance, string courriel, int idTypePersonnel)
        {
            this.Nom = nom;
            this.Courriel = courriel;
            this.DateNaissance = dateNaissance;
            this.IdTypePersonnel = idTypePersonnel;
        }
        public Personnel(int id, string nom, DateTime dateNaissance, string courriel, int idTypePersonnel)
        {
            this.Nom = nom;
            this.Courriel = courriel;
            this.DateNaissance = dateNaissance;
            this.Id = id;
            this.IdTypePersonnel = idTypePersonnel;
        }        
    }

    class PersonnelAvecType : Personnel
    {
        public string TypePersonnel { get; set; }

        public PersonnelAvecType(int Id, string Nom, DateTime dateNaissance, string Courriel, int idTypePersonnel, string TypePersonnel)
            : base(Id, Nom, dateNaissance, Courriel, idTypePersonnel)
        {
            this.TypePersonnel = TypePersonnel;
        }

    }
}

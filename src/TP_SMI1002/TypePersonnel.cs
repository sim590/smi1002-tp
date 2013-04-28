using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    class TypePersonnel : DonneeBD
    {
        // Variables d'instances
        public int Couleur { get; set; }
        public string Nom { get; set; }
        

        //----------------
        // Constructeurs
        //----------------
        public TypePersonnel(byte A, byte R, byte G, byte B, string nom)
        {
            this.Couleur = (A << 24) + (R << 16) + (G << 8) + B; // Entier codé selon le standard ARGB (4*1octet = 4octet = sizeof(int))
            this.Nom = nom;
        }
        public TypePersonnel(byte A, byte R, byte G, byte B, string nom, int id)
        {
            this.Couleur = (A << 24) + (R << 16) + (G << 8) + B; // Entier codé selon le standard ARGB (4*1octet = 4octet = sizeof(int))
            this.Nom = nom;
            this.Id = id;
        }

        public TypePersonnel(string nom, int couleur)
        {
            this.Couleur = couleur;
            this.Nom = nom;
        }

        public TypePersonnel(int id, string nom, int couleur)
        {
            this.Couleur = couleur;
            this.Nom = nom;
            this.Id = id;
        }

        public override string ToString()
        {
            return this.Nom;
        }
    }
}

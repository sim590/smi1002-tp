//-----------------------------------------------------
// Fichier: DonneeBD.cs     Auteur: Simon DÉSAULNIERS
//
//-----------------------------------------------------
// Donnée ajoutable à une base de données
//-----------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP_SMI1002
{
    abstract class DonneeBD
    {
        // Variables d'instance
        protected int Id { get; set; }

        //---------------
        // Constructeur
        //---------------
        public DonneeBD()
        {

        }
    }
}

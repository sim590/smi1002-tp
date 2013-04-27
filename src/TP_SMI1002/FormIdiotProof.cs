//------------------------------------------------------------
// Fichier: FormIdiotProof.cs   Auteur(s): Simon DÉSAULNIERS
//
//------------------------------------------------------------
// Une fenêtre à l'épreuve des idiots..
//------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TP_SMI1002
{
    public class FormIdiotProof : Form
    {
        // On ne veut pas instancier cette classe
        protected FormIdiotProof() { }

        //----------------------------------
        // Vérifie que le nom entré est 
        // vrai-semblablement un nom.
        //----------------------------------
        protected bool estNomValide(string nom)
        {
            //-------------------------------------------
            // Vérifie que le string est composé que de 
            // lettres.
            //-------------------------------------------
            if (!Regex.IsMatch(nom, @"^[a-zA-Z]+$"))
                return false;
            return true;
        }

        /*
         * Ajouter les méthodes de vérifications
         * d'idiots redondantes..
         * 
         */
    }
}

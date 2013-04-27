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
            // 2 à 20 lettres et/ou accents et/ou "-"
            //-------------------------------------------
            if (!Regex.IsMatch(nom, @"^[a-zA-ZéèàêïÉÈÀÊ-]{2,20}+$"))
                return false;
            return true;
        }

        //-------------------------------------------
        // TODO: est-ce que c'est seulement à la création d'un joueur qu'on demande le courriel ?
        // Vérifie que le courriel entré est
        // vrai-semblablement un courriel
        //-------------------------------------------
        protected bool estCourrielValide(string courriel)
        {
            //-------------------------------------------
            // TODO: est-ce possible d'avoir un accent ou caracteres speciaux dans un adresse courriel ?!
            // Vérifie que le string est composé d'une 
            // chaîne de caractère puis @ puis une autre chaîne de caractere suivi de . puis com|ca|org|qc.ca
            //-------------------------------------------
            if(!Regex.IsMatch(courriel, @"^[a-zA-Z0-9_]+@+[a-zA-Z0-9_]+.+[com|ca|org|qc.ca]$"))
                return false;
            return true;
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormIdiotProof
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "FormIdiotProof";
            this.Load += new System.EventHandler(this.FormIdiotProof_Load);
            this.ResumeLayout(false);

        }

        private void FormIdiotProof_Load(object sender, EventArgs e)
        {

        }

        /*
         * Ajouter les méthodes de vérifications
         * d'idiots redondantes..
         * 
         */
    }
}

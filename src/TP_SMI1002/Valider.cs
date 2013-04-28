using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace TP_SMI1002
{
    public static class Valider
    {
        public static bool estCourrielValide(string courriel)
        {
            // string non-vide
            if (courriel.Length == 0)
                return false;
            //--------------------------------------------------------
            // TODO: est-ce possible d'avoir un accent ou caracteres 
            // speciaux dans un adresse courriel ?!
            // Vérifie que le string est composé d'une 
            // chaîne de caractère puis @ puis une autre chaîne de 
            // caractere suivi de . puis com|ca|org|qc.ca
            //--------------------------------------------------------
            if (!Regex.IsMatch(courriel, @"^[a-zA-Z0-9_\-\.]+@+[a-zA-Z0-9_]+\."))
                return false;
            return true;
        }

        public static bool estNomValide(string nom)
        {
            // String non-vide
            if (nom.Length == 0)
                return false;
            //-------------------------------------------
            // Vérifie que le string est composé que de 
            // 2 à 20 lettres et/ou accents et/ou "-"
            //-------------------------------------------
            if (!Regex.IsMatch(nom, @"^[a-zA-ZéèàêïÉÈÀÊ -]{2,}$"))
                return false;
            return true;
        }
    }
}

//-----------------------------------------------------
// Fichier: InterfaceBD.cs  Auteur: Simon DÉSAULNIERS
//
//-----------------------------------------------------
// Singleton gérant l'ajout, la modification et la
// suppression de données dans la BD
//-----------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

namespace TP_SMI1002
{
    class InterfaceBD
    {
        // Variables d'instance
        private static InterfaceBD instance;
        private OracleConnection cnLanUQTR;
        public static string connectionString;

        //----------------
        // Constructeur 
        //----------------
        private InterfaceBD()
        {
            cnLanUQTR = new OracleConnection(connectionString);
        }

        //---------------------------------
        // Permet la création d'une seule
        // instance de InterfaceBD
        //---------------------------------
        public static InterfaceBD accesInstance()
        {
            if (instance == null)
            {
                instance = new InterfaceBD();
            }
            return instance;
        }

        //-------------------------------------------
        // Ajout d'une donnée à la base de données
        //-------------------------------------------
        public int ajoutBD(DonneeBD donnee)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            string cmdString;

            cnLanUQTR.Open();

            if (donnee is Personnel)
            {

                //cmdString = "insert into personnel (id, nom, fatest) values(" + (DonneeBD))"
            }
            else if (donnee is TypePersonnel)
            {

            }
            else if (donnee is Equipe)
	        {
		        
	        }
            else if (donnee is Joueur)
	        {
	        	 
	        }
            else if (donnee is TypeJeu)
            {

            }
            
            // Envoie la commande
            cmd.ExecuteReader();

            // Fermeture de la connexion
            cnLanUQTR.Close();
        }

        public int modifierBD(DonneeBD donnee)
        {

        }

        public int supprimmerDansBD
    }
}

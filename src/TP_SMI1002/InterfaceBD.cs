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
        public static string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=neptune.uqtr.ca)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=coursbd)));User Id=SMI1002_37;Password=86nsed58;";

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


        //TODO:
        //-------------------------------------------
        // Ajout d'une donnée à la base de données
        //-------------------------------------------
        public int ajoutBD(DonneeBD donnee)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;
            string cmdString="";
            int rangesEcrites;

            // Ouverture d'une connexion
            cnLanUQTR.Open();

            // Ajout d'un personnel
            if (donnee is Personnel)
            {
                cmdString = "INSERT INTO PERSONNEL {VALUES ('','"+
                                                ((Personnel)donnee).Nom+"','"+
                                                ((Personnel)donnee).DateNaissance+"','"+
                                                ((Personnel)donnee).Courriel+"')}";
            }
            // Ajout d'un type de personnel
            else if (donnee is TypePersonnel)
            {
                
            }
            // Ajout d'une équipe
            else if (donnee is Equipe)
	        {
		        
	        }
            // Ajout d'un joueur
            else if (donnee is Joueur)
	        {
	        	 
	        }
            // Ajout d'un type de jeu
            else if (donnee is TypeJeu)
            {

            }
            // Ajout d'un jeu
            else if (donnee is Jeu)
            {

            }
            // Ajout d'un tournoi
            else if (donnee is Tournoi)
            {

            }

            // Ajout de la commande à la query
            cmd.CommandText = cmdString;

            // Envoie la commande
            rangesEcrites = cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            cnLanUQTR.Close();
            
            // Une erreur est survenue
            if (rangesEcrites == -1)
                return -1;

            return rangesEcrites;
        }

    }
}

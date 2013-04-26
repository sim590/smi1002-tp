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

        public int supprimmerDansBD(DonneeBD donnee)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            string cmdString;

            cnLanUQTR.Open();

            //suppression d'un objet Personnel
            if (donnee is Personnel)
            {
                cmdString = @"DELETE FROM PERSONNEL WHERE ID=" + ((Personnel)donnee).Id;   
            }
            //suppression d'un objet TypePersonnel
            else if (donnee is TypePersonnel)
            {
                cmdString = @"DELETE FROM TYPEPERSONNEL WHERE ID=" + ((TypePersonnel)donnee).Id;
            }
            //suppression d'un objet Equipe
            else if (donnee is Equipe)
            {
                cmdString = @"DELETE FROM EQUIPE WHERE ID=" + ((Equipe)donnee).Id;
            }
            //suppression d'un objet Joueur
            else if (donnee is Joueur)
            {
                cmdString = @"DELETE FROM JOUEUR WHERE ID=" + ((Joueur)donnee).Id;
            }
            //suppression d'un objet Jeu
            else if (donnee is Jeu)
            {
                cmdString = @"DELETE FROM JEU WHERE ID=" + ((Jeu)donnee).Id;
            }
            //suppression d'un objet TypeJeu
            else if (donnee is TypeJeu)
            {
                cmdString = @"DELETE FROM TYPEJEU WHERE ID=" + ((TypeJeu)donnee).Id;
            }
            //suppression d'un objet Evenement
            else if (donnee is Evenement)
            {
                cmdString = @"DELETE FROM EVENEMENT WHERE ID=" + ((Evenement)donnee).Id;
            }
            //suppression d'un objet Tournoi
            else if (donnee is Tournoi)
            {
                cmdString = @"DELETE FROM TOURNOI WHERE ID=" + ((Tournoi)donnee).Id;
            }
            //suppression d'un objet Evenement
            else if (donnee is Evenement)
            {
                cmdString = @"DELETE FROM EVENEMENT WHERE ID=" + ((Evenement)donnee).Id;
            }


            // Envoie la commande
            cmd.Connection=cnLanUQTR;

            cmd.CommandText = cmdString;

            cmd.ExecuteNonquery();

            // Fermeture de la connexion
            cnLanUQTR.Close();
        }

    }
}

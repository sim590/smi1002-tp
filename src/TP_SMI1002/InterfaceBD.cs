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

        #region ModifierBD
        public int modifierBD(DonneeBD donnee)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            string cmdString = "";

            cnLanUQTR.Open();

            if (donnee is Personnel)
            {

            }
            else if (donnee is TypePersonnel)
            {

            }
            else if (donnee is Equipe)
            {
                cmdString = "update joueur set nom = :param1, siteweb = param2 where idjoueur = :keyValue";
                cmd.CommandText = cmdString;
                cmd.Parameters.Add("param1", ((Equipe)donnee).nom);
                cmd.Parameters.Add("param2", ((Equipe)donnee).siteWeb);
                cmd.Parameters.Add("keyValue", ((Equipe)donnee).Id);
            }
            else if (donnee is Joueur)
            {
                
            }
            else if (donnee is TypeJeu)
            {

            }

            cmd.Connection = cnLanUQTR;

            // Envoie la commande
            cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            cnLanUQTR.Close();

            return 1;
        }
        #endregion

        public int supprimmerDansBD(DonneeBD donnee)
        {
            return 1;
        }
    }
}

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

        //Fonction pour remplir les différentes liste
        public void remplirListe(ref List<Equipe> lstEquipe)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;
            string cmdString = "";

            cnLanUQTR.Open();
            // Ouverture d'une connexion
            cmdString = "SELECT IDEQUIPE, SITEWEB, NOM FROM EQUIPE ORDER BY NOM";
            
            // Ajout de la commande à la query
            cmd.CommandText = cmdString;

            OracleDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                lstEquipe.Add(new Equipe(Convert.ToInt32(rs.GetOracleValue(0).ToString()), rs.GetOracleValue(1).ToString(), rs.GetOracleValue(2).ToString()));
            }
            rs.Close();           
            
            cnLanUQTR.Close();
        }

        public void remplirListe(ref List<Joueur> lstJoueur)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;
            string cmdString = "";

            cnLanUQTR.Open();
            // Ouverture d'une connexion
            cmdString = "SELECT IDJOUEUR, NOM, GAMERTAG, COURRIEL, SEXE, DATENAISSANCE  FROM JOUEUR ORDER BY NOM";

            // Ajout de la commande à la query
            cmd.CommandText = cmdString;

            OracleDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                lstJoueur.Add(new Joueur(Convert.ToInt32(rs.GetOracleValue(0).ToString()), 
                                                    rs.GetOracleValue(1).ToString(), rs.GetOracleValue(2).ToString(), 
                                                    rs.GetOracleValue(3).ToString(), rs.GetOracleValue(4).ToString(), 
                                                    Convert.ToDateTime(rs.GetOracleValue(5).ToString())));
            }
            rs.Close();

            cnLanUQTR.Close();
        }

        public void remplirListe(ref List<TypeJeu> lstTypeJeu)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;
            string cmdString = "";

            cnLanUQTR.Open();
            // Ouverture d'une connexion
            cmdString = "SELECT IDTYPEJEU, NOM FROM TYPEJEU ORDER BY NOM";

            // Ajout de la commande à la query
            cmd.CommandText = cmdString;

            OracleDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                lstTypeJeu.Add(new TypeJeu(Convert.ToInt32(rs.GetOracleValue(0).ToString()), rs.GetOracleValue(1).ToString()));
            }
            rs.Close();

            cnLanUQTR.Close();
        }

        public void remplirListe(ref List<JeuAvecType> lstTypeJeuAvecType)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;
            string cmdString = "";

            cnLanUQTR.Open();
            // Ouverture d'une connexion
            cmdString = "SELECT J.IDJEU, J.NOM, J.IDTYPEJEU, T.NOM FROM JEU J, TYPEJEU T ORDER BY J.NOM";

            // Ajout de la commande à la query
            cmd.CommandText = cmdString;

            OracleDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                lstTypeJeuAvecType.Add(new JeuAvecType(Convert.ToInt32(rs.GetOracleValue(0).ToString()), 
                                                        rs.GetOracleValue(1).ToString(), 
                                                        Convert.ToInt32(rs.GetOracleValue(2).ToString()), 
                                                        rs.GetOracleValue(3).ToString()));
            }
            rs.Close();

            cnLanUQTR.Close();
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


        #region ModifierBD
        public int modifierBD(DonneeBD donnee)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            string cmdString = "";

            cnLanUQTR.Open();

            if (donnee is Personnel)
            {
                cmdString = "update personnel set nom = :param1, datenaissance = :param2, courriel = :param3 where idpersonnel = :keyValue";
                cmd.CommandText = cmdString;
                cmd.Parameters.Add("@param1", ((Personnel)donnee).Nom);
                cmd.Parameters.Add("@param2", ((Personnel)donnee).DateNaissance);
                cmd.Parameters.Add("@param3", ((Personnel)donnee).Courriel);
                cmd.Parameters.Add("@keyValue", ((Personnel)donnee).Id);
            }
            else if (donnee is TypePersonnel)
            {
                cmdString = "update typepersonnel set nom = :param1, couleur = :param2 where idtypepersonnel = :keyValue";
                cmd.CommandText = cmdString;
                cmd.Parameters.Add("@param1", ((TypePersonnel)donnee).Nom);
                cmd.Parameters.Add("@param2", ((TypePersonnel)donnee).Couleur);
                cmd.Parameters.Add("@keyValue", ((TypePersonnel)donnee).Id);
            }
            else if (donnee is Equipe)
            {
                cmdString = "update equipe set nom = :param1, siteweb = :param2 where idequipe = :keyValue";
                cmd.CommandText = cmdString;
                cmd.Parameters.Add("param1", ((Equipe)donnee).Nom);
                cmd.Parameters.Add("param2", ((Equipe)donnee).SiteWeb);
                cmd.Parameters.Add("keyValue", ((Equipe)donnee).Id);
            }
            else if (donnee is Joueur)
            {
                cmdString = "update joueur set nom = :param1, gamertag = :param2, courriel = :param3, sexe = :param4, datenaissance = :param5 where idjoueur = :keyValue";
                cmd.CommandText = cmdString;
                cmd.Parameters.Add("@param1", ((Joueur)donnee).Nom);
                cmd.Parameters.Add("@param2", ((Joueur)donnee).GamerTag);
                cmd.Parameters.Add("@param3", ((Joueur)donnee).Courriel);
                cmd.Parameters.Add("@param4", ((Joueur)donnee).Sexe);
                cmd.Parameters.Add("@param5", ((Joueur)donnee).Date);
                cmd.Parameters.Add("@keyValue", ((Joueur)donnee).Id);
            }
            else if (donnee is TypeJeu)
            {
                cmdString = "update typejeu set nom = :param1 where idtype = :keyValue";
                cmd.CommandText = cmdString;
                cmd.Parameters.Add("@param1", ((TypeJeu)donnee).NomTypeJeu);
                cmd.Parameters.Add("@keyValue", ((TypeJeu)donnee).Id);
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
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            string cmdString ="";

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

            cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            cnLanUQTR.Close();

            return 1;
        }
    }
}

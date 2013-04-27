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
        public static string connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=neptune.uqtr.ca)(PORT=1521)))"
                                                                +"(CONNECT_DATA=(SERVER=DEDICATED)(SID=coursbd)));User Id=SMI1002_37;Password=86nsed58;";

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

        //Fonction pour aller chercher un objet pour le modifier
        public Evenement retournerObjet(int Id)
        {
            Evenement mEvenement = null;

            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;

            // Ouverture d'une connexion
            cnLanUQTR.Open();
            cmd.CommandText = "SELECT NOM, DEBUT, FIN, LIEU, ADRESSE, NBRPLACES, PRIX FROM EVENEMENT WHERE IDEVENEMENT = :id";
            cmd.Parameters.Add("id", Id);

            OracleDataReader rs = cmd.ExecuteReader();

            try
            {
                rs.Read();
                mEvenement = new Evenement(Id,
                                            rs.GetOracleValue(0).ToString(),
                                            Convert.ToDateTime(rs.GetOracleValue(1).ToString()),
                                            Convert.ToDateTime(rs.GetOracleValue(2).ToString()),
                                            rs.GetOracleValue(3).ToString(),
                                            rs.GetOracleValue(4).ToString(),
                                            Convert.ToInt32(rs.GetOracleValue(5).ToString()),
                                            Convert.ToDouble(rs.GetOracleValue(6).ToString()));
                rs.Close();
            }
            catch
            {

            }

           
            cnLanUQTR.Close();
            return mEvenement;
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

        public void remplirListe(ref List<Evenement> lstEvenement)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;
            string cmdString = "";

            cnLanUQTR.Open();
            // Ouverture d'une connexion
            cmdString = "SELECT IDEVENEMENT, NOM, DEBUT, FIN, LIEU, ADRESSE, NBRPLACES, PRIX FROM EVENEMENT ORDER BY NOM";

            // Ajout de la commande à la query
            cmd.CommandText = cmdString;

            OracleDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                lstEvenement.Add(new Evenement(Convert.ToInt32(rs.GetOracleValue(0).ToString()),
                                                    rs.GetOracleValue(1).ToString(),
                                                    Convert.ToDateTime(rs.GetOracleValue(2).ToString()),
                                                    Convert.ToDateTime(rs.GetOracleValue(3).ToString()), 
                                                    rs.GetOracleValue(4).ToString(),
                                                    rs.GetOracleValue(5).ToString(),
                                                    Convert.ToInt32(rs.GetOracleValue(6).ToString()),
                                                    Convert.ToDouble(rs.GetOracleValue(7).ToString())));
                    

            }
            rs.Close();

            cnLanUQTR.Close();
        }

        #region ajoutBD
        //TODO: La query fonctionne pas.................
        //-------------------------------------------
        // Ajout d'une donnée à la base de données
        //-------------------------------------------
        public int ajoutBD(DonneeBD donnee)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;
            int rangesEcrites = 0;

            // Ouverture d'une connexion
            cnLanUQTR.Open();

            // Ajout d'un personnel
            if (donnee is Personnel)
            {
                cmd.CommandText = "insert into personnel (nom,datenaissance,courriel) " +
                "values (@nom,@date,@courriel)";
                cmd.Parameters.Add("@name", ((Personnel)donnee).Nom);
                cmd.Parameters.Add("@date", ((Personnel)donnee).DateNaissance);
                cmd.Parameters.Add("@courriel", ((Personnel)donnee).Courriel);
            }
            // Ajout d'un type de personnel
            else if (donnee is TypePersonnel)
            {
                cmd.CommandText = "insert into typepersonnel (nom,couleur) values (@nom,@couleur)";
                cmd.Parameters.Add("@nom", ((TypePersonnel)donnee).Nom);
                cmd.Parameters.Add("@couleur", ((TypePersonnel)donnee).Couleur);
            }
            // Ajout d'une équipe
            else if (donnee is Equipe)
	        {
                cmd.CommandText = "insert into equipe (nom,siteweb) " + "values (:nom,:siteweb)";                
                cmd.Parameters.Add("siteweb", ((Equipe)donnee).SiteWeb);
                cmd.Parameters.Add("nom", ((Equipe)donnee).Nom);
	        }
            // Ajout d'un joueur
            else if (donnee is Joueur)
	        {
                cmd.CommandText = "insert into joueur (nom,gamertag,courriel,sexe,datenaissance) "+
                    "values (:nom,:gamertag,:courriel,:sexe,:datenaissance)";
                cmd.Parameters.Add("nom", ((Joueur)donnee).Nom);
                cmd.Parameters.Add("gamertag", ((Joueur)donnee).GamerTag);
                cmd.Parameters.Add("courriel", ((Joueur)donnee).Courriel);
                cmd.Parameters.Add("sexe", ((Joueur)donnee).Sexe);
                cmd.Parameters.Add("datenaissance", ((Joueur)donnee).Date);
	        }
            // Ajout d'un type de jeu
            else if (donnee is TypeJeu)
            {
                cmd.CommandText = "insert into typejeu (nom) values (@nom)";
                cmd.Parameters.Add("@nom", ((TypeJeu)donnee).NomTypeJeu);
            }
            // Ajout d'un jeu
            else if (donnee is Jeu)
            {
                cmd.CommandText = "insert into typejeu (nom,idtypejeu) values (@nom,@idtypejeu)";
                cmd.Parameters.Add("@nom", ((Jeu)donnee).Nom);
                cmd.Parameters.Add("@idtypejeu", ((Jeu)donnee).IDTypeJeu);
            }
            // Ajout d'un tournoi
            else if (donnee is Tournoi)
            {
                cmd.CommandText = "insert into tournoi (nom,debut,fin,nbjoueurs,idjeu,idevenement) "+
                                                        "values (@nom,@debut,@fin,@nbjoueurs,@idjeu,@idevenement)";
                cmd.Parameters.Add("@nom", ((Tournoi)donnee).Nom);
                cmd.Parameters.Add("@debut", ((Tournoi)donnee).dateDebut);
                cmd.Parameters.Add("@fin", ((Tournoi)donnee).dateFin);
                cmd.Parameters.Add("@nbjoueurs", ((Tournoi)donnee).nbJoueur);
                cmd.Parameters.Add("@idjeu", ((Tournoi)donnee).IdJeu);
                cmd.Parameters.Add("@idevenement", ((Tournoi)donnee).idEvenement);
            }
            else if (donnee is Evenement)
            {
                cmd.CommandText = "insert into EVENEMENT (nom,debut,fin,LIEU,ADRESSE,NBRPLACES,PRIX) " +
                                                 "values (:nom,:debut,:fin,:lieu,:adresse,:nbrplaces, :prix)";
                cmd.Parameters.Add("nom", ((Evenement)donnee).Nom);
                cmd.Parameters.Add("debut", ((Evenement)donnee).Debut);
                cmd.Parameters.Add("fin", ((Evenement)donnee).Fin);
                cmd.Parameters.Add("lieu", ((Evenement)donnee).Lieu);
                cmd.Parameters.Add("adresse", ((Evenement)donnee).Adresse);
                cmd.Parameters.Add("nbrplaces", ((Evenement)donnee).NbrPlace);
                cmd.Parameters.Add("prix", ((Evenement)donnee).Prix); 
            }

            // Envoie la commande
            try
            {
                rangesEcrites = cmd.ExecuteNonQuery();
            }
            catch (Oracle.DataAccess.Client.OracleException)
            {
                // Fermeture de la connexion
                cnLanUQTR.Close();
                return -1;
            }

            // Fermeture de la connexion
            cnLanUQTR.Close();
            
            // Une erreur est survenue
            if (rangesEcrites == -1)
                return -1;

            return rangesEcrites;
        }
        #endregion

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
            else if (donnee is Evenement)
            {
                cmd.CommandText = "update EVENEMENT set nom = :nom, debut = :debut, fin=:fin, lieu=:lieu, adresse=:adresse, nbrplaces=:nbrplaces, prix=:prix " +
                                    "where IDEVENEMENT = :id";

                cmd.Parameters.Add("nom", ((Evenement)donnee).Nom);
                cmd.Parameters.Add("debut", ((Evenement)donnee).Debut);
                cmd.Parameters.Add("fin", ((Evenement)donnee).Fin);
                cmd.Parameters.Add("lieu", ((Evenement)donnee).Lieu);
                cmd.Parameters.Add("adresse", ((Evenement)donnee).Adresse);
                cmd.Parameters.Add("nbrplaces", ((Evenement)donnee).NbrPlace);
                cmd.Parameters.Add("prix", ((Evenement)donnee).Prix);

                cmd.Parameters.Add("id", ((Evenement)donnee).Id);
            }


            cmd.Connection = cnLanUQTR;

            // Envoie la commande
            cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            cnLanUQTR.Close();

            return 1;
        }
        #endregion

        #region SupprimerBD
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
            //suppression d'un objet Tournoi
            else if (donnee is Tournoi)
            {
                cmdString = @"DELETE FROM TOURNOI WHERE ID=" + ((Tournoi)donnee).Id;
            }
            //suppression d'un objet Evenement
            else if (donnee is Evenement)
            {
                cmdString = "DELETE FROM EVENEMENT WHERE IDEVENEMENT=" + ((Evenement)donnee).Id;
            }


            // Envoie la commande
            cmd.Connection=cnLanUQTR;

            cmd.CommandText = cmdString;

            cmd.ExecuteNonQuery();

            // Fermeture de la connexion
            cnLanUQTR.Close();

            return 1;
        }
        #endregion
    }
}

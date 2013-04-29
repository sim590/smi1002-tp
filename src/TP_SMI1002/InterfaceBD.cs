//-----------------------------------------------------
// Fichier: InterfaceBD.cs  Auteur: Simon DÉSAULNIERS
//                                  Daniel St-Pierre
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
                                                                +"(CONNECT_DATA=(SERVER=DEDICATED)(SID=coursbd)));User Id=SMI1002_33;Password=27bfpy84;";
        public OracleConnection getLanUQTR
        {
            get
            {
                return cnLanUQTR;
            }
        }
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
        #region retournerObjet

        public void retournerObjet(ref TypeJeu mTypeJeu, int Id)
        {
            mTypeJeu = null;

            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;

            // Ouverture d'une connexion
            cnLanUQTR.Open();
            cmd.CommandText = "SELECT IDTYPEJEU, NOM FROM TYPEJEU WHERE IDTYPEJEU = :id";
            cmd.Parameters.Add("id", Id);

            OracleDataReader rs = cmd.ExecuteReader();

            try
            {
                rs.Read();
                mTypeJeu = new TypeJeu(Id, rs.GetOracleValue(1).ToString());
  
                rs.Close();
            }
            catch
            {

            }
            cnLanUQTR.Close();
        }

        public void retournerObjet(ref Tournoi mTournoi, int Id)
        {
            mTournoi = null;

            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;

            // Ouverture d'une connexion
            cnLanUQTR.Open();
            cmd.CommandText = "SELECT IDTOURNOI, NBJOUEURS, IDJEU, DEBUT, FIN, IDEVENEMENT, NOM FROM TOURNOI WHERE IDTOURNOI = :id";
            cmd.Parameters.Add("id", Id);

            OracleDataReader rs = cmd.ExecuteReader();

            try
            {
                rs.Read();
                mTournoi = new Tournoi(Id,
                                            Convert.ToInt32(rs.GetOracleValue(1).ToString()),
                                            Convert.ToInt32(rs.GetOracleValue(2).ToString()),
                                            Convert.ToDateTime(rs.GetOracleValue(3).ToString()),
                                            Convert.ToDateTime(rs.GetOracleValue(4).ToString()),
                                            Convert.ToInt32(rs.GetOracleValue(5).ToString()),
                                            rs.GetOracleValue(6).ToString());
                rs.Close();
            }
            catch
            {

            }

           
            cnLanUQTR.Close();
        }

        public void retournerObjet(ref Jeu mJeu, int Id)
        {
            mJeu = null;

            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;

            // Ouverture d'une connexion
            cnLanUQTR.Open();
            cmd.CommandText = "SELECT IDJEU, NOM, IDTYPEJEU FROM JEU WHERE IDJEU = :id";
            cmd.Parameters.Add("id", Id);

            OracleDataReader rs = cmd.ExecuteReader();

            try
            {
                rs.Read();
                mJeu = new Jeu(Id, 
                               rs.GetOracleValue(1).ToString(),
                               Convert.ToInt32(rs.GetOracleValue(2).ToString()));
                rs.Close();
            }
            catch
            {

            }


            cnLanUQTR.Close();
        }


        public void retournerObjet(ref Evenement mEvenement, int Id)
        {
            mEvenement = null;

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
        }

        #endregion 

        //Fonction pour remplir les différentes liste
        #region remplirListe
        public void remplirListe(ref List<Jeu> lstJeu)
        {
            OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
            cmd.Connection = cnLanUQTR;
            string cmdString = "";

            cnLanUQTR.Open();
            // Ouverture d'une connexion
            cmdString = "SELECT IDJEU, NOM, IDTYPEJEU FROM JEU ORDER BY NOM";

            // Ajout de la commande à la query
            cmd.CommandText = cmdString;

            OracleDataReader rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                lstJeu.Add(new Jeu(Convert.ToInt32(rs.GetOracleValue(0).ToString()), rs.GetOracleValue(1).ToString(), Convert.ToInt32(rs.GetOracleValue(2).ToString())));
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
            cmdString = "SELECT J.IDJEU, J.NOM, J.IDTYPEJEU, T.NOM FROM JEU J INNER JOIN TYPEJEU T ON J.IDTYPEJEU = T.IDTYPEJEU ORDER BY J.NOM";

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

        //-----------------------------------------------------
        // Va chercher toutes les tournois présent dans la BD
        // et les stock dans une liste
        //-----------------------------------------------------
        public void remplirListe(ref List<Tournoi> lstTournoi)
        {
            OracleCommand cmd = new OracleCommand();
            OracleDataReader rs;
            cmd.Connection = cnLanUQTR;

            cnLanUQTR.Open(); // TODO: Vérifier l'exception si on peut pas se connecter...

            cmd.CommandText = "select idtournoi,nbjoueurs,idjeu,debut,fin,idevenement,nom from tournoi order by nom";

            rs = cmd.ExecuteReader();

            while (rs.Read())
            {
                lstTournoi.Add(new Tournoi(Convert.ToInt32(rs.GetOracleValue(0).ToString()),Convert.ToInt32(rs.GetOracleValue(1).ToString()),
                                           Convert.ToInt32(rs.GetOracleValue(2).ToString()),Convert.ToDateTime(rs.GetOracleValue(3).ToString()),
                                           Convert.ToDateTime(rs.GetOracleValue(4).ToString()),Convert.ToInt32(rs.GetOracleValue(5).ToString()),
                                           rs.GetOracleValue(6).ToString()));
            }
            rs.Close();
            cnLanUQTR.Close();
        }
        #endregion

        #region ajoutBD
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

            // Ajout d'un type de jeu
            if (donnee is TypeJeu)
            {
                cmd.CommandText = "insert into typejeu (nom) values (:nom)";
                cmd.Parameters.Add("nom", ((TypeJeu)donnee).NomTypeJeu);
            }
            // Ajout d'un jeu
            else if (donnee is Jeu)
            {
                cmd.CommandText = "insert into jeu (nom,idtypejeu) values (:nom,:idtypejeu)";
                cmd.Parameters.Add("nom", ((Jeu)donnee).Nom);
                cmd.Parameters.Add("idtypejeu", ((Jeu)donnee).IDTypeJeu);
            }
            // Ajout d'un tournoi
            else if (donnee is Tournoi)
            {
                cmd.CommandText = "insert into tournoi (nom,debut,fin,nbjoueurs,idjeu,idevenement) "+
                                                        "values (:nom,:debut,:fin,:nbjoueurs,:idjeu,:idevenement)";
                cmd.Parameters.Add("nom", ((Tournoi)donnee).Nom);
                cmd.Parameters.Add("debut", ((Tournoi)donnee).dateDebut);
                cmd.Parameters.Add("fin", ((Tournoi)donnee).dateFin);
                cmd.Parameters.Add("nbjoueurs", ((Tournoi)donnee).nbJoueur);
                cmd.Parameters.Add("idjeu", ((Tournoi)donnee).IdJeu);
                cmd.Parameters.Add("idevenement", ((Tournoi)donnee).idEvenement);
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

            if (donnee is TypeJeu)
            {
                cmdString = "update typejeu set nom = :param1 where idtypejeu = :keyValue";
                cmd.CommandText = cmdString;
                cmd.Parameters.Add("param1", ((TypeJeu)donnee).NomTypeJeu);
                cmd.Parameters.Add("keyValue", ((TypeJeu)donnee).Id);
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
            else if (donnee is Jeu)
            {
                cmdString = "update jeu set nom = :param1, idtypejeu = :param2 where idjeu = :keyValue";
                cmd.CommandText = cmdString;
                cmd.Parameters.Add("param1", ((Jeu)donnee).Nom);
                cmd.Parameters.Add("param2", ((Jeu)donnee).IDTypeJeu);
                cmd.Parameters.Add("keyValue", ((Jeu)donnee).Id);
            }
            else if (donnee is Tournoi)
            {
                cmd.CommandText = "update tournoi set nom = :nom, debut = :debut,fin =:fin,nbjoueurs=:nbjoueurs,idjeu=:idjeu,idevenement=:idevenement " +
                                                        "where idtournoi = :keyvalue";
                cmd.Parameters.Add("nom", ((Tournoi)donnee).Nom);
                cmd.Parameters.Add("debut", ((Tournoi)donnee).dateDebut);
                cmd.Parameters.Add("fin", ((Tournoi)donnee).dateFin);
                cmd.Parameters.Add("nbjoueurs", ((Tournoi)donnee).nbJoueur);
                cmd.Parameters.Add("idjeu", ((Tournoi)donnee).IdJeu);
                cmd.Parameters.Add("idevenement", ((Tournoi)donnee).idEvenement);

                cmd.Parameters.Add("keyvalue", ((Tournoi)donnee).Id);
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

            //suppression d'un objet Jeu
            if (donnee is Jeu)
            {
                cmdString = "DELETE FROM JEU WHERE IDJEU=" + ((Jeu)donnee).Id;
            }
            //suppression d'un objet TypeJeu
            else if (donnee is TypeJeu)
            {
                cmdString = "DELETE FROM TYPEJEU WHERE IDTYPEJEU=:id";
                cmd.Parameters.Add("id", donnee.Id);
            }
            //suppression d'un objet Tournoi
            else if (donnee is Tournoi)
            {
                cmdString = "DELETE FROM TOURNOI WHERE IDTOURNOI=:id";
                cmd.Parameters.Add("id", donnee.Id);
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

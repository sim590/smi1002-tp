using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;

namespace TP_SMI1002
{
    class Equipe : DonneeBD
    {
        public string Nom {get; set;}
        public string SiteWeb{get; set;}

        //------------------------------------------------------
        // Constructeur
        //------------------------------------------------------
        public Equipe(string nom, string siteWeb)
        {
            this.Nom = nom;
            this.SiteWeb = siteWeb;
        }

        public Equipe(int Id, string Nom, string SiteWeb)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.SiteWeb = SiteWeb;
        }

        public override string ToString()
        {
            return this.Nom + "\t" + this.SiteWeb;
        }


    }
    class EquipeAvecJoueurs : Equipe
    {
        public List<Joueur> lstJoueurs {get; set;}
        public EquipeAvecJoueurs(int Id, string Nom, string SiteWeb)
            :base(Id, Nom, SiteWeb)
        {
            lstJoueurs = new List<Joueur>();
        }

        public EquipeAvecJoueurs(string Nom, string SiteWeb)
            : base(Nom, SiteWeb)
        {
            lstJoueurs = new List<Joueur>();
        }

        public void SaveListeJoueurBD()
        {
            InterfaceBD bd = InterfaceBD.accesInstance();
            //if (Id == 0)
            //{
                OracleCommand cmd = new OracleCommand(); // fournir objet OracleConnection et le string de commande
                cmd.Connection = bd.getLanUQTR;

                // Ouverture d'une connexion
                bd.getLanUQTR.Open();

                //cmd.CommandText = "SELECT IDEQUIPE FROM EQUIPE WHERE NOM=:nom";
                //cmd.Parameters.Add("nom", this.Nom.ToString());

                //OracleDataReader rs = cmd.ExecuteReader();
               // rs = cmd.ExecuteReader();
                //rs.Read(); 
                //this.Id = Convert.ToInt32(rs.GetOracleValue(0).ToString());
                //rs.Close();

                for (int i = 0; i < lstJoueurs.Count; i++)
                {
                    cmd.Parameters.Clear();
                    cmd.CommandText = "INSERT INTO JOUEUREQUIPE (idjoueur, idequipe) VALUES(:idjoueur,:idequipe)";
                    cmd.Parameters.Add("idjoueur", lstJoueurs[i].Id);
                    cmd.Parameters.Add("idequipe", this.Id);                    
                    cmd.ExecuteNonQuery();
                }
                
                bd.getLanUQTR.Close();
            //}
        }
    }
}

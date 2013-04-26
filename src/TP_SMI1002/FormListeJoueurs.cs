using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TP_SMI1002
{
    public partial class FormListeJoueurs : Form
    {
        //ObjOracleConnexion cn;

        public FormListeJoueurs()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormJoueur formJoueur = new FormJoueur();
            formJoueur.ShowDialog();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListeJoueurs_Load(object sender, EventArgs e)
        {
            List<Joueur> lstJoueur = new List<Joueur>();
            InterfaceBD bd = InterfaceBD.accesInstance();
            bd.remplirListe(ref lstJoueur);

            ListViewItem lsv;
            for (int i = 0; i < lstJoueur.Count; i++)
            {
                lsv = new ListViewItem(lstJoueur[i].Nom);
                lsv.SubItems.Add(lstJoueur[i].GamerTag);
                lsv.SubItems.Add(lstJoueur[i].Courriel);
                lsv.SubItems.Add(lstJoueur[i].Sexe);
                lsv.SubItems.Add(lstJoueur[i].Date.ToString());
                lsv.Tag = lstJoueur[i].Id;

                lsvJoueurs.Items.Add(lsv);
            }
            
            /*cn = new ObjOracleConnexion();
            OracleDataReader rs = cn.cmdData("select idjoueur, nom, gamertag, courriel, sexe, datenaissance from joueur order by idjoueur");
            while (rs.Read())
            {
                ListViewItem lsv = new ListViewItem(rs.GetOracleValue(1).ToString());
                lsv.SubItems.Add(rs.GetOracleValue(2).ToString());
                lsv.SubItems.Add(rs.GetOracleValue(3).ToString());
                lsv.SubItems.Add(rs.GetOracleValue(4).ToString());
                lsv.SubItems.Add(rs.GetOracleValue(5).ToString());
                lsv.Tag = rs.GetOracleValue(0).ToString();

                lsvJoueurs.Items.Add(lsv);
            }
            rs.Close();*/
        }

        
    }
}

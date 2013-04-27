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
        List<Joueur> lstJoueur = new List<Joueur>();
        InterfaceBD bd;

        public FormListeJoueurs()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormJoueur formJoueur = new FormJoueur();
            if (formJoueur.ShowDialog() == DialogResult.OK)
            {
                RefreshListe();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListeJoueurs_Load(object sender, EventArgs e)
        {
            this.RefreshListe();
        }

        private void RefreshListe()
        {
            lstJoueur.Clear();
            lsvJoueurs.Items.Clear();
            lstJoueur = new List<Joueur>();
            bd = InterfaceBD.accesInstance();
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

            lsvJoueurs.Refresh();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lsvJoueurs.SelectedItems.Count == 1)
            {
                FormJoueur frmJoueur = new FormJoueur((int)lsvJoueurs.SelectedItems[0].Tag, lsvJoueurs.SelectedItems[0].SubItems[0].Text, lsvJoueurs.SelectedItems[0].SubItems[1].Text, lsvJoueurs.SelectedItems[0].SubItems[2].Text, lsvJoueurs.SelectedItems[0].SubItems[3].Text, Convert.ToDateTime(lsvJoueurs.SelectedItems[0].SubItems[4].Text));

                if (frmJoueur.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshListe();
                }

            }
            else
            {
                MessageBox.Show("Veuillez choisir un joueur parmis la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lsvJoueurs.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce joueur?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bd.supprimmerDansBD(rechercheJoueur(Convert.ToInt32(lsvJoueurs.SelectedItems[0].Tag)));
                    this.RefreshListe();
                }

            }
            else
            {
                MessageBox.Show("Veuillez choisir un joueur parmis la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Joueur rechercheJoueur(int idJoueur)
        {
            for (int i = 0; i < lstJoueur.Count(); i++)
            {
                if (lstJoueur[i].Id == idJoueur)
                {
                    return lstJoueur[i];
                }
            }
            return null;
        }

        
    }
}

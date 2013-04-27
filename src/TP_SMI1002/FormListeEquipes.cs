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
    public partial class FormListeEquipes : Form
    {
        //ObjOracleConnexion cn;
        List<Equipe> lstEquipe = new List<Equipe>();
        InterfaceBD bd;

        public FormListeEquipes()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormEquipe formEquipe = new FormEquipe();
            if (formEquipe.ShowDialog() == DialogResult.OK)
            {
                RefreshListe();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeEquipes_Load(object sender, EventArgs e)
        {
            this.RefreshListe();            
        }

        private void RefreshListe()
        {
            lstEquipe.Clear();
            lsvEquipe.Items.Clear();
            bd = InterfaceBD.accesInstance();
            bd.remplirListe(ref lstEquipe);

            ListViewItem lsv;
            for (int i = 0; i < lstEquipe.Count; i++)
            {
                lsv = new ListViewItem(lstEquipe[i].Nom);
                lsv.SubItems.Add(lstEquipe[i].SiteWeb);
                lsv.Tag = lstEquipe[i].Id;

                lsvEquipe.Items.Add(lsv);
            }

            lsvEquipe.Refresh();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lsvEquipe.SelectedItems.Count == 1)
            {
                FormEquipe frmEquipe = new FormEquipe((int)lsvEquipe.SelectedItems[0].Tag, lsvEquipe.SelectedItems[0].SubItems[1].Text, lsvEquipe.SelectedItems[0].SubItems[0].Text);

                if (frmEquipe.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshListe();
                }

            }
            else
            {
                MessageBox.Show("Veuillez choisir une équipe parmis la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lsvEquipe.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette équipe?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bd.supprimmerDansBD(rechercheEquipe(Convert.ToInt32(lsvEquipe.SelectedItems[0].Tag)));
                    this.RefreshListe();
                }

            }
            else
            {
                MessageBox.Show("Veuillez choisir une équipe parmis la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Equipe rechercheEquipe(int idEquipe)
        {
            for (int i = 0; i < lstEquipe.Count(); i++)
            {
                if (lstEquipe[i].Id == idEquipe)
                {
                    return lstEquipe[i];
                }
            }
            return null;
        }

        
    }
}

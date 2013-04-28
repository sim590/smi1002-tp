using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TP_SMI1002
{
    public partial class FormListePersonnels : Form
    {
        List<Personnel> lstPersonnel = new List<Personnel>();
        InterfaceBD bd;

        public FormListePersonnels()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormPersonnel formPersonnel = new FormPersonnel();
            if (formPersonnel.ShowDialog() == DialogResult.OK)
            {
                RefreshListe();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListePersonnels_Load(object sender, EventArgs e)
        {
            this.RefreshListe();
        }

        private void RefreshListe()
        {
            lstPersonnel.Clear();
            lsvPersonnel.Items.Clear();
            bd = InterfaceBD.accesInstance();
            bd.remplirListe(ref lstPersonnel);

            ListViewItem lsv;
            for (int i = 0; i < lstPersonnel.Count; i++)
            {
                lsv = new ListViewItem(lstPersonnel[i].Nom);
                lsv.SubItems.Add(lstPersonnel[i].DateNaissance.ToString());
                lsv.SubItems.Add(lstPersonnel[i].Courriel);
                lsv.Tag = lstPersonnel[i].Id;

                lsvPersonnel.Items.Add(lsv);
            }

            lsvPersonnel.Refresh();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lsvPersonnel.SelectedItems.Count == 1)
            {
                FormPersonnel frmJoueur = new FormPersonnel((int)lsvPersonnel.SelectedItems[0].Tag);

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
            if (lsvPersonnel.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer cette équipe?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bd.supprimmerDansBD(rechercheEquipe(Convert.ToInt32(lsvPersonnel.SelectedItems[0].Tag)));
                    this.RefreshListe();
                }

            }
            else
            {
                MessageBox.Show("Veuillez choisir une équipe parmis la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Personnel rechercheEquipe(int idPersonnel)
        {
            for (int i = 0; i < lstPersonnel.Count(); i++)
            {
                if (lstPersonnel[i].Id == idPersonnel)
                {
                    return lstPersonnel[i];
                }
            }
            return null;
        }
    }
}

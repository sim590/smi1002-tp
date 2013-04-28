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
    public partial class FormListeJeux : Form
    {

        InterfaceBD bd = InterfaceBD.accesInstance();
        List<JeuAvecType> lstJeuAvecType = new List<JeuAvecType>();

        public FormListeJeux()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormJeu formJeu = new FormJeu();
            if (formJeu.ShowDialog() == DialogResult.OK)
            {
                RefreshListe();
            }
        }

        private void RefreshListe()
        {
            lstJeuAvecType.Clear();
            lsvJeuAvecType.Items.Clear();
            bd = InterfaceBD.accesInstance();
            bd.remplirListe(ref lstJeuAvecType);

            ListViewItem lsv;
            for (int i = 0; i < lstJeuAvecType.Count; i++)
            {
                lsv = new ListViewItem(lstJeuAvecType[i].Nom);
                lsv.SubItems.Add(lstJeuAvecType[i].TypeJeu);
                lsv.Tag = lstJeuAvecType[i].Id;

                lsvJeuAvecType.Items.Add(lsv);
            }

            lsvJeuAvecType.Refresh();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListeJeux_Load(object sender, EventArgs e)
        {
            RefreshListe();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lsvJeuAvecType.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce jeu?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bd.supprimmerDansBD(rechercheJeu(Convert.ToInt32(lsvJeuAvecType.SelectedItems[0].Tag)));
                    this.RefreshListe();
                } 
            }
            else
            {
                MessageBox.Show("Veuillez choisir un jeu parmis la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private Jeu rechercheJeu(int idEvenement)
        {
            for (int i = 0; i < lstJeuAvecType.Count(); i++)
            {
                if (lstJeuAvecType[i].Id == idEvenement)
                {
                    return lstJeuAvecType[i];
                }
            }
            return null;
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lsvJeuAvecType.SelectedItems.Count == 1)
            {
                FormJeu formJeu = new FormJeu((int)lsvJeuAvecType.SelectedItems[0].Tag);

                if (formJeu.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshListe();
                }

            }
            else
            {
                MessageBox.Show("Veuillez choisir une équipe parmis la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

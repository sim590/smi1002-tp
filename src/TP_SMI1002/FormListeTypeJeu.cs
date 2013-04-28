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
    public partial class FormListeTypeJeu : Form
    {
        List<TypeJeu> lstTypeJeu = new List<TypeJeu>();
        InterfaceBD bd;

        public FormListeTypeJeu()
        {
            InitializeComponent();
        }

        private void FormListeTypePersonnel_Load(object sender, EventArgs e)
        {

        }

        private void RefreshListe()
        {
            lstTypeJeu.Clear();
            lsvTypeJeu.Items.Clear();
            bd = InterfaceBD.accesInstance();
            bd.remplirListe(ref lstTypeJeu);

            ListViewItem lsv;
            for (int i = 0; i < lstTypeJeu.Count; i++)
            {
                lsv = new ListViewItem(lstTypeJeu[i].NomTypeJeu);
                lsv.Tag = lstTypeJeu[i];

                lsvTypeJeu.Items.Add(lsv);
            }

            lsvTypeJeu.Refresh();
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            FormTypeJeu FormTypeJeu = new FormTypeJeu();
            if (FormTypeJeu.ShowDialog() == DialogResult.OK)
            {
                RefreshListe();
            }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lsvTypeJeu.SelectedItems.Count == 1)
            {
                FormTypeJeu frmTypeJeu = new FormTypeJeu(((TypeJeu)lsvTypeJeu.SelectedItems[0].Tag).Id);

                if (frmTypeJeu.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshListe();
                }

            }
            else
            {
                MessageBox.Show("Veuillez choisir une équipe parmis la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void FormListeTypeJeu_Load(object sender, EventArgs e)
        {
            RefreshListe();
        }
    }
}


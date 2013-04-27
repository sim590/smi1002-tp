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
    public partial class FormListeEvenements : Form
    {
        List<Evenement> lstEvenement = new List<Evenement>();
        InterfaceBD bd;

        public FormListeEvenements()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormEvenement formEvenement = new FormEvenement();
            if (formEvenement.ShowDialog() == DialogResult.OK)
            {
                RefreshListe();
            }
        }

        private void RefreshListe()
        {

            lstEvenement.Clear();
            lsvEvenement.Items.Clear();
            bd = InterfaceBD.accesInstance();
            bd.remplirListe(ref lstEvenement);

            ListViewItem lsv;
            for (int i = 0; i < lstEvenement.Count; i++)
            {
                lsv = new ListViewItem(lstEvenement[i].Nom);
                lsv.SubItems.Add(lstEvenement[i].Debut.ToString());
                lsv.SubItems.Add(lstEvenement[i].Fin.ToString());
                lsv.SubItems.Add(lstEvenement[i].Lieu.ToString());
                lsv.SubItems.Add(lstEvenement[i].Adresse.ToString());
                lsv.SubItems.Add(lstEvenement[i].NbrPlace.ToString());
                lsv.SubItems.Add(lstEvenement[i].Prix.ToString());
                lsv.Tag = lstEvenement[i].Id;

                lsvEvenement.Items.Add(lsv);
            }

            lsvEvenement.Refresh();
        }

        private void ListeEvenements_Load(object sender, EventArgs e)
        {
            RefreshListe();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lsvEvenement.SelectedItems.Count == 1)
            {
                FormEvenement formEvenement = new FormEvenement(Convert.ToInt32(lsvEvenement.SelectedItems[0].Tag));
                if (formEvenement.ShowDialog() == DialogResult.OK)
                {
                    RefreshListe();
                }
            }
        }
    }
}

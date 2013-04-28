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
    public partial class FormListeTypePersonnel : Form
    {
        InterfaceBD bd = InterfaceBD.accesInstance();
        List<TypePersonnel> lstTypePersonnel = new List<TypePersonnel>();

        public FormListeTypePersonnel()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormTypePersonnel formTypePersonnel = new FormTypePersonnel();
            if (formTypePersonnel.ShowDialog() == DialogResult.OK)
            {
                RefreshListe();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListeTypePersonnel_Load(object sender, EventArgs e)
        {
            RefreshListe();
        }

        private void RefreshListe()
        {
            lstTypePersonnel.Clear();
            lsvTypePersonnel.Items.Clear();
            bd = InterfaceBD.accesInstance();
            bd.remplirListe(ref lstTypePersonnel);

            ListViewItem lsv;
            for (int i = 0; i < lstTypePersonnel.Count; i++)
            {
                lsv = new ListViewItem(lstTypePersonnel[i].Nom);
                lsv.SubItems.Add(lstTypePersonnel[i].Couleur.ToString("X"));
                lsv.Tag = lstTypePersonnel[i].Id;

                lsvTypePersonnel.Items.Add(lsv);
            }

            lsvTypePersonnel.Refresh();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            {
                if (lsvTypePersonnel.SelectedItems.Count == 1)
                {
                    FormTypePersonnel formTypePersonnel = new FormTypePersonnel((int)lsvTypePersonnel.SelectedItems[0].Tag);

                    if (formTypePersonnel.ShowDialog() == DialogResult.OK)
                    {
                        this.RefreshListe();
                    }

                }
                else
                {
                    MessageBox.Show("Veuillez choisir un type de personnel parmis la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        
        }
    }
}

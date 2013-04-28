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
    }
}

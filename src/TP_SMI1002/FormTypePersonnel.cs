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
    public partial class FormTypePersonnel : Form
    {
        public FormTypePersonnel()
        {
            InitializeComponent();
        }

        private void btnCouleur_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                pbCouleur.BackColor = cdCouleur.Color;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormEvenement : Form
    {
        public FormEvenement()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAjouterMembre_Click(object sender, EventArgs e)
        {
            FormTournoi formTournoi = new FormTournoi();
            formTournoi.ShowDialog();
        }
    }
}

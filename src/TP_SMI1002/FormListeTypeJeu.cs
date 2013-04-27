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
        public FormListeTypeJeu()
        {
            InitializeComponent();
        }

        private void FormListeTypePersonnel_Load(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            FormTypeJeu FormTypeJeu = new FormTypeJeu();
            FormTypeJeu.ShowDialog();
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
            
        }

        private void FormListeTypeJeu_Load(object sender, EventArgs e)
        {

        }
    }
}


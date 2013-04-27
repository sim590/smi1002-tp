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
    public partial class FormEquipe : FormIdiotProof
    {
        public FormEquipe()
        {
            InitializeComponent();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bool okay = true;

            if (txtNom.Text == "")
            {
                okay = false;
            }
            if (txtSite.Text == "")
            {
                okay = false;
            }

            if (okay)
            {

            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TP_SMI1002
{
    public partial class FormJoueur : FormIdiotProof
    {
        public FormJoueur()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bool okay = true;

            if (txtNom.Text == "")
            {
                okay = false;
            }
            if (txtGamerTag.Text == "")
            {
                okay = false;
            }
            if (txtCourriel.Text == "")
            {
                okay = false;
            }
            if (cbSexe.SelectedText == "")
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

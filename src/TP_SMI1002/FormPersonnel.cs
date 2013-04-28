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
    public partial class FormPersonnel : Form
    {
        InterfaceBD bd;

        //---------------
        // Constructeur
        //---------------
        public FormPersonnel()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-----------------------
        // Bouton "enregistrer"
        //-----------------------
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bd = InterfaceBD.accesInstance();
            if (Valider.estNomValide(txtNom.Text))
            {
                bd.ajoutBD(new Personnel(txtNom.Text, dtpDateNaissance.Value, txtCourriel.Text));
                this.DialogResult = DialogResult.OK;
            }
        }

        private bool courrielEstValide(string courriel)
        {
            return true;
        }

        private void FormPersonnel_Load(object sender, EventArgs e)
        {

        }

          
    }
}

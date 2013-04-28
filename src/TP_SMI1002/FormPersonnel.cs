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
            bd = InterfaceBD.accesInstance();
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
            if (Valider.estNomValide(txtNom.Text) && Valider.estCourrielValide(txtCourriel.Text))
            {
                if (bd.ajoutBD(new Personnel(txtNom.Text, dtpDateNaissance.Value, txtCourriel.Text)) == -1)
                {
                    MessageBox.Show("Impossible d'envoyer la requête.");
                    return;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("Veuillez entrer un nom et un courriel valide.");
        }   
    }
}

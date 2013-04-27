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
    public partial class FormPersonnel : FormIdiotProof
    {
        InterfaceBD interfaceBD;

        //---------------
        // Constructeur
        //---------------
        public FormPersonnel()
        {
            interfaceBD = InterfaceBD.accesInstance();
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
            Personnel personnel; 
            
            if (estNomValide(txtNom.Text))
            {
                personnel = new Personnel(txtNom.Text, txtCourriel.Text, dtpDateNaissance.Text);
                if (interfaceBD.ajoutBD(personnel) == -1)
                    MessageBox.Show("Impossible d'envoyer la requête...");
            }
        }

        private bool courrielEstValide(string courriel)
        {
            return true;
        }

          
    }
}

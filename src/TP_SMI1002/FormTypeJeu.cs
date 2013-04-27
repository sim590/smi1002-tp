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
    public partial class FormTypeJeu : Form
    {
        InterfaceBD interfaceBD;
        //---------------
        // Constructeur
        //---------------
        public FormTypeJeu()
        {
            interfaceBD = InterfaceBD.accesInstance();
            InitializeComponent();
        }

        //-----------------------------------
        // Enregistrer un type de Jeu
        //-----------------------------------
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            TypeJeu type = new TypeJeu(this.txtNom.Text);
            InterfaceBD bd = InterfaceBD.accesInstance();
            bd.ajoutBD(type);
        }

        // Annuler la transaction
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            InterfaceBD BD = InterfaceBD.accesInstance();
            if (Valider.estNomValide(this.txtNom.Text))
            {
                TypeJeu typejeu = new TypeJeu(this.txtNom.Text);
                BD.ajoutBD(typejeu);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom valide, soit seulement avec des caractères alphabétiques et accents", "Erreur de nom", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}


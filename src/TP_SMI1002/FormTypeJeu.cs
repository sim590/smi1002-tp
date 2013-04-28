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

        // Annuler la transaction
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------
        // Enregistrer un type de jeu
        //------------------------------
        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            if (Valider.estNomValide(this.txtNom.Text))
            {
                TypeJeu typejeu = new TypeJeu(this.txtNom.Text);
                if (interfaceBD.ajoutBD(typejeu) == -1)
                {
                    MessageBox.Show("Impossible d'envoyer la requête.");
                    return;
                }
            }
            else
                MessageBox.Show("Veuillez entrer un nom valide, soit seulement avec des caractères alphabétiques et accents", "Erreur de nom", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}


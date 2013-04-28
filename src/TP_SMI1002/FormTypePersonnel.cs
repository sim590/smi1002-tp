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
        InterfaceBD interfaceBD;
        //---------------
        // Constructeur
        //---------------
        public FormTypePersonnel()
        {
            interfaceBD = InterfaceBD.accesInstance();
            InitializeComponent();
        }

        //----------------------
        // Choix de la couleur
        //----------------------
        private void btnCouleur_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                pbCouleur.BackColor = cdCouleur.Color;
            }
        }

        //-----------------------------------
        // Enregistrer un type de personnel
        //-----------------------------------
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            TypePersonnel type;

            if (pbCouleur.BackColor != null && Valider.estNomValide(this.txtNom.Text))
            {
                type = new TypePersonnel(pbCouleur.BackColor.A, pbCouleur.BackColor.R,
                                                pbCouleur.BackColor.G, pbCouleur.BackColor.B, this.txtNom.Text);

                // Ajout à la BD par le singleton
                if (interfaceBD.ajoutBD(type) == -1)
                {
                    MessageBox.Show("Impossible d'envoyer la requête.");
                    return;
                }

                // On ferme la fenêtre
                this.Close();
            }
            else
                MessageBox.Show("Veuillez entrer un nom valide et faire votre choix de couleur.");
        }

        // Annuler la transaction
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

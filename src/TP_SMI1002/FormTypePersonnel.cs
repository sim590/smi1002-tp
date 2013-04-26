using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TP_SMI1002
{
    public partial class FormTypePersonnel : Form
    {
        //---------------
        // Constructeur
        //---------------
        public FormTypePersonnel()
        {
            InitializeComponent();
        }

        private void btnCouleur_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                pbCouleur.BackColor = cdCouleur.Color;
            }
        }

        // Enregistrer un type de personnel
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (pbCouleur.BackColor != null && estNomValide(this.txtNom.Text))
            {
                TypePersonnel type = new TypePersonnel(pbCouleur.BackColor.A, pbCouleur.BackColor.R,
                    pbCouleur.BackColor.G,pbCouleur.BackColor.B,this.txtNom.Text);
                
                /*
                 * //TODO: DEMANDER AU SINGLETON (AVEC PATRON FABRIQUE) D'AJOUTER LA DONNÉE DANS LA BD
                 */
            }
        }

        // Vérifie que le nom entré est vrai-semblablement un nom
        private bool estNomValide(string nom)
        {
            // Première vérification
            foreach (char c in nom)
                if (c != ' ' && Regex.IsMatch(nom, @"^[a-zA-Z]+$"))
                    return true;
            return false;
        }

        // Annuler la transaction
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

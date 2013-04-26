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
    public partial class FormEvenement : Form
    {
        private int IdEvenement = 0;
        public FormEvenement()
        {
            InitializeComponent();
        }

        public FormEvenement(int IdEvenement)
        {
            InitializeComponent();
            this.IdEvenement = IdEvenement;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAjouterMembre_Click(object sender, EventArgs e)
        {
            FormTournoi formTournoi = new FormTournoi();
            formTournoi.ShowDialog();
        }

        private void FormEvenement_Load(object sender, EventArgs e)
        {
            dtpDebut.Format = DateTimePickerFormat.Custom;
            dtpDebut.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            txtNom.Text.Trim();
            txtLieu.Text.Trim();
            txtAdresse.Text.Trim();
            txtVille.Text.Trim();
            txtCodePostale.Text.Trim();

            if (txtNom.Text == "")
            {
                MessageBox.Show("Vous devez spécifier un nom pour l'évènement.", "Erreur de nom", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLieu.Text == "")
            {
                MessageBox.Show("Vous devez spécifier un lieu pour l'évènement.", "Erreur de lieu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtAdresse.Text == "")
            {
                MessageBox.Show("Vous devez spécifier une adresse pour l'évènement.", "Erreur d'adresse", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtVille.Text == "")
            {
                MessageBox.Show("Vous devez spécifier une ville pour l'évènement.", "Erreur de ville", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtCodePostale.Text == "")
            {
                MessageBox.Show("Vous devez spécifier un code postale", "Erreur de code postale", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dtpDebut.Value >= dtpFin.Value)
            {
                MessageBox.Show("La date de début ne peut être supérieure à la date de fin");
            }
            else
            {
                if (IdEvenement > 0)
                {
                    //Modif
                }
                else
                {
                    //Ajout
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCodePostal_Click(object sender, EventArgs e)
        {

        }
    }
}

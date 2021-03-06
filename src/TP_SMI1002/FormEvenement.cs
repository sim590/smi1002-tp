﻿using System;
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
        InterfaceBD bd;
        private int IdEvenement = 0;
        public FormEvenement()
        {
            InitializeComponent();
        }

        public FormEvenement(int IdEvenement)
        {
            InitializeComponent();
            this.IdEvenement = IdEvenement;

            bd = InterfaceBD.accesInstance();

            Evenement mEvenement = null;
            bd.retournerObjet(ref mEvenement, IdEvenement);
            if (mEvenement == null)
            {
                MessageBox.Show("Cet évènement à été supprimer de la base de données", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                IdEvenement = 0;
            }
            else
            {
                txtNom.Text = mEvenement.Nom;
                dtpDebut.Value = mEvenement.Debut;
                dtpFin.Value = mEvenement.Fin;
                txtLieu.Text = mEvenement.Lieu;
                txtAdresse.Text = mEvenement.Adresse;
                txtVille.Text = mEvenement.Adresse;
                txtNbrPlace.Text = mEvenement.NbrPlace.ToString();
                txtPrix.Text = mEvenement.Prix.ToString();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnAjouterTournoi_Click(object sender, EventArgs e)
        {

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
            else if (dtpDebut.Value >= dtpFin.Value)
            {
                MessageBox.Show("La date de début ne peut être supérieure à la date de fin");
            }
            else
            {
                bd = InterfaceBD.accesInstance();
                if (IdEvenement > 0)
                {
                    //Modifier
                    Evenement mEvenement = new Evenement(this.IdEvenement,txtNom.Text, dtpDebut.Value, dtpFin.Value, txtLieu.Text, txtAdresse.Text, Convert.ToInt32(txtNbrPlace.Text), Convert.ToDouble(txtPrix.Text));
                    bd.modifierBD(mEvenement);
                }
                else
                {
                    Evenement mEvenement = new Evenement(txtNom.Text, dtpDebut.Value, dtpFin.Value, txtLieu.Text, txtAdresse.Text, Convert.ToInt32(txtNbrPlace.Text), Convert.ToDouble(txtPrix.Text));
                    bd.ajoutBD(mEvenement);
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

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
    public partial class FormTournoi : FormIdiotProof
    {
        private int IDTournoi = 0;

        public FormTournoi()
        {
            InitializeComponent();
        }

        public FormTournoi(int IDTournois)
        {
            InitializeComponent();

            //Load Tournoi from BD
        }

        private void FormTournoi_Load(object sender, EventArgs e)
        {
            dtpDebut.Format = DateTimePickerFormat.Custom;
            dtpDebut.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            txtNbrJoueurParEquipe.Text.Trim();
            txtNom.Text.Trim();

            if (txtNom.Text == "")
            {
                MessageBox.Show("Vous devez spécifier un nom pour le tournoi.", "Erreur nom du tournoi", MessageBoxButtons.OK);
            }
            else if (txtNbrJoueurParEquipe.Text.Length == 0)
            {
                MessageBox.Show("Vous devez spécifier un nombre de joueur par équipe pour le tournoi.", "Erreur nombre de joueur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cbJeu.SelectedIndex < 0)
            {
                MessageBox.Show("Vous devez spécifier un jeu pour le tournoi.", "Erreur sélection du jeu", MessageBoxButtons.OK);
            }
            else
            {
                if (IDTournoi != 0)
                {

                }
                else
                {

                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

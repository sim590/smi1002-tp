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
    public partial class FormTournoi : Form
    {
        private int IDTournoi = 0;
        InterfaceBD bd;

        //---------------
        // Constructeurs
        //---------------
        public FormTournoi()
        {
            bd = InterfaceBD.accesInstance();
            InitializeComponent();
        }
        //...
        public FormTournoi(int IDTournoi)
        {
            InitializeComponent();

            this.IDTournoi = IDTournoi;
        }

        //-------------------------------------
        // Lors du chargement de la fenêtre,
        // rafraichissement de la liste
        //-------------------------------------
        private void FormTournoi_Load(object sender, EventArgs e)
        {
            dtpDebut.Format = DateTimePickerFormat.Custom;
            dtpDebut.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            List<Jeu> lstJeu = new List<Jeu>();
            bd.remplirListe(ref lstJeu);
            for (int i = 0; i < lstJeu.Count();i++)
                cbJeu.Items.Add(lstJeu[i]);
        }

        //----------------------
        // Bouton "enregistrer"
        //----------------------
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            txtNbrJoueurParEquipe.Text.Trim();
            txtNom.Text.Trim();


            // Champ nom vide
            if (txtNom.Text.Equals(""))
            {
                MessageBox.Show("Vous devez spécifier un nom pour le tournoi.", "Erreur nom du tournoi", MessageBoxButtons.OK);
            }
            // champ nbJoueurs vide
            else if (txtNbrJoueurParEquipe.Text.Length == 0)
            {
                MessageBox.Show("Vous devez spécifier un nombre de joueur par équipe pour le tournoi.", "Erreur nombre de joueur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Aucun jeu sélectionné
            else if (cbJeu.SelectedIndex < 0)
            {
                MessageBox.Show("Vous devez spécifier un jeu pour le tournoi.", "Erreur sélection du jeu", MessageBoxButtons.OK);
            }
            else
            {
                // Modifier 
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

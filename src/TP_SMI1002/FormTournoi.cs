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
        private Tournoi tournoi;
        InterfaceBD interfaceBD;
        List<Jeu> lstJeu; 

        //---------------
        // Constructeurs
        //---------------
        public FormTournoi()
        {
            interfaceBD = InterfaceBD.accesInstance();
            lstJeu = new List<Jeu>();
            InitializeComponent();
        }
        //...
        public FormTournoi(Tournoi tournoi)
        {
            this.tournoi = tournoi;
            lstJeu = new List<Jeu>();
            InitializeComponent();
        }

        //-------------------------------------
        // Lors du chargement de la fenêtre:
        // - rafraichissement de la liste
        // - Remplissage des champs selon les
        //   info avant la modification
        //-------------------------------------
        private void FormTournoi_Load(object sender, EventArgs e)
        {
            dtpDebut.Format = DateTimePickerFormat.Custom;
            dtpDebut.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpFin.Format = DateTimePickerFormat.Custom;
            dtpFin.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            interfaceBD.remplirListe(ref lstJeu);
            for (int i = 0; i < lstJeu.Count();i++)
                cbJeu.Items.Add(lstJeu[i]);

            // Si modification
            if (tournoi != null)
            {
                txtNom.Text = tournoi.Nom;
                txtNbrJoueurParEquipe.Text = tournoi.nbJoueur.ToString();
                //TODO: Trouver le bon nom de jeu à mettre
                //      --> Implémenter la méthode find de List<Jeu>
                //      http://msdn.microsoft.com/fr-fr/library/vstudio/x0b5b5bc.aspx
                //      (Comparer par NOM)
                //
                //      *Faire une requête à la BD serait trop couteux pour rien
                //      et on ne veut pas chercher un objet par son NOM dans un BD.
                // cbJeu.SelectedIndex = 
            }
        }

        //----------------------
        // Bouton "enregistrer"
        //----------------------
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int rangesEcrites=0;

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
                // Modification
                if (this.tournoi != null)
                {
                    tournoi.Nom = txtNom.Text;
                    tournoi.nbJoueur = Convert.ToInt32(txtNbrJoueurParEquipe.Text);
                    tournoi.dateDebut = dtpDebut.Value;
                    tournoi.dateFin = dtpFin.Value;

                    // TODO: rendu à la récupération du jeu dans le combobox.... Voir ligne 57 
                    // interfaceBD.retournerObjet(jeu, 
                    rangesEcrites = interfaceBD.modifierBD(tournoi);
                }
                // Ajout
                else
                {
                    // TODO: Y faut récupéré le jeu dans le combobox.. Voir ligne 57
                    //rangesEcrites = interfaceBD.ajoutBD(new Tournoi(args));
                }
                
                // Si un problème est survenu..
                if (rangesEcrites == -1)
                {
                    MessageBox.Show("Impossible d'envoyer la requête.");
                }
                else
                    this.DialogResult = DialogResult.OK; // Est-ce que ça fait le this.close()?
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

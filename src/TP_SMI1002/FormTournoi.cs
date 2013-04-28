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
        private Tournoi tournoi= null;
        InterfaceBD interfaceBD;

        //---------------
        // Constructeurs
        //---------------
        public FormTournoi()
        {
            interfaceBD = InterfaceBD.accesInstance();
            InitializeComponent();
        }
        

        public FormTournoi(int id)
        {
            InitializeComponent();
            interfaceBD = InterfaceBD.accesInstance();
            interfaceBD.retournerObjet(ref tournoi, id);
            if (tournoi != null)
            {
                txtNbrJoueurParEquipe.Text = tournoi.nbJoueur.ToString();
                txtNom.Text = tournoi.nbJoueur.ToString();
                dtpDebut.Value = tournoi.dateDebut;
                dtpFin.Value = tournoi.dateFin; 
            }
            
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

            List<Jeu> lstJeu = new List<Jeu>();
            interfaceBD.remplirListe(ref lstJeu);
            for (int i = 0; i < lstJeu.Count();i++)
                cbJeu.Items.Add(lstJeu[i]);

            if (cbJeu.Items.Count > 0)
                cbJeu.SelectedIndex = 0;

            List<Evenement> lstEvenement = new List<Evenement>();
            interfaceBD.remplirListe(ref lstEvenement);
            for (int i = 0; i < lstEvenement.Count(); i++)
            {
                cbEvenement.Items.Add(lstEvenement[i]);   
            }


            if (cbEvenement.Items.Count > 0)
                cbEvenement.SelectedIndex = 0;

            // Si modification
            if (tournoi != null)
            {
                txtNom.Text = tournoi.Nom;
                txtNbrJoueurParEquipe.Text = tournoi.nbJoueur.ToString();

                cbJeu.SelectedIndex = rechercherIndexJeu(tournoi.IdJeu);
                cbEvenement.SelectedIndex = rechercherIndexEvenement(tournoi.idEvenement);
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
                    tournoi.idEvenement = ((Evenement)(cbEvenement.Items[cbEvenement.SelectedIndex])).Id;
                    
                    tournoi.IdJeu = ((Jeu)(cbJeu.Items[cbJeu.SelectedIndex])).Id;
                    rangesEcrites = interfaceBD.modifierBD(tournoi);
                }
                // Ajout
                else
                {
                    rangesEcrites = interfaceBD.ajoutBD(new Tournoi(Convert.ToInt32(txtNbrJoueurParEquipe.Text), 
                                            ((Jeu)(cbJeu.Items[cbJeu.SelectedIndex])).Id,
                                            dtpDebut.Value, dtpFin.Value, 
                                            ((Evenement)cbEvenement.Items[cbEvenement.SelectedIndex]).Id, txtNom.Text));
                }
                
                // Si un problème est survenu..
                if (rangesEcrites == -1)
                {
                    MessageBox.Show("Impossible d'envoyer la requête.");
                }
                else
                    this.DialogResult = DialogResult.OK;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private int rechercherIndexJeu(int id)
        {
            for (int i = 0; i<cbJeu.Items.Count;i++)
            {
                if (((Jeu)cbJeu.Items[i]).Id == id)
                {
                    return i;
                }
            }
            return -1;
        }

        private int rechercherIndexEvenement(int id)
        {
            for (int i = 0; i < cbEvenement.Items.Count; i++)
            {
                if (((Evenement)cbEvenement.Items[i]).Id == id)
                {
                    return i;
                }
            }
            return -1;
        }
    }


}

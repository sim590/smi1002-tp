//----------------------------------------------------------------
// Fichier: FormListeTournoi.cs     Auteur(s): Simon DÉSAULNIERS
//
//----------------------------------------------------------------
// Affichage de la liste des tournois dans la BD
//----------------------------------------------------------------

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
    public partial class FormListeTournoi : Form
    {
        InterfaceBD interfaceBD;
        List<Tournoi> lstTournoi;
        //---------------
        // Constructeur
        //---------------
        public FormListeTournoi()
        {
            lstTournoi = new List<Tournoi>();
            interfaceBD = InterfaceBD.accesInstance();
            InitializeComponent();
        }

        //-------------------
        // Bouton "ajouter"
        //-------------------
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormTournoi formTournoi = new FormTournoi();
            if (formTournoi.ShowDialog() == DialogResult.OK)
            {
                rafraichirListe();
            }
        }

        //--------------------
        // Bouton "modifier"
        //--------------------
        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lsvTournoi.SelectedItems.Count == 1)
            {
                FormTournoi formTournoi = new FormTournoi(Convert.ToInt32(((Tournoi)lsvTournoi.SelectedItems[0].Tag).Id));
                if (formTournoi.ShowDialog() == DialogResult.OK)
                {
                    rafraichirListe();
                }
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un tournoi.", "Erreur de sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------------
        // Bouton "supprimmer"
        //----------------------
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lsvTournoi.SelectedItems.Count == 1)
            {
                if (MessageBox.Show("Voulez-vous vraiment supprimer ce tournoi?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Envoie de la requête pour suppression dans la BD
                    if (interfaceBD.supprimmerDansBD((Tournoi)lsvTournoi.SelectedItems[0].Tag) == -1)
                    {
                        MessageBox.Show("Impossible d'envoyer la requête");
                        return;
                    }

                    rafraichirListe();
                }
            }
            else
                MessageBox.Show("Veuillez choisir un tournoi parmis la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        //----------------------------------
        // Rafraîchissement de l'affichage
        // de la liste
        //----------------------------------
        private void rafraichirListe()
        {
            ListViewItem lsvItem;
            
            lstTournoi.Clear();
            lsvTournoi.Items.Clear();

            // Va chercher la liste dans la base de données
            interfaceBD.remplirListe(ref lstTournoi);

            // Remplissage du listview
            foreach (Tournoi tournoi in lstTournoi)
            {
                lsvItem = new ListViewItem(tournoi.Nom);
                lsvItem.SubItems.Add(tournoi.dateDebut.ToString());
                lsvItem.SubItems.Add(tournoi.dateFin.ToString());
                lsvItem.SubItems.Add(tournoi.nbJoueur.ToString());
                lsvItem.Tag = tournoi;
                lsvTournoi.Items.Add(lsvItem);
            }

            lsvTournoi.Refresh();
        }

        private void FormListeTournoi_Load(object sender, EventArgs e)
        {
            rafraichirListe();
        }
    }
}

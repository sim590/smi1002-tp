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
    public partial class FormEquipe : Form
    {
        private int id = 0;
        InterfaceBD bd;
        EquipeAvecJoueurs mEquipe = null;

        //---------------------------------------------
        // Constructeur de base
        //---------------------------------------------
        public FormEquipe()
        {
            InitializeComponent();
            mEquipe = new EquipeAvecJoueurs("", "");
        }

        //---------------------------------------------
        // Constructeur pour modifications
        //---------------------------------------------
        public FormEquipe(int id)
        {
            InitializeComponent();
            this.id = id;

            bd = InterfaceBD.accesInstance();
            bd.retournerObjet(ref mEquipe, id);

            if (mEquipe != null)
            {
                txtNom.Text = mEquipe.Nom;
                txtSite.Text = mEquipe.SiteWeb;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bool okay = true;

            if (txtNom.Text == "")
            {
                okay = false;
            }
            if (txtSite.Text == "")
            {
                okay = false;
            }

            if (okay)
            {
                AssignerJoueurAListe();
                bd = InterfaceBD.accesInstance();
                if (id == 0) //Ajout dans la base de données
                {
                    mEquipe.Nom = txtNom.Text;
                    mEquipe.SiteWeb = txtSite.Text;
                    bd.ajoutBD(mEquipe);

                    mEquipe.SaveListeJoueurBD();
                    this.DialogResult = DialogResult.OK;
                }
                else //Update la base de données
                {
                    mEquipe.Nom = txtNom.Text;
                    mEquipe.SiteWeb = txtSite.Text;

                    bd.modifierBD(mEquipe);
                    mEquipe.SaveListeJoueurBD();
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEquipe_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < mEquipe.lstJoueurs.Count(); i++)
            {
                lbMembre.Items.Add(mEquipe.lstJoueurs[i]);
            }
        }

        private void btnAjouterMembre_Click(object sender, EventArgs e)
        {
            FormListeJoueurs formListeJoueurs = new FormListeJoueurs(FormListeJoueurs.mode.selection);
            if (formListeJoueurs.ShowDialog() == DialogResult.OK)
            {
                bd = InterfaceBD.accesInstance();
                Joueur mJoueur = null;
                for (int i = 0; i<formListeJoueurs.lstSelectedId.Count; i++)
                {
                    if (!JoueurDansEquipe(formListeJoueurs.lstSelectedId[i]))
                    {
                        bd.retournerObjet(ref mJoueur, formListeJoueurs.lstSelectedId[i]);

                        lbMembre.Items.Add(mJoueur);
                    }
                }
            }
        }

        private void btnSupprimerMembre_Click(object sender, EventArgs e)
        {
            if (lbMembre.SelectedIndex >= 0)
            {
                lbMembre.Items.RemoveAt(lbMembre.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Vous devez sélectionner un membre", "Erreur sélection membre", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AssignerJoueurAListe()
        {
            mEquipe.lstJoueurs.Clear();

            for (int i = 0; i < lbMembre.Items.Count; i++)
            {
                mEquipe.lstJoueurs.Add((Joueur)(lbMembre.Items[i]));
            }
        }

        private Boolean JoueurDansEquipe(int IdJoueur)
        {
            for (int i = 0; i < lbMembre.Items.Count; i++)
            {
                if (((Joueur)lbMembre.Items[i]).Id == IdJoueur)
                    return true;
            }
            return false;
        }
    }
}

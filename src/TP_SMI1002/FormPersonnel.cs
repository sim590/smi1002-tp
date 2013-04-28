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
    public partial class FormPersonnel : Form
    {
        private int id = 0;
        InterfaceBD bd;
        Personnel mPersonnel = null;

        //---------------
        // Constructeur
        //---------------
        public FormPersonnel()
        {
            bd = InterfaceBD.accesInstance();
            InitializeComponent();
        }

        //---------------------------------
        // Constructeur pour modification
        //---------------------------------
        public FormPersonnel(int id)
        {
            InitializeComponent();
            this.id = id;

            bd = InterfaceBD.accesInstance();
            bd.retournerObjet(ref mPersonnel, id);

            if (mPersonnel != null)
            {
                txtNom.Text = mPersonnel.Nom;
                txtCourriel.Text = mPersonnel.Courriel;
                dtpDateNaissance.Value = mPersonnel.DateNaissance;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-----------------------
        // Bouton "enregistrer"
        //-----------------------
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            int rangesEcrites = 0;
            
            if (Valider.estNomValide(txtNom.Text) && && Valider.estCourrielValide(txtCourriel.Text))
            {
                if (id == 0) // Ajout dans la base de données
                {
                    rangesEcrites = bd.ajoutBD(new Personnel(txtNom.Text, dtpDateNaissance.Value, txtCourriel.Text));
                }
                else //Update la base de données
                {
                    rangesEcrites = bd.modifierBD(new Personnel(id, txtNom.Text, dtpDateNaissance.Value, txtCourriel.Text));
                }
                
                // Erreur lors de l'opération..
                if (rangesEcrites == -1)
                {
                    MessageBox.Show("Impossible d'envoyer la requête.");
                    return;
                }
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Veuillez entrer un nom et un courriel valide.");
        }   
    }
}

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
    public partial class FormJeu : Form
    {
        public FormJeu()
        {
            InitializeComponent();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            InterfaceBD BD = InterfaceBD.accesInstance();
            if (Valider.estNomValide(this.txtNom.Text))
            {
                Jeu jeu = new Jeu(this.txtNom.Text, ((TypeJeu)(cbTypeJeu.SelectedItem)).Id);
                BD.ajoutBD(jeu);
            }
            else
            {
                MessageBox.Show("Veuillez entrer un nom valide, soit seulement avec des caractères alphabétiques et accents", "Erreur de nom", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormJeu_Load(object sender, EventArgs e)
        {
            InterfaceBD bd = InterfaceBD.accesInstance();
            List<TypeJeu> lstTypeJeu = new List<TypeJeu>();

            bd.remplirListe(ref lstTypeJeu);

            for (int i = 0; i < lstTypeJeu.Count(); i++)
            {
                cbTypeJeu.Items.Add(lstTypeJeu[i]);
            }
            if (cbTypeJeu.Items.Count > 0) cbTypeJeu.SelectedIndex = 0;
        }

    }
}

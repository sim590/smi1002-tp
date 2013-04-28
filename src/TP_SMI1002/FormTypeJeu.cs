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
    public partial class FormTypeJeu : Form
    {
        InterfaceBD interfaceBD;
        int id = 0;
        TypeJeu mTypeJeu = null;
        //---------------
        // Constructeur
        //---------------
        public FormTypeJeu()
        {
            interfaceBD = InterfaceBD.accesInstance();
            InitializeComponent();
        }

        public FormTypeJeu(int id)
        {
            InitializeComponent();

            interfaceBD = InterfaceBD.accesInstance();
            this.id = id;
            interfaceBD.retournerObjet(ref mTypeJeu, id);

            if (mTypeJeu != null)
            {
                txtNom.Text = mTypeJeu.NomTypeJeu;
            }
        }

        // Annuler la transaction
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //------------------------------
        // Enregistrer un type de jeu
        //------------------------------
        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            if (Valider.estNomValide(this.txtNom.Text))
            {
                
                if (id == 0)
                {
                    TypeJeu typejeu = new TypeJeu(this.txtNom.Text);
                    BD.ajoutBD(typejeu);
                }
                else
                {
                    mTypeJeu.NomTypeJeu = txtNom.Text;
                    BD.modifierBD(mTypeJeu);
                }
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Veuillez entrer un nom valide, soit seulement avec des caractères alphabétiques et accents", "Erreur de nom", MessageBoxButtons.OK, MessageBoxIcon.Error);
            this.Close();
        }

        private void btnAnnuler_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTypeJeu_Load(object sender, EventArgs e)
        {

        }

    }
}


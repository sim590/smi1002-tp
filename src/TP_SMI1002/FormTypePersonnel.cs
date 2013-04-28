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
    public partial class FormTypePersonnel : Form
    {
        InterfaceBD interfaceBD;
        TypePersonnel mType = null;
        private int id = 0;
        //---------------
        // Constructeur
        //---------------
        public FormTypePersonnel()
        {
            interfaceBD = InterfaceBD.accesInstance();
            InitializeComponent();
        }

        public FormTypePersonnel(int id)
        {
            InitializeComponent();
            this.id = id;

            interfaceBD = InterfaceBD.accesInstance();
            interfaceBD.retournerObjet(ref mType, id);

            if (mType != null)
            {
                txtNom.Text = mType.Nom;
                pbCouleur.BackColor = Color.FromArgb(mType.Couleur);
            }
        }

        //----------------------
        // Choix de la couleur
        //----------------------
        private void btnCouleur_Click(object sender, EventArgs e)
        {
            if (cdCouleur.ShowDialog() == DialogResult.OK)
            {
                pbCouleur.BackColor = cdCouleur.Color;
            }
        }

        //-----------------------------------
        // Enregistrer un type de personnel
        //-----------------------------------
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            TypePersonnel type;

            if (pbCouleur.BackColor != null && Valider.estNomValide(this.txtNom.Text))
            {
                if (id == 0)
                {
                    type = new TypePersonnel(this.txtNom.Text, pbCouleur.BackColor.ToArgb());
                    // Ajout à la BD par le singleton
                    if (interfaceBD.ajoutBD(type) == -1)
                    {
                        MessageBox.Show("Impossible d'envoyer la requête.");
                        return;
                    }
                }
                else
                {
                    mType.Nom = txtNom.Text;
                    mType.Couleur = pbCouleur.BackColor.ToArgb();
                    interfaceBD.modifierBD(mType);
                }
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Veuillez entrer un nom valide et faire votre choix de couleur.");
        }

        // Annuler la transaction
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

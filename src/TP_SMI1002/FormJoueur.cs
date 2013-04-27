using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace TP_SMI1002
{
    public partial class FormJoueur : FormIdiotProof
    {
        private int id = 0;
        private InterfaceBD bd;

        public FormJoueur()
        {
            InitializeComponent();
        }

        public FormJoueur(int id, string nom, string gamerTag, string courriel, string sexe, DateTime date)
        {
            InitializeComponent();
            this.id = id;
            this.txtNom.Text = nom;
            this.txtGamerTag.Text = gamerTag;
            this.txtCourriel.Text = courriel;
            this.cbSexe.SelectedItem = sexe;
            this.dateTimePicker1.Value = date;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bool okay = true;

            if (txtNom.Text == "")
            {
                okay = false;
            }
            if (txtGamerTag.Text == "")
            {
                okay = false;
            }
            if (txtCourriel.Text == "")
            {
                okay = false;
            }
            if (cbSexe.SelectedText == null)
            {
                okay = false;
                MessageBox.Show("Ici");
            }

            if (okay)
            {
                bd = InterfaceBD.accesInstance();
                if (id == 0)
                {
                    //TODO: Ajouter dans la base de donnée
                }
                else //Update la base de donnée
                {
                    bd.modifierBD(new Joueur(id, txtNom.Text, txtGamerTag.Text, txtCourriel.Text, cbSexe.SelectedItem.ToString(), dateTimePicker1.Value));
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}

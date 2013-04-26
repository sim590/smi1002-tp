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

        //---------------------------------------------
        // Constructeur de base
        //---------------------------------------------
        public FormEquipe()
        {
            InitializeComponent();
        }

        //---------------------------------------------
        // Constructeur pour modifications
        //---------------------------------------------
        public FormEquipe(int id, string nom, string siteWeb)
        {
            InitializeComponent();
            this.id = id;
            this.txtNom.Text = nom;
            this.txtSite.Text = siteWeb;
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
                bd = InterfaceBD.accesInstance();
                if (id == 0)
                {
                    //TODO: Ajouter dans la base de donnée
                }
                else //Update la base de donnée
                {
                    bd.modifierBD(new Equipe(id, txtNom.Text, txtSite.Text));
                    this.DialogResult = DialogResult.OK;
                    this.Close();
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

       
    }
}

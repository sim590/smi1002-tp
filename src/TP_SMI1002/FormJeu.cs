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
        private int id = 0;
        InterfaceBD bd;
        Jeu mJeu = null;

        public FormJeu()
        {
            InitializeComponent();
        }

        public FormJeu(int id)
        {
            InitializeComponent();
            this.id = id;

            bd = InterfaceBD.accesInstance();
            bd.retournerObjet(ref mJeu, id);

            if (mJeu != null)
            {
                txtNom.Text = mJeu.Nom;
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            bd = InterfaceBD.accesInstance();

            if (id == 0)
            {
                Jeu jeu = new Jeu(this.txtNom.Text, ((TypeJeu)(cbTypeJeu.SelectedItem)).Id);
                bd.ajoutBD(jeu);                
            }
            else
            {
                Jeu jeu = new Jeu(this.id, this.txtNom.Text, ((TypeJeu)(cbTypeJeu.SelectedItem)).Id);
                bd.modifierBD(jeu);
            }
            this.DialogResult = DialogResult.OK;
            

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

            if (this.id > 0)
            {
                cbTypeJeu.SelectedIndex = RechercheIndexTypeJeu(mJeu.IDTypeJeu);
            }
        }
        private int RechercheIndexTypeJeu(int id)
        {
            for(int i=0;i<cbTypeJeu.Items.Count; i++)
            {
                if (((TypeJeu)cbTypeJeu.Items[i]).Id == id)
                {
                    return i;
                }
            }
           return -1;

        }
    }
}

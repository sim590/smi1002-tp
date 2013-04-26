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
    public partial class FormListeJeux : Form
    {
        public FormListeJeux()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormJeu formJeu = new FormJeu();
            formJeu.ShowDialog();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormListeJeux_Load(object sender, EventArgs e)
        {
            InterfaceBD bd = InterfaceBD.accesInstance();
            List<JeuAvecType> lstJeuAvecType = new List<JeuAvecType>();

            bd.remplirListe(ref lstJeuAvecType);

            for (int i = 0; i < lstJeuAvecType.Count(); i++)
            {

            }
        }
    }
}

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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void optQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            //Recherche du control de type mdiClient une fois trouvé on lui donne la couleur de fond voulu 
            //et on sort de la boucle
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackColor = Color.MintCream;
                    break;
                }
            }
                
            //"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\dspMillageFuel.accdb";
        }

        private void optEquipes_Click(object sender, EventArgs e)
        {
            FormListeEquipes FormEquipes = new FormListeEquipes();
            FormEquipes.ShowDialog();
        }

        private void optJoueur_Click(object sender, EventArgs e)
        {
            FormListeJoueurs FormJoueurs = new FormListeJoueurs(FormListeJoueurs.mode.liste);
            FormJoueurs.ShowDialog();
        }

        private void optPersonnel_Click(object sender, EventArgs e)
        {
            FormListePersonnels FormPersonnels = new FormListePersonnels();
            FormPersonnels.ShowDialog();
        }

        private void optTypePersonnel_Click(object sender, EventArgs e)
        {
            FormListeTypePersonnel FormTypePersonnel = new FormListeTypePersonnel();
            FormTypePersonnel.ShowDialog();
        }

        private void optAProposDe_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.ShowDialog();
        }

        private void événementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeEvenements formEvenement = new FormListeEvenements();
            formEvenement.ShowDialog();
        }
    }
}

//-----------------------------------------------------
// Fichier: InterfaceBD.cs  Auteur: Simon DÉSAULNIERS
//                                  Daniel St-Pierre
//
//-----------------------------------------------------

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

        }

        private void optEvenements_Click(object sender, EventArgs e)
        {
            FormListeEvenements FormEvenements = new FormListeEvenements();
            FormEvenements.ShowDialog();
        }

        private void optJeux_Click(object sender, EventArgs e)
        {
            FormListeJeux FormJeux = new FormListeJeux();
            FormJeux.ShowDialog();
        }

        private void optJoueur_Click(object sender, EventArgs e)
        {
        }

        private void optPersonnel_Click(object sender, EventArgs e)
        {

        }

        private void optTypePersonnel_Click(object sender, EventArgs e)
        {

        }

        private void optAProposDe_Click(object sender, EventArgs e)
        {
            About formAbout = new About();
            formAbout.ShowDialog();
        }

        private void typeDeJeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeTypeJeu TypeJeu = new FormListeTypeJeu();
            TypeJeu.ShowDialog();
        }

        private void tournoiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListeTournoi Tournoi = new FormListeTournoi();
            Tournoi.ShowDialog();
        }
    }
}

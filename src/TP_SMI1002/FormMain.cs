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
        ObjOracleConnexion cn;
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
            
            //Connection base de données
            ObjOracleConnexion.connectionString = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=neptune.uqtr.ca)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=coursbd)));User Id=SMI1002_37;Password=86nsed58;";
                
            //"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Path.GetDirectoryName(Application.ExecutablePath) + "\\dspMillageFuel.accdb";

            try
            {
                cn = new ObjOracleConnexion();
            }
            catch
            {
                MessageBox.Show("le fichier dspMillageFuel.accdb est nécessaire au bon fonctionnement de cette application, de plus il doit se trouver dans le même dossier que le fichier DspMillageFuel.exe " +
                                    "\nVous devez également disposer d'une version de microsoft access 2007 ou supérieure installé sur votre système");
                System.Environment.Exit(-1);
            }
        }

        private void optEquipes_Click(object sender, EventArgs e)
        {
            FormListeEquipes FormEquipes = new FormListeEquipes();
            FormEquipes.ShowDialog();


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
            FormListeJoueurs FormJoueurs = new FormListeJoueurs();
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
    }
}

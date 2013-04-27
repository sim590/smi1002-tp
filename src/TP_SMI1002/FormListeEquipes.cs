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
    public partial class FormListeEquipes : Form
    {
        //ObjOracleConnexion cn;
        List<Equipe> lstEquipe = new List<Equipe>();
        InterfaceBD bd;

        public FormListeEquipes()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            FormEquipe FormEquipe = new FormEquipe();
            FormEquipe.ShowDialog();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListeEquipes_Load(object sender, EventArgs e)
        {
            this.RefreshListe();

            /*cn = new ObjOracleConnexion();
            OracleDataReader rs = cn.cmdData("select idequipe, nom, siteweb from equipe order by idequipe");
            while (rs.Read())
            {
                ListViewItem lsv = new ListViewItem(rs.GetOracleValue(1).ToString());
                lsv.SubItems.Add(rs.GetOracleValue(2).ToString());
                lsv.Tag = rs.GetOracleValue(0).ToString();

                lsvEquipe.Items.Add(lsv);
            }
            rs.Close();*/
            
        }

        private void RefreshListe()
        {
            lstEquipe.Clear();
            lsvEquipe.Items.Clear();
            bd = InterfaceBD.accesInstance();
            bd.remplirListe(ref lstEquipe);

            ListViewItem lsv;
            for (int i = 0; i < lstEquipe.Count; i++)
            {
                lsv = new ListViewItem(lstEquipe[i].Nom);
                lsv.SubItems.Add(lstEquipe[i].SiteWeb);
                lsv.Tag = lstEquipe[i].Id;

                lsvEquipe.Items.Add(lsv);
            }

            lsvEquipe.Refresh();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (lsvEquipe.SelectedItems.Count == 1)
            {
                FormEquipe frmEquipe = new FormEquipe((int)lsvEquipe.SelectedItems[0].Tag, lsvEquipe.SelectedItems[0].SubItems[1].Text, lsvEquipe.SelectedItems[0].SubItems[0].Text);

                if (frmEquipe.ShowDialog() == DialogResult.OK)
                {
                    this.RefreshListe();
                }

            }
            else
            {
                MessageBox.Show("Veuillez choisir une équipe parmis la liste.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        
    }
}

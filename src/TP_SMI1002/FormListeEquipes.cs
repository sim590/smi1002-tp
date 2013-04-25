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
        ObjOracleConnection cn;

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
            cn = new ObjOracleConnection();
            OracleDataReader rs = cn.cmdData("select idequipe, nom, siteweb from equipe order by idequipe");
            while (rs.Read())
            {
                ListViewItem lsv = new ListViewItem(rs.GetOracleValue(1).ToString());
                lsv.SubItems.Add(rs.GetOracleValue(2).ToString());
                lsv.Tag = rs.GetOracleValue(0).ToString();

                lsvEquipe.Items.Add(lsv);
            }
            rs.Close();
            
        }
    }
}

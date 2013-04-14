using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Oracle.DataAccess.Client;

namespace TP_SMI1002
{
    public class clsDbConnection
    {
        public static string connectionString;
        private OracleConnection cnLanUQTR;

        public clsDbConnection()
        {
            cnLanUQTR = new OracleConnection(connectionString);
            cnLanUQTR.Open();
        }

        /*public OleDbCommand cmd()
        {
            return new OracleCommand(cnLanUQTR);
        }*/

        ~clsDbConnection()
        {
            try
            {
                cnLanUQTR.Close();
            }
            catch
            {
            }
        }
    }
}

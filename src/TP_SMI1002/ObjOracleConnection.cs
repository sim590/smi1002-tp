using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using Oracle.DataAccess.Client;

namespace TP_SMI1002
{
    //TODO: FAIRE UN SINGLETON OU PATRON FABRIQUE..
    public class ObjOracleConnection
    {
        public static string connectionString;
        private OracleConnection cnLanUQTR;

        public ObjOracleConnection()
        {
            cnLanUQTR = new OracleConnection(connectionString);
            cnLanUQTR.Open();
        }

        public OracleDataReader cmdData(String sql)
        {
            OracleCommand cmd = new OracleCommand(sql, cnLanUQTR);
            OracleDataReader rs = cmd.ExecuteReader();
            return rs;
        }

        ~ObjOracleConnection()
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

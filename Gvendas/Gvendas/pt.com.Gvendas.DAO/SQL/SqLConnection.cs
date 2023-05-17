using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gvendas.pt.com.Gvendas.DAO.SQL
{
    internal class SqLConnection
    {
        static string workingDirectory = Environment.CurrentDirectory;
        static internal int DBMSactive { get; set; } = 2;
        static string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
        static internal SqlConnection conn_sqlserver = null;
        public static string clipboardText = null;
        static private readonly String sqlConnStringBdLocal = $@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aluno\Source\Repos\Exercicio-P1\Ex1\Database1.mdf;Integrated Security = True";

        static internal DbConnection OpenConnection(int dbmsToActivate)
        {
            DBMSactive = dbmsToActivate;
            return OpenConnection();
        }

        static internal DbConnection OpenConnection()
        {
            CloseAllConnections(false);

            DbConnection connection = null;
            return connection;
        }
        static internal void CloseAllConnections(bool dbmsActiveNull)
        {

            if (conn_sqlserver != null)
            {
                conn_sqlserver.Close();
                conn_sqlserver = null;
            }
        }

    }
}

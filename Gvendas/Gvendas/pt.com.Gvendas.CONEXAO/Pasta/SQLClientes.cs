using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using static Gvendas.pt.com.Gvendas.DAO.SQL.SqLConnection;

namespace Gvendas.pt.com.Gvendas.CONEXAO.Pasta
{
    internal class SQLClientes
    {
        static public void Insert(Cliente cliente)
        {
            using (DbConnection conn = OpenConnection())
            {
                using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = "INSERT INTO \"clientes\" "
                    + "(id, nome, telefone, email, morada) "
                    + "VALUES (@id, @nome, @telefone, @email, @morada);";
                    sqlCommand.Parameters.Add(new SqlParameter("@id", cliente.Id));
                    sqlCommand.Parameters.Add(new SqlParameter("@nome", cliente.Nome));
                    sqlCommand.Parameters.Add(new SqlParameter("@telefone", cliente.Telefone));
                    sqlCommand.Parameters.Add(new SqlParameter("@email", cliente.Email));
                    sqlCommand.Parameters.Add(new SqlParameter("@morada", cliente.Morada));
                }
            }
        }
    }
}

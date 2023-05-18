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
            try
            {
                using (DbConnection conn = OpenConnection())
                {
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "INSERT INTO \"clientes\" "
                        + "(nome, telefone, email, morada) "
                        + "VALUES (@nome, @telefone, @email, @morada);";
                        //sqlCommand.Parameters.Add(new SqlParameter("@id", cliente.Id));
                        sqlCommand.Parameters.Add(new SqlParameter("@nome", cliente.Nome));
                        sqlCommand.Parameters.Add(new SqlParameter("@telefone", cliente.Telefone));
                        sqlCommand.Parameters.Add(new SqlParameter("@email", cliente.Email));
                        sqlCommand.Parameters.Add(new SqlParameter("@morada", cliente.Morada));


                        if (sqlCommand.ExecuteNonQuery() != 1)
                        {
                            throw new System.Exception("[SQLCliente] - Ocorreu um erro na query sql");
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {

                throw new System.Exception(ex.Message, ex.InnerException);
            }
        }
    }
}

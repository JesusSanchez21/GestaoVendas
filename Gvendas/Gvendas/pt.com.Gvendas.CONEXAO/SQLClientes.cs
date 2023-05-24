using System;
using System.Collections.Generic;
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

        internal static List<Cliente> getAll()
        {
            List<Cliente> clientes = new List<Cliente>();
            Cliente cliente = null;


            try
            {
                //open connection to database
                using (DbConnection conn = OpenConnection())
                {
                    //instance to allow sql commands
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        string query = "Select * from clientes;";
                        //defining commmand type
                        sqlCommand.CommandText = query;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = ((SqlConnection)conn);


                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                cliente = new Cliente(
                                    reader.GetInt32(reader.GetOrdinal("ID")),
                                    reader["Nome"].ToString(),                                    
                                    reader["Morada"].ToString(),
                                    reader["Email"].ToString(),
                                    int.Parse(reader["Telefone"].ToString())
                                    );
                                clientes.Add(cliente);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Um erro ocorreu -  contacte do administrador de sistema." + ex.Message);
                return null;
            }

            return clientes;
        }
    }
}

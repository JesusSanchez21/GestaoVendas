using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static Gvendas.pt.com.Gvendas.DAO.SQL.SqLConnection;
using Gvendas.pt.com.Gvendas.MODEL;
using System.Data.Common;
using System.Data;

namespace Gvendas.pt.com.Gvendas.CONEXAO
{
    internal class SQLFuncionarios
    {
        static public void Insert(Funcionarios funcionario)
        {
            try
            {
                using (DbConnection conn = OpenConnection())
                {
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "INSERT INTO \"funcionarios\" "
                        + "(nome, telefone, email, morada, numeroInterno) "
                        + "VALUES (@nome, @telefone, @email, @morada, @numeroInterno);";
                        //sqlCommand.Parameters.Add(new SqlParameter("@id", cliente.Id));
                        sqlCommand.Parameters.Add(new SqlParameter("@nome", funcionario.Nome));
                        sqlCommand.Parameters.Add(new SqlParameter("@telefone", funcionario.Telefone));
                        sqlCommand.Parameters.Add(new SqlParameter("@email", funcionario.Email));
                        sqlCommand.Parameters.Add(new SqlParameter("@morada", funcionario.Morada));
                        sqlCommand.Parameters.Add(new SqlParameter("@numeroInterno", funcionario.NumeroInterno));


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
        internal static List<Funcionarios> getAll()
        {
            List<Funcionarios> funcionarios = new List<Funcionarios>();
            Funcionarios funcionario = null;
            try
            {
                //open connection to database
                using (DbConnection conn = OpenConnection())
                {
                    //instance to allow sql commands
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        string query = "Select * from funcionarios;";
                        //defining commmand type
                        sqlCommand.CommandText = query;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = ((SqlConnection)conn);


                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                funcionario = new Funcionarios(
                                    reader.GetInt32(reader.GetOrdinal("id")),
                                    reader["nome"].ToString(),
                                    reader["morada"].ToString(),
                                    reader["email"].ToString(),
                                    int.Parse(reader["telefone"].ToString()),
                                    int.Parse(reader["numeroInterno"].ToString())
                                    );
                                funcionarios.Add(funcionario);
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

            return funcionarios;
        }
    }
    }

using Gvendas.pt.com.Gvendas.MODEL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using static Gvendas.pt.com.Gvendas.DAO.SQL.SqLConnection;

namespace Gvendas.pt.com.Gvendas.CONEXAO
{
    class SQLEncomendas
    {
        static public void Insert(Encomendas encomenda)
        {
            try
            {
                using (DbConnection conn = OpenConnection())
                {
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = "INSERT INTO \"encomendas\" "
                        + "(cliente_id ,funcionario_id, dataEncomenda, valorTotal) "
                        + "VALUES (@cliente_id, @funcionario_id, @dataEncomenda, @valorTotal);";
                        //sqlCommand.Parameters.Add(new SqlParameter("@id", cliente.Id));
                        sqlCommand.Parameters.Add(new SqlParameter("@cliente_id", encomenda.Cliente_id));
                        sqlCommand.Parameters.Add(new SqlParameter("@funcionario_id", encomenda.DataEncomenda));
                        sqlCommand.Parameters.Add(new SqlParameter("@dataEncomenda", encomenda.Funcionario_id));
                        sqlCommand.Parameters.Add(new SqlParameter("@valorTotal", encomenda.ValorTotal));

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
        internal static List<Encomendas> getAll()
        {
            List<Encomendas> encomendas = new List<Encomendas>();
            Encomendas encomenda = null;
            try
            {
                //open connection to database
                using (DbConnection conn = OpenConnection())
                {
                    //instance to allow sql commands
                    using (SqlCommand sqlCommand = ((SqlConnection)conn).CreateCommand())
                    {
                        string query = "Select * from encomendas;";
                        //defining commmand type
                        sqlCommand.CommandText = query;
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.Connection = ((SqlConnection)conn);


                        using (SqlDataReader reader = sqlCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                //encomendas = new Encomendas(
                                //    reader.GetInt32(reader.GetOrdinal("id")),
                                //    int.Parse(reader["valorTotal"].ToString()),
                                //    (DateTime)reader["dataEncomenda"]),
                                //    int.Parse(reader["cliente_id"].ToString()),
                                //    int.Parse(reader["funcionario_id"].ToString())
                                //    );
                                encomendas.Add(encomenda);
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

            return encomendas;
        }
    }
}

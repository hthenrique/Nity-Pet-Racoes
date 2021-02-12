using Nity_Pet_Rações.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nity_Pet_Rações.Banco_de_Dados
{
    class BDHelper
    {
        SqlConnection sqlconnection;
        SqlCommand sqlCommand;        
        SqlDataReader sqlDataReader;

        string bdCaminho = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\BDNity\BDNity.mdf;Integrated Security=True;Connect Timeout=30";
        string sqlString;

        public string inserirFornecedor(ModelFornecedor fornecedor)
        {
            sqlString = "INSERT INTO Fornecedor (nomeFornecedor, telFornecedor, endFornecedor) " +
                        "VALUES (@NOME, @TELEFONE, @ENDERECO)";
            try
            {
                sqlconnection = new SqlConnection(bdCaminho);
                sqlCommand = new SqlCommand(sqlString, sqlconnection);

                sqlCommand.Parameters.AddWithValue("@NOME", fornecedor.nomeFornecedor.ToString());
                sqlCommand.Parameters.AddWithValue("@TELEFONE", fornecedor.telFornecedor.ToString());
                sqlCommand.Parameters.AddWithValue("@ENDERECO", fornecedor.endFornecedor.ToString());

                sqlconnection.Open();
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
            finally
            {
                sqlconnection.Close();
                sqlCommand.Clone();
                sqlconnection = null;
                sqlCommand = null;
            }
            return string.Empty;
        }

        internal string excluirFornecedor(string id)
        {
            sqlString = "DELETE FROM Fornecedor WHERE idFornecedor = @ID";
            sqlconnection = new SqlConnection(bdCaminho);
            sqlCommand = new SqlCommand(sqlString, sqlconnection);
            try
            {
                using (sqlconnection)
                {
                    using (sqlCommand)
                    {
                        sqlCommand.Parameters.AddWithValue("@ID", id);
                        sqlconnection.Open();
                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

            return string.Empty;
        }

        public List<ModelFornecedor> consultarFornecedores()
        {
            List<ModelFornecedor> listaFornecedores = new List<ModelFornecedor>();
            sqlString = "SELECT * FROM Fornecedor";
            sqlconnection = new SqlConnection(bdCaminho);
            sqlCommand = new SqlCommand(sqlString, sqlconnection);

            using (sqlconnection)
            {
                using (sqlCommand)
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlconnection.Open();
                    sqlDataReader = sqlCommand.ExecuteReader();
                    using (sqlDataReader)
                    {
                        while (sqlDataReader.Read())
                        {
                            listaFornecedores.Add(new ModelFornecedor
                            {
                                idFornecedor = Convert.ToInt32(sqlDataReader["idFornecedor"]),
                                nomeFornecedor = sqlDataReader["nomeFornecedor"].ToString(),
                                telFornecedor = sqlDataReader["telFornecedor"].ToString(),
                                endFornecedor = sqlDataReader["endFornecedor"].ToString()
                            });
                        }
                    }
                }
            }
            return listaFornecedores;            
        }

        public List<ModelFornecedor> consultarFornecedor(string fornecedor)
        {
            List<ModelFornecedor> listaFornecedor = new List<ModelFornecedor>();
            sqlString = "SELECT * FROM Fornecedor WHERE nomeFornecedor LIKE '%" + fornecedor + "%'";
            sqlconnection = new SqlConnection(bdCaminho);
            sqlCommand = new SqlCommand(sqlString, sqlconnection);

            using (sqlconnection)
            {
                using (sqlCommand)
                {                    
                    sqlCommand.CommandType = CommandType.Text;
                    sqlconnection.Open();
                    sqlDataReader = sqlCommand.ExecuteReader();
                    using (sqlDataReader)
                    {
                        while (sqlDataReader.Read())
                        {
                            listaFornecedor.Add(new ModelFornecedor
                            {
                                idFornecedor = Convert.ToInt32(sqlDataReader["idFornecedor"]),
                                nomeFornecedor = sqlDataReader["nomeFornecedor"].ToString(),
                                telFornecedor = sqlDataReader["telFornecedor"].ToString(),
                                endFornecedor = sqlDataReader["endFornecedor"].ToString()
                            });
                        }
                    }          
                }
            }
            return listaFornecedor;
        }
    }
}

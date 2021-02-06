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
        SqlDataAdapter sqlDataAdapter;
        SqlDataReader sqlDataReader;
        DataSet dataSet;

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
                sqlCommand.Parameters.AddWithValue("@ENDERECO", fornecedor.endFornecefor.ToString());

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

        public DataTable consultarFornecedores()
        {
            sqlString = "SELECT * FROM Fornecedor";
            DataTable dataTable = new DataTable();
            sqlconnection = new SqlConnection(bdCaminho);
            sqlCommand = new SqlCommand(sqlString, sqlconnection);

            using (sqlconnection)
            {
                using (sqlCommand)
                {
                    sqlconnection.Open();
                    sqlDataReader = sqlCommand.ExecuteReader();
                    dataTable.Load(sqlDataReader);
                }
            }
            return dataTable;            
        }
    }
}

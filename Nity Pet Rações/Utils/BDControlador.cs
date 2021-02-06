using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nity_Pet_Rações.Banco_de_Dados;

namespace Nity_Pet_Rações.Utils
{
    class BDControlador
    {
        public static string deletar(string id, string tabela)
        {
            string deletar = null;
            switch (tabela)
            {
                case "Fornecedor":
                    BDHelper bDHelper = new BDHelper();
                    deletar = bDHelper.excluirFornecedor(id);
                    break;
            }
            return deletar;
        }

        public DataTable consultar(string tabela)
        {

            DataTable dataTable = null;
            switch (tabela)
            {
                case "Fornecedor":
                    BDHelper bDHelper = new BDHelper();
                    dataTable = bDHelper.consultarFornecedores();
                    break;
            }
            return dataTable;
        }
    }
}

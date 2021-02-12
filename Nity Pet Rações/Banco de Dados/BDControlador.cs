using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nity_Pet_Rações.Banco_de_Dados;
using Nity_Pet_Rações.Models;

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

        public string consultar(string tabela)
        {

            string dados = null;
            switch (tabela)
            {
                case "Fornecedor":
                    BDHelper bDHelper = new BDHelper();
                    
                    break;
            }
            return dados;
        }
    }
}

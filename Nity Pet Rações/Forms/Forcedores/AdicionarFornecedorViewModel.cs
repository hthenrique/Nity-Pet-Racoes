using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nity_Pet_Rações.Models;
using Nity_Pet_Rações.Banco_de_Dados;

namespace Nity_Pet_Rações.Forms.Forcedores
{
    class AdicionarFornecedorViewModel
    {
        public string addFornecedor(ModelFornecedor modelFornecedor)
        {
            string resultado = null;
            BDHelper bDHelper = new BDHelper();

            if (modelFornecedor.nomeFornecedor != null)
            {
                var consultarFornecedor = bDHelper.consultarFornecedor(modelFornecedor.nomeFornecedor.ToString());
                if(consultarFornecedor.Count > 0)
                {
                    resultado = "Esse Fornecedor já existe";
                    return resultado;
                }
                else
                {
                    resultado = bDHelper.inserirFornecedor(modelFornecedor);
                    return resultado;
                }
            }
            return string.Empty;
        }
    }
}

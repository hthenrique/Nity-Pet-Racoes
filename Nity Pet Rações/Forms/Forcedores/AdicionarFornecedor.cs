using Nity_Pet_Rações.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nity_Pet_Rações.Forms.Forcedores
{
    public partial class AdicionarFornecedor : Form
    {
        public AdicionarFornecedor()
        {
            InitializeComponent();
        }

        private void salvarFornecedor_Click(object sender, EventArgs e)
        {
            string nomeFornecedor = textBoxNomeFornecedor.Text.ToString();
            string telFornecedor = textBoxTelFornecedor.Text.ToString();
            string endFornecedor = textBoxEndFornecedor.Text.ToString();

            ModelFornecedor modelFornecedor = new ModelFornecedor();
            modelFornecedor.nomeFornecedor = nomeFornecedor;
            modelFornecedor.telFornecedor = telFornecedor;
            modelFornecedor.endFornecefor = endFornecedor;
            Banco_de_Dados.BDHelper bDHelper = new Banco_de_Dados.BDHelper();

            string novoFonecedor = bDHelper.inserirFornecedor(modelFornecedor);

            if (string.IsNullOrEmpty(novoFonecedor))
            {
                this.Close();
            }
            else
            {
                MessageBox.Show(novoFonecedor);
            }
        }
    }
}

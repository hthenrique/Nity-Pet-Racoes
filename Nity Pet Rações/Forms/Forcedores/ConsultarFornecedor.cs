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
    public partial class ConsultarFornecedor : Form
    {
        public ConsultarFornecedor()
        {
            InitializeComponent();
        }
        private void ConsultarFornecedor_Load(object sender, EventArgs e)
        {
            Banco_de_Dados.BDHelper bDHelper = new Banco_de_Dados.BDHelper();
            listaFornecedores.DataSource = bDHelper.consultarFornecedores();
        }

        private void listaFornecedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            listaFornecedores.CurrentRow.Selected = true;

            string id = listaFornecedores.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
            string nome = listaFornecedores.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();

            string message = "Deseja excluir esse fornecedor? " + nome;
            string caption = "Excluir Fornecedor";
            MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            Banco_de_Dados.BDHelper bDHelper = new Banco_de_Dados.BDHelper();
            string returno = bDHelper.excluirFornecedor(id);

            if (string.IsNullOrEmpty(returno))
            {
                MessageBox.Show("Deletado com Sucesso", "Sucesso");
                listaFornecedores.DataSource = bDHelper.consultarFornecedores();
            }
            else
            {
                MessageBox.Show(returno);
            }
        }

        private void addFornecedor_Click(object sender, EventArgs e)
        {
            AdicionarFornecedor adicionarFornecedor = new AdicionarFornecedor();
            adicionarFornecedor.ShowDialog();
        }
    }
}

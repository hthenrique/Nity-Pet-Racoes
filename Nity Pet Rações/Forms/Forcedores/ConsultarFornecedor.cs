using System;
using System.Windows.Forms;
using Nity_Pet_Rações.Utils;

namespace Nity_Pet_Rações.Forms.Forcedores
{
    public partial class ConsultarFornecedor : Form
    {
        Banco_de_Dados.BDHelper bDHelper;
        public ConsultarFornecedor()
        {
            InitializeComponent();
        }
        private void ConsultarFornecedor_Load(object sender, EventArgs e)
        {
            listaFornecedores.Columns[0].HeaderText = "Id";
            listaFornecedores.Columns[1].HeaderText = "Nome";
            listaFornecedores.Columns[2].HeaderText = "Telefone";
            listaFornecedores.Columns[3].HeaderText = "Endereço";

            bDHelper = new Banco_de_Dados.BDHelper();
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

            string returno = BDControlador.deletar(id, "Fornecedor");

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
            InstanciarForms.VerificarForm("AdicionarFornecedor");
        }

        private void atualizarListaBtn_Click(object sender, EventArgs e)
        {
            listaFornecedores.DataSource = bDHelper.consultarFornecedores();
        }
    }
}

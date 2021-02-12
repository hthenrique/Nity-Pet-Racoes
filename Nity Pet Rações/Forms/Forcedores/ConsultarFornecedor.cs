using System;
using System.Windows.Forms;
using Nity_Pet_Rações.Utils;
using Nity_Pet_Rações.Models;

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

            var deletar = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(deletar == DialogResult.Yes)
            {
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
            if(deletar == DialogResult.No)
            {
                return;
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

        private void buscarForncedor_Click(object sender, EventArgs e)
        {
            string buscaFornecedor = textBoxBuscaFornecedor.Text.ToString().Trim();
            listaFornecedores.DataSource = bDHelper.consultarFornecedor(buscaFornecedor);
        }
    }
}

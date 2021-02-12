using Nity_Pet_Rações.Forms.Forcedores;
using Nity_Pet_Rações.Utils;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Nity_Pet_Rações
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            vendaFiadaCheck();
            produtoDados.Visible = false;
        }

        private void vendaFiada_CheckedChanged(object sender, EventArgs e)
        {
            vendaFiadaCheck();
        }

        private void addFornecedor_Click(object sender, EventArgs e)
        {
            InstanciarForms.VerificarForm("AdicionarFornecedor");
        }

        private void consultarFornecedor_Click(object sender, EventArgs e)
        {
            InstanciarForms.VerificarForm("ConsultarFornecedor");
        }
        private void vendaFiadaCheck()
        {
            switch (vendaFiada.CheckState)
            {
                case CheckState.Checked:
                    cpfTextBox.Enabled = true;
                    buscarCpfBtn.Enabled = true;

                    break;
                case CheckState.Unchecked:
                    cpfTextBox.Enabled = false;
                    buscarCpfBtn.Enabled = false;

                    break;
            }
        }
        
    }
}

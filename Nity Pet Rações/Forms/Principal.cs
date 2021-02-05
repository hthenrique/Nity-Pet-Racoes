using Nity_Pet_Rações.Forms.Forcedores;
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
        }

        private void vendaFiada_CheckedChanged(object sender, EventArgs e)
        {
            vendaFiadaCheck();
        }

        private void addFornecedor_Click(object sender, EventArgs e)
        {
            AdicionarFornecedor adicionarFornecedor = new AdicionarFornecedor();
            adicionarFornecedor.ShowDialog();
        }

        private void consultarFornecedor_Click(object sender, EventArgs e)
        {
            
            var consultarFornecedor = Utils.InstanciarForms.VerificarForm(this, "ConsultarFornecedor");
            
            if (consultarFornecedor == null)
            {
                return;
            }
            if (Application.OpenForms.OfType<ConsultarFornecedor>().Count() > 0)
            {
                consultarFornecedor.MdiParent = this;
                consultarFornecedor.Show();
                //consultarFornecedor.BringToFront();
                //consultarFornecedor.Activate();             
            }
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

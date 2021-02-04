using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nity_Pet_Rações
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void addFornecedor_Click(object sender, EventArgs e)
        {
            Forms.Forcedores.AdicionarFornecedor adicionarFornecedor = new Forms.Forcedores.AdicionarFornecedor();
            adicionarFornecedor.ShowDialog();
        }

        private void consultarFornecedor_Click(object sender, EventArgs e)
        {
            var consultarFornecedor = Utils.InstanciarForms.VerificarForm(this, "ConsultarForncedor");
            if(consultarFornecedor == null)
            {
                return;
            }
            else
            {
                consultarFornecedor.MdiParent = this;
                consultarFornecedor.Show();
            }
        }
    }
}

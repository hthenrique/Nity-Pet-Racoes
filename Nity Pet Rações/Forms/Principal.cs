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
            this.IsMdiContainer = true;
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

            var consultarFornecedor = Application.OpenForms.OfType<ConsultarFornecedor>().FirstOrDefault();
            if(consultarFornecedor == null)
            {
                consultarFornecedor = new ConsultarFornecedor();
                consultarFornecedor.Show();

            }
            else
            {
                consultarFornecedor.BringToFront();
                consultarFornecedor.Activate();
            }

            //this.MostrarOuCriar<ConsultarFornecedor>();

            /*var consultarFornecedor = Utils.InstanciarForms.VerificarForm(this, "ConsultarFornecedor");

            if (consultarFornecedor == null)
            {
                return;
            }
            else
            {
                consultarFornecedor.MdiParent = this;
                consultarFornecedor.Show();
            }
            if (Application.OpenForms.OfType<ConsultarFornecedor>().Count() > 0)
            {

                //consultarFornecedor.BringToFront();
                //consultarFornecedor.Activate();             
            }*/
            //var consultarFornecedor = new ConsultarFornecedor();
            //consultarFornecedor.ShowDialog();
        }

        private void MostrarOuCriar<TForm>() where TForm: Form, new()
        {
            var instancia = Application.OpenForms.OfType<TForm>().FirstOrDefault();
            if(instancia == null)
            {
                instancia = new TForm();
                instancia.MdiParent = this;
                instancia.Show();
            }
            else
            {
                instancia.BringToFront();
                instancia.Activate();
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

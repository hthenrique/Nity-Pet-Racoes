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

        private void AdicionarFornecedor_Load(object sender, EventArgs e)
        {
            //telMask();
        }

        private void salvarFornecedor_Click(object sender, EventArgs e)
        {
            addFornecedor();
        }

        private void textBoxNomeFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                addFornecedor();
            }
        }

        private void textBoxTelFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                addFornecedor();
            }
        }

        private void textBoxEndFornecedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                addFornecedor();
            }
        }

        private void addFornecedor()
        {
            ModelFornecedor modelFornecedor = new ModelFornecedor();
            AdicionarFornecedorViewModel addFornecedorViewModel = new AdicionarFornecedorViewModel();
            var validar = true;

            modelFornecedor.nomeFornecedor = textBoxNomeFornecedor.Text.ToString().Trim();
            modelFornecedor.telFornecedor = textBoxTelFornecedor.Text.ToString().Trim();
            modelFornecedor.endFornecedor = textBoxEndFornecedor.Text.ToString().Trim();

            if (textBoxNomeFornecedor.Text.Equals(""))
            {
                validar = false;
            }
            if (textBoxTelFornecedor.Text.Equals(""))
            {
                validar = false;
            }
            if (textBoxEndFornecedor.Text.Equals(""))
            {
                validar = false;
            }

            if (validar)
            {
                string novoFornecedor = addFornecedorViewModel.addFornecedor(modelFornecedor);

                if (string.IsNullOrEmpty(novoFornecedor) || novoFornecedor == null)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show(novoFornecedor);
                }
            }
            else
            {
                MessageBox.Show("Há campo vazio", "Erro");
            }
            
        }

        private void textBoxTelFornecedor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void telMask()
        {
            long tel = Convert.ToInt64(textBoxTelFornecedor.Text);
            string telFormatado = String.Format(@"{0:\(00)\00000\-\0000}", tel);
            textBoxTelFornecedor.Text = telFormatado;
        }
    }
}

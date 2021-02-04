
namespace Nity_Pet_Rações.Forms.Forcedores
{
    partial class ConsultarFornecedor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listaFornecedores = new System.Windows.Forms.DataGridView();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.atualizarListaBtn = new System.Windows.Forms.Button();
            this.addFornecedor = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bDNityDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.listaFornecedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDNityDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listaFornecedores
            // 
            this.listaFornecedores.AutoGenerateColumns = false;
            this.listaFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listaFornecedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.listaFornecedores.BackgroundColor = System.Drawing.Color.White;
            this.listaFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaFornecedores.DataSource = this.fornecedorBindingSource;
            this.listaFornecedores.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listaFornecedores.GridColor = System.Drawing.Color.SlateGray;
            this.listaFornecedores.Location = new System.Drawing.Point(0, 61);
            this.listaFornecedores.Name = "listaFornecedores";
            this.listaFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listaFornecedores.Size = new System.Drawing.Size(800, 327);
            this.listaFornecedores.TabIndex = 1;
            this.listaFornecedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listaFornecedores_CellDoubleClick);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.listaFornecedores);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 62);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(800, 388);
            this.panel4.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.atualizarListaBtn);
            this.panel1.Controls.Add(this.addFornecedor);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 61);
            this.panel1.TabIndex = 6;
            // 
            // atualizarListaBtn
            // 
            this.atualizarListaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(243)))));
            this.atualizarListaBtn.FlatAppearance.BorderSize = 0;
            this.atualizarListaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atualizarListaBtn.ForeColor = System.Drawing.Color.White;
            this.atualizarListaBtn.Location = new System.Drawing.Point(526, 20);
            this.atualizarListaBtn.Name = "atualizarListaBtn";
            this.atualizarListaBtn.Size = new System.Drawing.Size(128, 32);
            this.atualizarListaBtn.TabIndex = 26;
            this.atualizarListaBtn.Text = "Atualizar Lista";
            this.atualizarListaBtn.UseVisualStyleBackColor = false;
            // 
            // addFornecedor
            // 
            this.addFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(243)))));
            this.addFornecedor.FlatAppearance.BorderSize = 0;
            this.addFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFornecedor.ForeColor = System.Drawing.Color.White;
            this.addFornecedor.Location = new System.Drawing.Point(660, 20);
            this.addFornecedor.Name = "addFornecedor";
            this.addFornecedor.Size = new System.Drawing.Size(128, 32);
            this.addFornecedor.TabIndex = 25;
            this.addFornecedor.Text = "Adicionar Fornecedor";
            this.addFornecedor.UseVisualStyleBackColor = false;
            this.addFornecedor.Click += new System.EventHandler(this.addFornecedor_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(243)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(260, 20);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 32);
            this.button6.TabIndex = 24;
            this.button6.Text = "Buscar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome do Forncedor";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 450);
            this.panel3.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(243)))));
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.label3);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(800, 62);
            this.panel9.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(798, 60);
            this.label3.TabIndex = 3;
            this.label3.Text = "Consultar Fornecedores";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 8;
            // 
            // ConsultarFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "ConsultarFornecedor";
            this.Text = "ConsultarFornecedor";
            this.Load += new System.EventHandler(this.ConsultarFornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listaFornecedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bDNityDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bDNityDataSetBindingSource;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private System.Windows.Forms.DataGridView listaFornecedores;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button atualizarListaBtn;
        private System.Windows.Forms.Button addFornecedor;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}
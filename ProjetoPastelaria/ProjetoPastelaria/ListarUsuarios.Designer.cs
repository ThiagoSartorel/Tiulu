namespace ProjetoPastelaria
{
    partial class ListarUsuarios
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
            this.dataGridViewDados = new System.Windows.Forms.DataGridView();
            this.buttonListaFuncionario = new System.Windows.Forms.Button();
            this.buttonListaCliente = new System.Windows.Forms.Button();
            this.buttonListaProdutos = new System.Windows.Forms.Button();
            this.buttonListaUsuariosSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDados
            // 
            this.dataGridViewDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDados.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewDados.Name = "dataGridViewDados";
            this.dataGridViewDados.RowHeadersWidth = 51;
            this.dataGridViewDados.RowTemplate.Height = 29;
            this.dataGridViewDados.Size = new System.Drawing.Size(776, 379);
            this.dataGridViewDados.TabIndex = 0;
            // 
            // buttonListaFuncionario
            // 
            this.buttonListaFuncionario.Location = new System.Drawing.Point(12, 12);
            this.buttonListaFuncionario.Name = "buttonListaFuncionario";
            this.buttonListaFuncionario.Size = new System.Drawing.Size(94, 29);
            this.buttonListaFuncionario.TabIndex = 1;
            this.buttonListaFuncionario.Text = "Funcionario";
            this.buttonListaFuncionario.UseVisualStyleBackColor = true;
            this.buttonListaFuncionario.Click += new System.EventHandler(this.ButtonListaFuncionario_Click);
            // 
            // buttonListaCliente
            // 
            this.buttonListaCliente.Location = new System.Drawing.Point(112, 12);
            this.buttonListaCliente.Name = "buttonListaCliente";
            this.buttonListaCliente.Size = new System.Drawing.Size(94, 29);
            this.buttonListaCliente.TabIndex = 2;
            this.buttonListaCliente.Text = "Cliente";
            this.buttonListaCliente.UseVisualStyleBackColor = true;
            this.buttonListaCliente.Click += new System.EventHandler(this.ButtonListaCliente_Click);
            // 
            // buttonListaProdutos
            // 
            this.buttonListaProdutos.Location = new System.Drawing.Point(212, 12);
            this.buttonListaProdutos.Name = "buttonListaProdutos";
            this.buttonListaProdutos.Size = new System.Drawing.Size(94, 29);
            this.buttonListaProdutos.TabIndex = 3;
            this.buttonListaProdutos.Text = "Produtos";
            this.buttonListaProdutos.UseVisualStyleBackColor = true;
            this.buttonListaProdutos.Click += new System.EventHandler(this.ButtonListaProdutos_Click);
            // 
            // buttonListaUsuariosSair
            // 
            this.buttonListaUsuariosSair.Location = new System.Drawing.Point(694, 12);
            this.buttonListaUsuariosSair.Name = "buttonListaUsuariosSair";
            this.buttonListaUsuariosSair.Size = new System.Drawing.Size(94, 29);
            this.buttonListaUsuariosSair.TabIndex = 4;
            this.buttonListaUsuariosSair.Text = "Sair";
            this.buttonListaUsuariosSair.UseVisualStyleBackColor = true;
            this.buttonListaUsuariosSair.Click += new System.EventHandler(this.ButtonListaUsuariosSair_Click);
            // 
            // ListarUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonListaUsuariosSair);
            this.Controls.Add(this.buttonListaProdutos);
            this.Controls.Add(this.buttonListaCliente);
            this.Controls.Add(this.buttonListaFuncionario);
            this.Controls.Add(this.dataGridViewDados);
            this.Name = "ListarUsuarios";
            this.Text = "ListaFuncionario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridViewDados;
        private Button buttonListaFuncionario;
        private Button buttonListaCliente;
        private Button buttonListaProdutos;
        private Button buttonListaUsuariosSair;
    }
}
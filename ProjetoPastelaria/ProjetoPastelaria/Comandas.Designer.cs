namespace ProjetoPastelaria
{
    partial class Comandas
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
            this.dataGridViewComandas = new System.Windows.Forms.DataGridView();
            this.dataGridViewComandaItens = new System.Windows.Forms.DataGridView();
            this.dataGridViewProdutos = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxBuscaProduto = new System.Windows.Forms.TextBox();
            this.buttonAbrirComanda = new System.Windows.Forms.Button();
            this.buttonComandaBuscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaItens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewComandas
            // 
            this.dataGridViewComandas.AllowUserToAddRows = false;
            this.dataGridViewComandas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandas.Location = new System.Drawing.Point(12, 72);
            this.dataGridViewComandas.MultiSelect = false;
            this.dataGridViewComandas.Name = "dataGridViewComandas";
            this.dataGridViewComandas.RowHeadersWidth = 51;
            this.dataGridViewComandas.RowTemplate.Height = 29;
            this.dataGridViewComandas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandas.Size = new System.Drawing.Size(522, 188);
            this.dataGridViewComandas.TabIndex = 0;
            this.dataGridViewComandas.SelectionChanged += new System.EventHandler(this.dataGridViewComandas_SelectionChanged);
            // 
            // dataGridViewComandaItens
            // 
            this.dataGridViewComandaItens.AllowUserToAddRows = false;
            this.dataGridViewComandaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComandaItens.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewComandaItens.Location = new System.Drawing.Point(12, 301);
            this.dataGridViewComandaItens.MultiSelect = false;
            this.dataGridViewComandaItens.Name = "dataGridViewComandaItens";
            this.dataGridViewComandaItens.RowHeadersWidth = 51;
            this.dataGridViewComandaItens.RowTemplate.Height = 29;
            this.dataGridViewComandaItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewComandaItens.Size = new System.Drawing.Size(522, 222);
            this.dataGridViewComandaItens.TabIndex = 1;
            this.dataGridViewComandaItens.DoubleClick += new System.EventHandler(this.dataGridViewComandaItens_DoubleClick);
            // 
            // dataGridViewProdutos
            // 
            this.dataGridViewProdutos.AllowUserToAddRows = false;
            this.dataGridViewProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProdutos.Location = new System.Drawing.Point(540, 72);
            this.dataGridViewProdutos.MultiSelect = false;
            this.dataGridViewProdutos.Name = "dataGridViewProdutos";
            this.dataGridViewProdutos.RowHeadersWidth = 51;
            this.dataGridViewProdutos.RowTemplate.Height = 29;
            this.dataGridViewProdutos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProdutos.Size = new System.Drawing.Size(684, 451);
            this.dataGridViewProdutos.TabIndex = 2;
            this.dataGridViewProdutos.DoubleClick += new System.EventHandler(this.dataGridViewProdutos_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 27);
            this.textBox1.TabIndex = 3;
            // 
            // textBoxBuscaProduto
            // 
            this.textBoxBuscaProduto.Location = new System.Drawing.Point(624, 25);
            this.textBoxBuscaProduto.Name = "textBoxBuscaProduto";
            this.textBoxBuscaProduto.Size = new System.Drawing.Size(125, 27);
            this.textBoxBuscaProduto.TabIndex = 4;
            // 
            // buttonAbrirComanda
            // 
            this.buttonAbrirComanda.Location = new System.Drawing.Point(315, 24);
            this.buttonAbrirComanda.Name = "buttonAbrirComanda";
            this.buttonAbrirComanda.Size = new System.Drawing.Size(94, 29);
            this.buttonAbrirComanda.TabIndex = 5;
            this.buttonAbrirComanda.Text = "Abrir comanda";
            this.buttonAbrirComanda.UseVisualStyleBackColor = true;
            this.buttonAbrirComanda.Click += new System.EventHandler(this.buttonAbrirComanda_Click);
            // 
            // buttonComandaBuscar
            // 
            this.buttonComandaBuscar.Location = new System.Drawing.Point(755, 25);
            this.buttonComandaBuscar.Name = "buttonComandaBuscar";
            this.buttonComandaBuscar.Size = new System.Drawing.Size(94, 29);
            this.buttonComandaBuscar.TabIndex = 6;
            this.buttonComandaBuscar.Text = "Buscar";
            this.buttonComandaBuscar.UseVisualStyleBackColor = true;
            this.buttonComandaBuscar.Click += new System.EventHandler(this.buttonComandaBuscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(540, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Comandas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Itens da comanda";
            // 
            // Comandas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 535);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonComandaBuscar);
            this.Controls.Add(this.buttonAbrirComanda);
            this.Controls.Add(this.textBoxBuscaProduto);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewProdutos);
            this.Controls.Add(this.dataGridViewComandaItens);
            this.Controls.Add(this.dataGridViewComandas);
            this.Name = "Comandas";
            this.Text = "Comandas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComandaItens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridViewComandas;
        private DataGridView dataGridViewComandaItens;
        private DataGridView dataGridViewProdutos;
        private TextBox textBox1;
        private TextBox textBoxBuscaProduto;
        private Button buttonAbrirComanda;
        private Button buttonComandaBuscar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
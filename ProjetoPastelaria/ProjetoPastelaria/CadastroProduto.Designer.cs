namespace ProjetoPastelaria
{
    partial class CadastroProduto
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelCadProdNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelCadProValor = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelCadProgDesc = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userControl1 = new ProjetoPastelaria.UserControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "ID";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 67);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(75, 27);
            this.textBox5.TabIndex = 1;
            // 
            // labelCadProdNome
            // 
            this.labelCadProdNome.AutoSize = true;
            this.labelCadProdNome.Location = new System.Drawing.Point(114, 44);
            this.labelCadProdNome.Name = "labelCadProdNome";
            this.labelCadProdNome.Size = new System.Drawing.Size(42, 20);
            this.labelCadProdNome.TabIndex = 28;
            this.labelCadProdNome.Text = "Nom";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(114, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 27);
            this.textBox1.TabIndex = 2;
            // 
            // labelCadProValor
            // 
            this.labelCadProValor.AutoSize = true;
            this.labelCadProValor.Location = new System.Drawing.Point(413, 44);
            this.labelCadProValor.Name = "labelCadProValor";
            this.labelCadProValor.Size = new System.Drawing.Size(45, 20);
            this.labelCadProValor.TabIndex = 32;
            this.labelCadProValor.Text = "Value";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(413, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 27);
            this.textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 171);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(296, 229);
            this.textBox3.TabIndex = 4;
            // 
            // labelCadProgDesc
            // 
            this.labelCadProgDesc.AutoSize = true;
            this.labelCadProgDesc.Location = new System.Drawing.Point(12, 148);
            this.labelCadProgDesc.Name = "labelCadProgDesc";
            this.labelCadProgDesc.Size = new System.Drawing.Size(41, 20);
            this.labelCadProgDesc.TabIndex = 34;
            this.labelCadProgDesc.Text = "Desc";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(327, 182);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 138);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(-8, 406);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(860, 81);
            this.userControl1.TabIndex = 36;
            this.userControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userControl1_KeyDown);
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 482);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelCadProgDesc);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.labelCadProValor);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelCadProdNome);
            this.Controls.Add(this.textBox1);
            this.KeyPreview = true;
            this.Name = "CadastroProduto";
            this.Text = "CadastroProduto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroProduto_FormClosing);
            this.Load += new System.EventHandler(this.CadastroProduto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadastroProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox textBox5;
        private Label labelCadProdNome;
        private TextBox textBox1;
        private Label labelCadProValor;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label labelCadProgDesc;
        private PictureBox pictureBox1;
        private UserControl userControl1;
    }
}
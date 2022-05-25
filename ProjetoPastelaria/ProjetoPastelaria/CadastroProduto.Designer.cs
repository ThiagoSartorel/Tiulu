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
            this.textBoxIdProduto = new System.Windows.Forms.TextBox();
            this.labelCadProdNome = new System.Windows.Forms.Label();
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.labelCadProValor = new System.Windows.Forms.Label();
            this.textBoxDescProduto = new System.Windows.Forms.TextBox();
            this.labelCadProgDesc = new System.Windows.Forms.Label();
            this.pictureBoxImgProduto = new System.Windows.Forms.PictureBox();
            this.userControlProduto = new ProjetoPastelaria.UserControl();
            this.maskedTextBoxValorProduto = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgProduto)).BeginInit();
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
            // textBoxIdProduto
            // 
            this.textBoxIdProduto.Location = new System.Drawing.Point(12, 67);
            this.textBoxIdProduto.Name = "textBoxIdProduto";
            this.textBoxIdProduto.ReadOnly = true;
            this.textBoxIdProduto.Size = new System.Drawing.Size(75, 27);
            this.textBoxIdProduto.TabIndex = 1;
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
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Location = new System.Drawing.Point(114, 67);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(279, 27);
            this.textBoxNomeProduto.TabIndex = 2;
            // 
            // labelCadProValor
            // 
            this.labelCadProValor.AutoSize = true;
            this.labelCadProValor.Location = new System.Drawing.Point(399, 44);
            this.labelCadProValor.Name = "labelCadProValor";
            this.labelCadProValor.Size = new System.Drawing.Size(45, 20);
            this.labelCadProValor.TabIndex = 32;
            this.labelCadProValor.Text = "Value";
            // 
            // textBoxDescProduto
            // 
            this.textBoxDescProduto.Location = new System.Drawing.Point(12, 171);
            this.textBoxDescProduto.Multiline = true;
            this.textBoxDescProduto.Name = "textBoxDescProduto";
            this.textBoxDescProduto.Size = new System.Drawing.Size(296, 229);
            this.textBoxDescProduto.TabIndex = 4;
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
            // pictureBoxImgProduto
            // 
            this.pictureBoxImgProduto.Location = new System.Drawing.Point(327, 182);
            this.pictureBoxImgProduto.Name = "pictureBoxImgProduto";
            this.pictureBoxImgProduto.Size = new System.Drawing.Size(161, 138);
            this.pictureBoxImgProduto.TabIndex = 35;
            this.pictureBoxImgProduto.TabStop = false;
            // 
            // userControlProduto
            // 
            this.userControlProduto.Location = new System.Drawing.Point(-8, 406);
            this.userControlProduto.Name = "userControlProduto";
            this.userControlProduto.Size = new System.Drawing.Size(860, 81);
            this.userControlProduto.TabIndex = 36;
            // 
            // maskedTextBoxValorProduto
            // 
            this.maskedTextBoxValorProduto.Location = new System.Drawing.Point(399, 67);
            this.maskedTextBoxValorProduto.Mask = "$000,99";
            this.maskedTextBoxValorProduto.Name = "maskedTextBoxValorProduto";
            this.maskedTextBoxValorProduto.Size = new System.Drawing.Size(125, 27);
            this.maskedTextBoxValorProduto.TabIndex = 37;
            this.maskedTextBoxValorProduto.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // CadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 482);
            this.Controls.Add(this.maskedTextBoxValorProduto);
            this.Controls.Add(this.userControlProduto);
            this.Controls.Add(this.pictureBoxImgProduto);
            this.Controls.Add(this.labelCadProgDesc);
            this.Controls.Add(this.textBoxDescProduto);
            this.Controls.Add(this.labelCadProValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxIdProduto);
            this.Controls.Add(this.labelCadProdNome);
            this.Controls.Add(this.textBoxNomeProduto);
            this.KeyPreview = true;
            this.Name = "CadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastroProduto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CadastroProduto_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CadastroProduto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImgProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label4;
        private TextBox textBoxIdProduto;
        private Label labelCadProdNome;
        private TextBox textBoxNomeProduto;
        private Label labelCadProValor;
        private TextBox textBoxDescProduto;
        private Label labelCadProgDesc;
        private PictureBox pictureBoxImgProduto;
        private UserControl userControlProduto;
        private MaskedTextBox maskedTextBoxValorProduto;
    }
}
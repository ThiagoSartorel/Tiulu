namespace ProjetoPastelaria
{
    partial class Config
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
            this.labelConfigJuros = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelConfigMulta = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelConfigLinguagem = new System.Windows.Forms.Label();
            this.comboBoxLinguagem = new System.Windows.Forms.ComboBox();
            this.userControl1 = new ProjetoPastelaria.UserControl();
            this.SuspendLayout();
            // 
            // labelConfigJuros
            // 
            this.labelConfigJuros.AutoSize = true;
            this.labelConfigJuros.Location = new System.Drawing.Point(27, 34);
            this.labelConfigJuros.Name = "labelConfigJuros";
            this.labelConfigJuros.Size = new System.Drawing.Size(93, 20);
            this.labelConfigJuros.TabIndex = 36;
            this.labelConfigJuros.Text = "Percent juros";
            this.labelConfigJuros.Click += new System.EventHandler(this.labelConfigJuros_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(27, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(159, 27);
            this.textBox5.TabIndex = 35;
            // 
            // labelConfigMulta
            // 
            this.labelConfigMulta.AutoSize = true;
            this.labelConfigMulta.Location = new System.Drawing.Point(215, 34);
            this.labelConfigMulta.Name = "labelConfigMulta";
            this.labelConfigMulta.Size = new System.Drawing.Size(91, 20);
            this.labelConfigMulta.TabIndex = 34;
            this.labelConfigMulta.Text = "Multa por at";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 27);
            this.textBox1.TabIndex = 33;
            // 
            // labelConfigLinguagem
            // 
            this.labelConfigLinguagem.AutoSize = true;
            this.labelConfigLinguagem.Location = new System.Drawing.Point(27, 128);
            this.labelConfigLinguagem.Name = "labelConfigLinguagem";
            this.labelConfigLinguagem.Size = new System.Drawing.Size(37, 20);
            this.labelConfigLinguagem.TabIndex = 41;
            this.labelConfigLinguagem.Text = "Ling";
            this.labelConfigLinguagem.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxLinguagem
            // 
            this.comboBoxLinguagem.FormattingEnabled = true;
            this.comboBoxLinguagem.Items.AddRange(new object[] {
            "Portugues (PT-BR)",
            "Ingles(EN-US)",
            "Espanhol(ES-ES)"});
            this.comboBoxLinguagem.Location = new System.Drawing.Point(27, 151);
            this.comboBoxLinguagem.Name = "comboBoxLinguagem";
            this.comboBoxLinguagem.Size = new System.Drawing.Size(151, 28);
            this.comboBoxLinguagem.TabIndex = 40;
            this.comboBoxLinguagem.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(-2, 245);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(685, 65);
            this.userControl1.TabIndex = 42;
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 322);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.labelConfigLinguagem);
            this.Controls.Add(this.comboBoxLinguagem);
            this.Controls.Add(this.labelConfigJuros);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.labelConfigMulta);
            this.Controls.Add(this.textBox1);
            this.Name = "Config";
            this.Text = "Config";
            this.Load += new System.EventHandler(this.Config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelConfigJuros;
        private TextBox textBox5;
        private Label labelConfigMulta;
        private TextBox textBox1;
        private Label labelConfigLinguagem;
        private ComboBox comboBoxLinguagem;
        private UserControl userControl1;
    }
}
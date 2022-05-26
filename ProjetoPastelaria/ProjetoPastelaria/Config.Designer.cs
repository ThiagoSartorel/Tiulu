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
            this.textBoxJurosConfig = new System.Windows.Forms.TextBox();
            this.labelConfigMulta = new System.Windows.Forms.Label();
            this.textBoxMultaConfig = new System.Windows.Forms.TextBox();
            this.labelConfigLinguagem = new System.Windows.Forms.Label();
            this.comboBoxLinguagem = new System.Windows.Forms.ComboBox();
            this.userControl1 = new ProjetoPastelaria.UserControl();
            this.buttonConfigSalvar = new System.Windows.Forms.Button();
            this.checkBoxAlteraIdioma = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxProvider = new System.Windows.Forms.ComboBox();
            this.textBoxStringDeConexao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // 
            // textBoxJurosConfig
            // 
            this.textBoxJurosConfig.Location = new System.Drawing.Point(27, 57);
            this.textBoxJurosConfig.Name = "textBoxJurosConfig";
            this.textBoxJurosConfig.Size = new System.Drawing.Size(159, 27);
            this.textBoxJurosConfig.TabIndex = 1;
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
            // textBoxMultaConfig
            // 
            this.textBoxMultaConfig.Location = new System.Drawing.Point(215, 57);
            this.textBoxMultaConfig.Name = "textBoxMultaConfig";
            this.textBoxMultaConfig.Size = new System.Drawing.Size(279, 27);
            this.textBoxMultaConfig.TabIndex = 2;
            // 
            // labelConfigLinguagem
            // 
            this.labelConfigLinguagem.AutoSize = true;
            this.labelConfigLinguagem.Location = new System.Drawing.Point(27, 99);
            this.labelConfigLinguagem.Name = "labelConfigLinguagem";
            this.labelConfigLinguagem.Size = new System.Drawing.Size(37, 20);
            this.labelConfigLinguagem.TabIndex = 41;
            this.labelConfigLinguagem.Text = "Ling";
            // 
            // comboBoxLinguagem
            // 
            this.comboBoxLinguagem.FormattingEnabled = true;
            this.comboBoxLinguagem.Items.AddRange(new object[] {
            "pt-BR",
            "en-US",
            "es"});
            this.comboBoxLinguagem.Location = new System.Drawing.Point(27, 122);
            this.comboBoxLinguagem.Name = "comboBoxLinguagem";
            this.comboBoxLinguagem.Size = new System.Drawing.Size(151, 28);
            this.comboBoxLinguagem.TabIndex = 3;
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(-2, 300);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(221, 65);
            this.userControl1.TabIndex = 42;
            // 
            // buttonConfigSalvar
            // 
            this.buttonConfigSalvar.Location = new System.Drawing.Point(286, 190);
            this.buttonConfigSalvar.Name = "buttonConfigSalvar";
            this.buttonConfigSalvar.Size = new System.Drawing.Size(183, 29);
            this.buttonConfigSalvar.TabIndex = 43;
            this.buttonConfigSalvar.Text = "Alterar Idioma";
            this.buttonConfigSalvar.UseVisualStyleBackColor = true;
            this.buttonConfigSalvar.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // checkBoxAlteraIdioma
            // 
            this.checkBoxAlteraIdioma.AutoSize = true;
            this.checkBoxAlteraIdioma.Location = new System.Drawing.Point(224, 128);
            this.checkBoxAlteraIdioma.Name = "checkBoxAlteraIdioma";
            this.checkBoxAlteraIdioma.Size = new System.Drawing.Size(156, 24);
            this.checkBoxAlteraIdioma.TabIndex = 4;
            this.checkBoxAlteraIdioma.Text = "Alterar ja o idioma";
            this.checkBoxAlteraIdioma.UseVisualStyleBackColor = true;
            // 
            // comboBoxProvider
            // 
            this.comboBoxProvider.FormattingEnabled = true;
            this.comboBoxProvider.Location = new System.Drawing.Point(27, 191);
            this.comboBoxProvider.Name = "comboBoxProvider";
            this.comboBoxProvider.Size = new System.Drawing.Size(204, 28);
            this.comboBoxProvider.TabIndex = 44;
            // 
            // textBoxStringDeConexao
            // 
            this.textBoxStringDeConexao.Location = new System.Drawing.Point(27, 257);
            this.textBoxStringDeConexao.Multiline = true;
            this.textBoxStringDeConexao.Name = "textBoxStringDeConexao";
            this.textBoxStringDeConexao.Size = new System.Drawing.Size(467, 51);
            this.textBoxStringDeConexao.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 46;
            this.label1.Text = "Banco de dados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Parametros";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(290, 29);
            this.button1.TabIndex = 48;
            this.button1.Text = "Salvar configuração banco de dados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 29);
            this.button2.TabIndex = 49;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 363);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxStringDeConexao);
            this.Controls.Add(this.comboBoxProvider);
            this.Controls.Add(this.checkBoxAlteraIdioma);
            this.Controls.Add(this.buttonConfigSalvar);
            this.Controls.Add(this.userControl1);
            this.Controls.Add(this.labelConfigLinguagem);
            this.Controls.Add(this.comboBoxLinguagem);
            this.Controls.Add(this.labelConfigJuros);
            this.Controls.Add(this.textBoxJurosConfig);
            this.Controls.Add(this.labelConfigMulta);
            this.Controls.Add(this.textBoxMultaConfig);
            this.KeyPreview = true;
            this.Name = "Config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Config_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Config_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label labelConfigJuros;
        private TextBox textBoxJurosConfig;
        private Label labelConfigMulta;
        private TextBox textBoxMultaConfig;
        private Label labelConfigLinguagem;
        private ComboBox comboBoxLinguagem;
        private UserControl userControl1;
        private Button buttonConfigSalvar;
        private CheckBox checkBoxAlteraIdioma;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ComboBox comboBoxProvider;
        private TextBox textBoxStringDeConexao;
        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
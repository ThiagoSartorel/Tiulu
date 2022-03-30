namespace Projeto1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        ///  Thiago Sartorel
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// Thiago Sartorel
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotaoCor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.botaoTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoCor
            // 
            this.BotaoCor.Location = new System.Drawing.Point(12, 12);
            this.BotaoCor.Name = "BotaoCor";
            this.BotaoCor.Size = new System.Drawing.Size(776, 176);
            this.BotaoCor.TabIndex = 0;
            this.BotaoCor.Text = "Cor";
            this.BotaoCor.UseVisualStyleBackColor = true;
            this.BotaoCor.Click += new System.EventHandler(this.BotaoCor_Click);
            // 
            // botaoTexto
            // 
            this.botaoTexto.Location = new System.Drawing.Point(12, 239);
            this.botaoTexto.Name = "botaoTexto";
            this.botaoTexto.Size = new System.Drawing.Size(776, 176);
            this.botaoTexto.TabIndex = 1;
            this.botaoTexto.Text = "Texto";
            this.botaoTexto.UseVisualStyleBackColor = true;
            this.botaoTexto.Click += new System.EventHandler(this.botaoTexto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoTexto);
            this.Controls.Add(this.BotaoCor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button BotaoCor;
        private ColorDialog colorDialog1;
        private Button botaoTexto;
    }
}

namespace ProjetoPastelaria
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            this.richTextBoxSobreTexto = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabelSobreLink = new System.Windows.Forms.LinkLabel();
            this.labelSobreNome = new System.Windows.Forms.Label();
            this.buttonSobreVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxSobreTexto
            // 
            this.richTextBoxSobreTexto.Location = new System.Drawing.Point(214, 12);
            this.richTextBoxSobreTexto.Name = "richTextBoxSobreTexto";
            this.richTextBoxSobreTexto.Size = new System.Drawing.Size(453, 407);
            this.richTextBoxSobreTexto.TabIndex = 0;
            this.richTextBoxSobreTexto.Text = resources.GetString("richTextBoxSobreTexto.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 180);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabelSobreLink
            // 
            this.linkLabelSobreLink.AutoSize = true;
            this.linkLabelSobreLink.Location = new System.Drawing.Point(60, 335);
            this.linkLabelSobreLink.Name = "linkLabelSobreLink";
            this.linkLabelSobreLink.Size = new System.Drawing.Size(72, 20);
            this.linkLabelSobreLink.TabIndex = 2;
            this.linkLabelSobreLink.TabStop = true;
            this.linkLabelSobreLink.Text = "Blablalba";
            // 
            // labelSobreNome
            // 
            this.labelSobreNome.AutoSize = true;
            this.labelSobreNome.Location = new System.Drawing.Point(60, 195);
            this.labelSobreNome.Name = "labelSobreNome";
            this.labelSobreNome.Size = new System.Drawing.Size(89, 20);
            this.labelSobreNome.TabIndex = 3;
            this.labelSobreNome.Text = "abcBolinhas";
            // 
            // buttonSobreVoltar
            // 
            this.buttonSobreVoltar.Location = new System.Drawing.Point(55, 375);
            this.buttonSobreVoltar.Name = "buttonSobreVoltar";
            this.buttonSobreVoltar.Size = new System.Drawing.Size(94, 29);
            this.buttonSobreVoltar.TabIndex = 4;
            this.buttonSobreVoltar.Text = "Voltar";
            this.buttonSobreVoltar.UseVisualStyleBackColor = true;
            this.buttonSobreVoltar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 431);
            this.Controls.Add(this.buttonSobreVoltar);
            this.Controls.Add(this.labelSobreNome);
            this.Controls.Add(this.linkLabelSobreLink);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBoxSobreTexto);
            this.KeyPreview = true;
            this.Name = "Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Sobre_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBoxSobreTexto;
        private PictureBox pictureBox1;
        private LinkLabel linkLabelSobreLink;
        private Label labelSobreNome;
        private Button buttonSobreVoltar;
    }
}
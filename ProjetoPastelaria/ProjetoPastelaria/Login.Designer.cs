namespace ProjetoPastelaria
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.textBoxLoginUser = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassord = new System.Windows.Forms.TextBox();
            this.labelLoginUser = new System.Windows.Forms.Label();
            this.labelLoginSenha = new System.Windows.Forms.Label();
            this.buttonLoginEntrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // textBoxLoginUser
            // 
            this.textBoxLoginUser.Location = new System.Drawing.Point(31, 68);
            this.textBoxLoginUser.Name = "textBoxLoginUser";
            this.textBoxLoginUser.Size = new System.Drawing.Size(128, 27);
            this.textBoxLoginUser.TabIndex = 0;
            this.textBoxLoginUser.Enter += new System.EventHandler(this.TextBox1_Enter);
            this.textBoxLoginUser.Leave += new System.EventHandler(this.TextBox1_Leave);
            // 
            // textBoxLoginPassord
            // 
            this.textBoxLoginPassord.Location = new System.Drawing.Point(31, 127);
            this.textBoxLoginPassord.Name = "textBoxLoginPassord";
            this.textBoxLoginPassord.PasswordChar = '*';
            this.textBoxLoginPassord.Size = new System.Drawing.Size(128, 27);
            this.textBoxLoginPassord.TabIndex = 1;
            this.textBoxLoginPassord.Enter += new System.EventHandler(this.TextBox2_Enter);
            this.textBoxLoginPassord.Leave += new System.EventHandler(this.TextBox2_Leave);
            // 
            // labelLoginUser
            // 
            this.labelLoginUser.AutoSize = true;
            this.labelLoginUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLoginUser.Location = new System.Drawing.Point(31, 42);
            this.labelLoginUser.Name = "labelLoginUser";
            this.labelLoginUser.Size = new System.Drawing.Size(33, 20);
            this.labelLoginUser.TabIndex = 2;
            this.labelLoginUser.Text = "Usu";
            // 
            // labelLoginSenha
            // 
            this.labelLoginSenha.AutoSize = true;
            this.labelLoginSenha.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLoginSenha.Location = new System.Drawing.Point(31, 101);
            this.labelLoginSenha.Name = "labelLoginSenha";
            this.labelLoginSenha.Size = new System.Drawing.Size(25, 20);
            this.labelLoginSenha.TabIndex = 3;
            this.labelLoginSenha.Text = "Se";
            // 
            // buttonLoginEntrar
            // 
            this.buttonLoginEntrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLoginEntrar.Location = new System.Drawing.Point(47, 160);
            this.buttonLoginEntrar.Name = "buttonLoginEntrar";
            this.buttonLoginEntrar.Size = new System.Drawing.Size(94, 29);
            this.buttonLoginEntrar.TabIndex = 4;
            this.buttonLoginEntrar.Text = "Ent";
            this.buttonLoginEntrar.UseVisualStyleBackColor = false;
            this.buttonLoginEntrar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Location = new System.Drawing.Point(12, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 182);
            this.panel1.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(200, 227);
            this.Controls.Add(this.buttonLoginEntrar);
            this.Controls.Add(this.labelLoginSenha);
            this.Controls.Add(this.labelLoginUser);
            this.Controls.Add(this.textBoxLoginPassord);
            this.Controls.Add(this.textBoxLoginUser);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxLoginUser;
        private TextBox textBoxLoginPassord;
        private Label labelLoginUser;
        private Label labelLoginSenha;
        private Button buttonLoginEntrar;
        private Panel panel1;
    }
}
namespace ProjetoPastelaria
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.buttonMenuCadProd = new System.Windows.Forms.Button();
            this.buttonMenuCadClient = new System.Windows.Forms.Button();
            this.buttonMenuCadFun = new System.Windows.Forms.Button();
            this.buttonMenuConfig = new System.Windows.Forms.Button();
            this.buttonMenuSobre = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.notifyIconSystemTray = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonMenuCadProd
            // 
            this.buttonMenuCadProd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMenuCadProd.Location = new System.Drawing.Point(17, 227);
            this.buttonMenuCadProd.Name = "buttonMenuCadProd";
            this.buttonMenuCadProd.Size = new System.Drawing.Size(170, 29);
            this.buttonMenuCadProd.TabIndex = 0;
            this.buttonMenuCadProd.Text = "CP";
            this.buttonMenuCadProd.UseVisualStyleBackColor = false;
            this.buttonMenuCadProd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMenuCadClient
            // 
            this.buttonMenuCadClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMenuCadClient.Location = new System.Drawing.Point(17, 284);
            this.buttonMenuCadClient.Name = "buttonMenuCadClient";
            this.buttonMenuCadClient.Size = new System.Drawing.Size(170, 29);
            this.buttonMenuCadClient.TabIndex = 1;
            this.buttonMenuCadClient.Text = "CC";
            this.buttonMenuCadClient.UseVisualStyleBackColor = false;
            this.buttonMenuCadClient.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonMenuCadFun
            // 
            this.buttonMenuCadFun.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMenuCadFun.Location = new System.Drawing.Point(17, 341);
            this.buttonMenuCadFun.Name = "buttonMenuCadFun";
            this.buttonMenuCadFun.Size = new System.Drawing.Size(170, 29);
            this.buttonMenuCadFun.TabIndex = 2;
            this.buttonMenuCadFun.Text = "CF";
            this.buttonMenuCadFun.UseVisualStyleBackColor = false;
            this.buttonMenuCadFun.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMenuConfig
            // 
            this.buttonMenuConfig.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMenuConfig.Location = new System.Drawing.Point(17, 398);
            this.buttonMenuConfig.Name = "buttonMenuConfig";
            this.buttonMenuConfig.Size = new System.Drawing.Size(170, 29);
            this.buttonMenuConfig.TabIndex = 3;
            this.buttonMenuConfig.Text = "Config";
            this.buttonMenuConfig.UseVisualStyleBackColor = false;
            this.buttonMenuConfig.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonMenuSobre
            // 
            this.buttonMenuSobre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMenuSobre.Location = new System.Drawing.Point(17, 455);
            this.buttonMenuSobre.Name = "buttonMenuSobre";
            this.buttonMenuSobre.Size = new System.Drawing.Size(170, 29);
            this.buttonMenuSobre.TabIndex = 4;
            this.buttonMenuSobre.Text = "Sb";
            this.buttonMenuSobre.UseVisualStyleBackColor = false;
            this.buttonMenuSobre.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(215, 512);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(221, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // notifyIconSystemTray
            // 
            this.notifyIconSystemTray.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconSystemTray.Icon")));
            this.notifyIconSystemTray.Text = "notifyIcon1";
            this.notifyIconSystemTray.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconSystemTray_MouseDoubleClick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(667, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonMenuSobre);
            this.Controls.Add(this.buttonMenuConfig);
            this.Controls.Add(this.buttonMenuCadFun);
            this.Controls.Add(this.buttonMenuCadClient);
            this.Controls.Add(this.buttonMenuCadProd);
            this.Controls.Add(this.splitter1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Resize += new System.EventHandler(this.Menu_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonMenuCadProd;
        private Button buttonMenuCadClient;
        private Button buttonMenuCadFun;
        private Button buttonMenuConfig;
        private Button buttonMenuSobre;
        private PictureBox pictureBox1;
        private Splitter splitter1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private NotifyIcon notifyIconSystemTray;
    }
}
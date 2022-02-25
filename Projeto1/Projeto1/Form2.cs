﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static String texturizando = "";

        private void Form2_Load(object sender, EventArgs e)
        {
            BackColor = Form1.colorinodo;
        }


        private void botaoTexto_Click(object sender, EventArgs e)
        {
            texturizando = textBox1.Text;
            this.Close();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(texturizando == "")
            {
                e.Cancel = true;
            }
        }
    }
}

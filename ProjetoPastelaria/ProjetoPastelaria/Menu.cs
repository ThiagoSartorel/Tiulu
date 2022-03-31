﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPastelaria
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            buttonMenuCadProd.Text = Properties.Resources.ResourceManager.GetString("ButtonMenuCadProd");
            buttonMenuCadClient.Text = Properties.Resources.ResourceManager.GetString("ButtonMenuCadClient");
            buttonMenuCadFun.Text = Properties.Resources.ResourceManager.GetString("ButtonMenuCadFun");
            buttonMenuConfig.Text = Properties.Resources.ResourceManager.GetString("ButtonMenuConfig");
            buttonMenuSobre.Text = Properties.Resources.ResourceManager.GetString("ButtonMenuSobre");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroProduto cp = new CadastroProduto();
            cp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadastroCliente cc = new CadastroCliente();
            cc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cf = new CadastroFuncionario();
            cf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

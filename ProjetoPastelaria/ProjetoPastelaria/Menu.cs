using System;
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

            buttonMenuCadClient.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            buttonMenuCadClient.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonMenuCadProd.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            buttonMenuCadProd.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonMenuCadFun.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            buttonMenuCadFun.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonMenuConfig.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            buttonMenuConfig.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            buttonMenuSobre.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            buttonMenuSobre.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = new AlertaSair();
                result.Show();
                e.Cancel = true;
            }
        }

        private void Menu_Resize(object sender, EventArgs e)
        {

            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIconSystemTray.Visible = true;
            }
            else if (FormWindowState.Normal == this.WindowState)
            {
                notifyIconSystemTray.Visible = false;
            }
            
        }

        private void notifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIconSystemTray.Visible = false;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cp = new CadastroProduto();
            cp.Show();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cc = new CadastroCliente();
            cc.Show();
        }

        private void cadastroFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cf = new CadastroFuncionario();
            cf.Show();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Config config = new Config();
            config.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void contextMenuStripPrincipal_Opening(object sender, CancelEventArgs e)
        {

        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;

        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

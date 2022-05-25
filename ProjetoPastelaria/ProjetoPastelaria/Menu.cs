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

        private void Button1_Click(object sender, EventArgs e)
        {
            CadastroProduto cp = new();
            cp.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CadastroCliente cc = new();
            cc.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cf = new();
            cf.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Config config = new();
            config.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Sobre sobre = new ();
            sobre.Show();
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

        
        private void NotifyIconSystemTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Maximized;
            notifyIconSystemTray.Visible = false;
        }

        private void CadastroProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProduto cp = new();
            cp.Show();
        }

        private void CadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroCliente cc = new();
            cc.Show();
        }

        private void CadastroFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFuncionario cf = new();
            cf.Show();
        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AbriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIconSystemTray.Visible = false;

        }

        private void SobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sobre sobre = new();
            sobre.Show();
        }

        private void buttonListarUsuarios_Click(object sender, EventArgs e)
        {
            ListarUsuarios listar = new();
            listar.Show();
        }
    }
}

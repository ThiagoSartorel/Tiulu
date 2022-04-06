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
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
            labelCadFunID.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunID");
            labelCadFunCPF.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunCPF");
            labelCadFunMatricula.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunMatricula");
            labelCadFunSenha.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunSenha");
            labelCadFunRsenha.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunRSenha");
            labelCadFunNome.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunNome");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelCadFunNome_Click(object sender, EventArgs e)
        {

        }
    }
}

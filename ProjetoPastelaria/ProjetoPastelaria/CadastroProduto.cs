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
    public partial class CadastroProduto : Form
    {
        public CadastroProduto()
        {
            InitializeComponent();

            UserControl userControl = new();
            userControl.Dock = DockStyle.Bottom;

            Size = new Size(Size.Width, Size.Height + userControl.Size.Height);

            labelCadProdNome.Text = Properties.Resources.ResourceManager.GetString("LabelCadProdNome");
            labelCadProgDesc.Text = Properties.Resources.ResourceManager.GetString("LabelCadProdDesc");
            labelCadProValor.Text = Properties.Resources.ResourceManager.GetString("LabelCadProdValor");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroProduto_Load(object sender, EventArgs e)
        {
        }
    }
}

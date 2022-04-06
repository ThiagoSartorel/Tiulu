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
    public partial class Sobre : Form
    {
        public Sobre()
        {
            InitializeComponent();
            labelSobreNome.Text = Properties.Resources.ResourceManager.GetString("LabelSobreNome");
            linkLabelSobreLink.Text = Properties.Resources.ResourceManager.GetString("LinkLabelSobreLink");
            buttonSobreVoltar.Text = Properties.Resources.ResourceManager.GetString("ButtonSobreVoltar");
            richTextBoxSobreTexto.Text = Properties.Resources.ResourceManager.GetString("LabelSobreTexto");
    }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Sobre_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Config : Form
    {
        public Config()
        {
            InitializeComponent();

            labelConfigJuros.Text = Properties.Resources.ResourceManager.GetString("LabelConfigJuros");
            labelConfigMulta.Text = Properties.Resources.ResourceManager.GetString("LabelConfigMulta");
            labelConfigLinguagem.Text = Properties.Resources.ResourceManager.GetString("LabelConfigLinguagem");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Config_Load(object sender, EventArgs e)
        {

        }

        private void labelConfigJuros_Click(object sender, EventArgs e)
        {

        }
    }
}

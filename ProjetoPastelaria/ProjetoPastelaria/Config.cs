using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove("IdiomaRegiao");
            config.AppSettings.Settings.Add("IdiomaRegiao", comboBoxLinguagem.Text);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");

            Close();

            _ = MessageBox.Show("Idioma alterada! reinicie a aplicação");

            if (checkBoxAlteraIdioma.Checked)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}

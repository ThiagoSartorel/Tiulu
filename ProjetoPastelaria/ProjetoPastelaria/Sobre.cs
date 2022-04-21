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

        private void Sobre_KeyDown(object sender, KeyEventArgs e)
        {
            //obtém o form onde o componente gerou o evento
            Control x = (Control)sender;
            Form form = x.FindForm();
            //verifica se foi pressionado ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //Obtém ou define um valor que indica se o evento de chave deve ser passado para o controle
                //subjacente.
                //true caso o evento chave não deva ser enviado ao controle; caso contrário, false
                //com isso evitamos o som de erro toda vez que pressionamos enter em algum campo
                e.SuppressKeyPress = true;
                //SendKeys.Send("{TAB}");
                form.SelectNextControl(form.ActiveControl, !e.Shift, true, true, true);
            }
            //verifica se foi pressionado ESC
            else if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show(" Deseja mesmo sair? ", "Mensage do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    form.Close();
                }
            }
        }

        private void Sobre_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}

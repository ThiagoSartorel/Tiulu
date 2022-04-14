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
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();

            labelCadCliCPF.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliCPF");
            labelCadCliDias.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliDias");
            labelCadCliFiado.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliFiado");
            labelCadCliNome.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliNome");
            labelCadCliSenha.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliSenha");
            labelCadCliRSenha.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliRSenha");
            labelCadCliTelefone.Text = Properties.Resources.ResourceManager.GetString("LabelCadCliTelefone");
        }

        public void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Form f = new Form();
            f.Close();

        }

        private void userControl1_Load(object sender, EventArgs e)
        {

        }

        private void userControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void userControl1_Load_2(object sender, EventArgs e)
        {

        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void labelCadCliCPF_Click(object sender, EventArgs e)
        {

        }

        private void CadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            //obtém o form onde o componente gerou o evento
            Control x = (Control)sender;
            Form form = x.FindForm();
            //verifica se foi pressionado ENTER
            if (e.KeyCode == Keys.Enter)
            {
                //Obtém ou define um valor que indica se o evento de chave deve ser passado para o controle
                // subjacente.
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
    }
}

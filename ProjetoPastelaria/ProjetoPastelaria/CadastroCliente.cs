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
        ///private int buttonVoltar_Click;

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

            textBoxIdCliente.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxIdCliente.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxNomeCliente.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxNomeCliente.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxSenhaCliente.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxSenhaCliente.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxRsenhaCliente.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxRsenhaCliente.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            comboBoxFiado.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            comboBoxFiado.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            numericUpDownDia.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            numericUpDownDia.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);


            userControlCliente.buttonSalvar.Click += ButtonSalvar_Click;
            userControlCliente.buttonVoltar.Click += ButtonVoltar_Click;

        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            this.Hide();
        }

        private void ButtonVoltar_Click(object? sender, EventArgs e)
        {
            this.Close();
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
                //Corrigir
            }
        }

        private void CadastroCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Salvar alteração?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    //
                }
                else
                {
                    //
                }
            }
        }

    }
}

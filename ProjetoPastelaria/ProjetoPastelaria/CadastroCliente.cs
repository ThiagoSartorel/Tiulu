using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoPastelariaDoZe_2022.DAO;
using System.Configuration;

namespace ProjetoPastelaria
{
    public partial class CadastroCliente : Form
    {
        ///private int buttonVoltar_Click;
        private readonly ClienteDAO dao;

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
            numericUpDownDia.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            numericUpDownDia.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);


            userControlCliente.buttonSalvar.Click += ButtonSalvar_Click;
            userControlCliente.buttonVoltar.Click += ButtonVoltar_Click;

            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model

            dao = new ClienteDAO(provider, strConnection); // No evento do botão salvar, vamos chamar o método da nossa


            AtualizaTela();
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            {
                //Instância e Preenche o objeto com os dados da view
                var cliente = new Cliente
                {
                    IdCliente = 0,
                    Nome = textBoxNomeCliente.Text,
                    Cpf = maskedTextBoxCpf.Text,
                    Telefone = maskedTextBoxTelefoneCliente.Text,
                    Dia_fiado = numericUpDownDia.Text,
                    Compra_fiado = (checkBoxFiado.Checked) ? true : false,
                    Senha = ClassFuncoes.Sha256Hash(textBoxSenhaCliente.Text)
                };
                try
                {
                    // chama o método para inserir da camada model
                    dao.InserirDbProvider(cliente);
                    MessageBox.Show("Dados inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        public void LimpaTela()
        {
            textBoxIdCliente.Text = "";
            textBoxNomeCliente.Text = "";
            textBoxRsenhaCliente.Text = "";
            textBoxSenhaCliente.Text = "";
            numericUpDownDia.Text = "";
            checkBoxFiado.Checked = false;
            maskedTextBoxCpf.Text = "";
            maskedTextBoxTelefoneCliente.Text = "";
        }
        public void AtualizaTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                IdCliente = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(cliente);
                // seta o datasouce do dataGridView com os dados retornados
                dataGridViewDados.Columns.Clear();
                dataGridViewDados.AutoGenerateColumns = true;
                dataGridViewDados.DataSource = linhas;
                dataGridViewDados.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                IdCliente = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(cliente);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdCliente.Text = row[0].ToString();
                    textBoxNomeCliente.Text = row[1].ToString();
                    maskedTextBoxCpf.Text = row[2].ToString();
                    maskedTextBoxTelefoneCliente.Text = row[3].ToString();
                    if (row[4].ToString() == "1")
                    {
                        checkBoxFiado.Checked = true;
                    }

                    numericUpDownDia.Text = row[5].ToString();



                }
                textBoxNomeCliente.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                IdCliente = int.Parse(textBoxIdCliente.Text),
                Nome = textBoxNomeCliente.Text,
                Cpf = maskedTextBoxCpf.Text,
                Telefone = maskedTextBoxTelefoneCliente.Text,
                Senha = ClassFuncoes.Sha256Hash(textBoxSenhaCliente.Text),
                Dia_fiado = numericUpDownDia.Text,
                Compra_fiado = checkBoxFiado.Checked,
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.EditarDbProvider(cliente);
                AtualizaTela();
                LimpaTela();
                MessageBox.Show("Dados editados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                IdCliente = int.Parse(textBoxIdCliente.Text),
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.ExcluirDbProvider(cliente);
                AtualizaTela();
                LimpaTela();
                MessageBox.Show("Dados excluidos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewDados.SelectedCells.Count > 0)
            {
                //pega a primeira coluna, que esta com o ID, da linha selecionada
                DataGridViewRow selectedRow = dataGridViewDados.Rows[dataGridViewDados.SelectedCells[0].RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                AtualizaTelaEditar(id);
            }
        }
    }
}

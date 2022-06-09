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
    public partial class CadastroFuncionario : Form
    { 
    private readonly FuncionarioDAO dao;

    public CadastroFuncionario()
        {
            InitializeComponent();
            
            labelCadFunID.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunID");
            labelCadFunCPF.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunCPF");
            labelCadFunMatricula.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunMatricula");
            labelCadFunSenha.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunSenha");
            labelCadFunRsenha.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunRSenha");
            labelCadFunNome.Text = Properties.Resources.ResourceManager.GetString("LabelCadFunNome");

            textBoxIdFuncionario.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxIdFuncionario.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            maskedTextBoxCpfFuncionario.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            maskedTextBoxCpfFuncionario.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxMatriculaFuncionario.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxMatriculaFuncionario.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxNomeFuncionario.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxNomeFuncionario.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            maskedTextBoxTelefoneFuncionario.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            maskedTextBoxTelefoneFuncionario.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxSenhaFuncionario.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxSenhaFuncionario.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxRsenhaFuncionario.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxRsenhaFuncionario.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            userControlFuncionario.buttonVoltar.Click += ButtonVoltar_Click;
            userControlFuncionario.buttonSalvar.Click += ButtonSalvar_Click;
            // pega os dados do banco de dados
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model

            dao = new FuncionarioDAO(provider, strConnection); // No evento do botão salvar, vamos chamar o método da nossa
            AtualizaTela();
}

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
                Nome = textBoxNomeFuncionario.Text,
                Cpf = maskedTextBoxCpfFuncionario.Text,
                Telefone = maskedTextBoxTelefoneFuncionario.Text,
                Senha = ClassFuncoes.Sha256Hash(textBoxSenhaFuncionario.Text),
                Matricula = textBoxMatriculaFuncionario.Text,
                Grupo = (radioButtonCadFunAdm.Checked) ? 1 : 2,
            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(funcionario);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonVoltar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CadastroFuncionario_KeyDown(object sender, KeyEventArgs e)
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

        public void LimpraTela()
        {
            textBoxIdFuncionario.Text = "";
            textBoxMatriculaFuncionario.Text = "";
            textBoxNomeFuncionario.Text = "";
            textBoxRsenhaFuncionario.Text = "";
            textBoxSenhaFuncionario.Text = "";
            maskedTextBoxCpfFuncionario.Text = "";
            maskedTextBoxTelefoneFuncionario.Text = "";
            radioButtonCadFunAdm.Checked = false;
            radioButtonCadFunBalcao.Checked = false;
        }
        public void AtualizaTela()
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(funcionario);
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
        private void CadastroFuncionario_FormClosing(object sender, FormClosingEventArgs e)
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

        public void AtualizaTelaEditar(int id)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = id,
            };
            try
            {
                // chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao.SelectDbProvider(funcionario);
                // seta os dados na tela
                foreach (DataRow row in linhas.Rows)
                {
                    textBoxIdFuncionario.Text = row[0].ToString();
                    textBoxNomeFuncionario.Text = row[1].ToString();
                    maskedTextBoxCpfFuncionario.Text = row[2].ToString();
                    maskedTextBoxTelefoneFuncionario.Text = row[3].ToString();
                    textBoxMatriculaFuncionario.Text = row[5].ToString();
                    if (row[4].ToString() == "1")
                    {
                        radioButtonCadFunAdm.Checked = true;
                    }
                    else
                    {
                        radioButtonCadFunBalcao.Checked = true;
                    }

                      

                }
                textBoxNomeFuncionario.Focus();
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

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = int.Parse(textBoxIdFuncionario.Text),
                Nome = textBoxNomeFuncionario.Text,
                Cpf = maskedTextBoxCpfFuncionario.Text,
                Telefone = maskedTextBoxTelefoneFuncionario.Text,
                Senha = ClassFuncoes.Sha256Hash(textBoxSenhaFuncionario.Text),
                Matricula = textBoxMatriculaFuncionario.Text,
                Grupo = (radioButtonCadFunAdm.Checked) ? 1 : 2,
        };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.EditarDbProvider(funcionario);
                AtualizaTela();
                LimpraTela();
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
            var funcionario = new Funcionario
            {
                IdFuncionario = int.Parse(textBoxIdFuncionario.Text),
            };
            try
            {
                // chama o método para inserir da nossa camada model
                dao.ExcluirDbProvider(funcionario);
                AtualizaTela();
                LimpraTela();
                MessageBox.Show("Dados excluidos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

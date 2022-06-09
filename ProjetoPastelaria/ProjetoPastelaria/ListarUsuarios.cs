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

    public partial class ListarUsuarios : Form
    {
        private readonly FuncionarioDAO dao_fun;

        private readonly ClienteDAO dao_Usuario;

        private readonly ProdutoDAO dao_Produto;
        public ListarUsuarios()
        {
            InitializeComponent();
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            dao_fun = new FuncionarioDAO(provider, strConnection); // No evento do botão salvar, vamos chamar o método da nossa
            dao_Usuario = new ClienteDAO(provider, strConnection);
            dao_Produto = new ProdutoDAO(provider, strConnection);
        }

        private void ButtonListaFuncionario_Click(object sender, EventArgs e)
        {

            //Instância e Preenche o objeto com os dados da view
            var funcionario = new Funcionario
            {
                IdFuncionario = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao_fun.SelectDbProvider(funcionario);
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

        private void ButtonListaCliente_Click(object sender, EventArgs e)
        {

            //Instância e Preenche o objeto com os dados da view
            var cliente = new Cliente
            {
                IdCliente = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao_Usuario.SelectDbProvider(cliente);
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

        private void ButtonListaUsuariosSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonListaProdutos_Click(object sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = 0,
            };
            try
            {
                //chama o método para buscar todos os dados da nossa camada model
                DataTable linhas = dao_Produto.SelectDbProvider(produto);
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

        private void dataGridViewDados_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridViewDados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

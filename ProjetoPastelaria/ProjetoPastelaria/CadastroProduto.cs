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
    public partial class CadastroProduto : Form
    {
        private readonly ProdutoDAO dao;
        public CadastroProduto()
        {
            InitializeComponent();

            UserControl userControl = new();
            userControl.Dock = DockStyle.Bottom;

            Size = new Size(Size.Width, Size.Height + userControl.Size.Height);

            labelCadProdNome.Text = Properties.Resources.ResourceManager.GetString("LabelCadProdNome");
            labelCadProgDesc.Text = Properties.Resources.ResourceManager.GetString("LabelCadProdDesc");
            labelCadProValor.Text = Properties.Resources.ResourceManager.GetString("LabelCadProdValor");
            textBoxNomeProduto.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxNomeProduto.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxDescriacaoProduto.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxDescriacaoProduto.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);
            textBoxIdProduto.Leave += new EventHandler(ClassFuncoes.CampoEventoLeave!);
            textBoxIdProduto.Enter += new EventHandler(ClassFuncoes.CampoEventoEnter!);

            userControlProduto.buttonSalvar.Click += ButtonSalvar_Click;
            userControlProduto.buttonVoltar.Click += ButtonVoltar_Click;
            string provider = ConfigurationManager.ConnectionStrings["BD"].ProviderName;
            string strConnection = ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
            // cria a instancia da classe da model

            dao = new ProdutoDAO(provider, strConnection); // No evento do botão salvar, vamos chamar o método da nossa
        }

        private void ButtonVoltar_Click(object? sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSalvar_Click(object? sender, EventArgs e)
        {
            //Instância e Preenche o objeto com os dados da view
            var produto = new Produto
            {
                IdProduto = 0,
                Nome = textBoxNomeProduto.Text,
                ValorUnitario = double.Parse(maskedTextBoxValor.Text),
                Descricao = textBoxDescriacaoProduto.Text,
                Foto = ClassFuncoes.ConverteImagemParaByteArray(pictureBoxImagem.Image),
            };
            try
            {
                // chama o método para inserir da camada model
                dao.InserirDbProvider(produto);
                MessageBox.Show("Dados inseridos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void CadastroProduto_KeyDown(object sender, KeyEventArgs e)
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

        private void CadastroProduto_FormClosing(object sender, FormClosingEventArgs e)
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            openFileDialogImagem.Title = "Imagem do produto";
            openFileDialogImagem.Filter = "Images (*.JPEG; *.BMP; *.JPG; *.GIF; *.PNG; *.)| *.JPEG; *.BMP; *.JPG; *.GIF; *.PNG; *.icon; *.JFIF";
            if (openFileDialogImagem.ShowDialog() == DialogResult.OK)
            {
                //pega a imagem escolhida e adiciona na tela
                pictureBoxImagem.Image = Image.FromFile(openFileDialogImagem.FileName);
                //redimensiona a imagem
                pictureBoxImagem.Image = (Image)(new Bitmap(pictureBoxImagem.Image, new Size(130, 98)));
                //ajusta a visualização no tamanho do pictureBoxImagem na tela
                pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }
    }
}
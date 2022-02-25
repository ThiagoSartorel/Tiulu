namespace Projeto1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static Color colorinodo;
        public void BotaoCor_Click(object sender, EventArgs e)
        {
                    
            colorDialog1 = new ColorDialog();
            colorDialog1.ShowDialog();
            colorinodo = colorDialog1.Color;
            BotaoCor.BackColor = colorinodo;

        }

        private void botaoTexto_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.ShowDialog();
            botaoTexto.Text = Form2.texturizando;
        }
    }
}
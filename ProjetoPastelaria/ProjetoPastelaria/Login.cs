namespace ProjetoPastelaria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            labelLoginUser.Text = Properties.Resources.ResourceManager.GetString("LabelLoginUser");
            labelLoginSenha.Text = Properties.Resources.ResourceManager.GetString("LabelLoginSenha");
            buttonLoginEntrar.Text = Properties.Resources.ResourceManager.GetString("ButtonLoginEntrar");
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            if ((textBoxLoginUser.Text != "") && (textBoxLoginPassord.Text != ""))
            {
                this.Hide();
                Menu menu = new();
                menu.FormClosed += (s, args) =>
                this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos", "Alerta", MessageBoxButtons.OK);
            }
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            textBoxLoginUser.BackColor = Color.LightBlue;
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            textBoxLoginUser.BackColor = Color.White;
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            textBoxLoginPassord.BackColor = Color.White; 
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            textBoxLoginPassord.BackColor = Color.LightBlue;
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
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
                form.Close();
            }
        }
    }
}
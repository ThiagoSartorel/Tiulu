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

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.FormClosed += (s, args) => 
            this.Close();
            menu.Show();
            
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.LightBlue;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.LightBlue;
        }
    }
}
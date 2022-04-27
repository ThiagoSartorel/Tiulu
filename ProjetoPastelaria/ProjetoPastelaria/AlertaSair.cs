namespace ProjetoPastelaria
{
    public partial class AlertaSair : Form
    {
        public AlertaSair()
        {
            InitializeComponent();
        }

        private void ButtonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonMinimi_Click(object sender, EventArgs e)
        {
            //Minimizar tudo
            this.Close();

        }
    }
}

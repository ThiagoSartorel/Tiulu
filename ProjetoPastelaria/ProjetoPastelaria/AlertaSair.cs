namespace ProjetoPastelaria
{
    public partial class AlertaSair : Form
    {
        public AlertaSair()
        {
            InitializeComponent();
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonMinimi_Click(object sender, EventArgs e)
        {
            //Minimizar tudo
            this.Close();

        }
    }
}

namespace RegistroAtos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_nascimento_Click(object sender, EventArgs e)
        {
            nascimento registronascimento = new nascimento();
            registronascimento.Show();
            fechar_home();

        }

        private void btn_casamento_Click(object sender, EventArgs e)
        {
            casamento registrocasamento = new casamento();
            registrocasamento.Show();
            fechar_home();

        }

        private void btn_obito_Click(object sender, EventArgs e)
        {
            obito registroobito = new obito();
            registroobito.Show();

            fechar_home();
        }
        private void fechar_home()
        {
            Form1 home = new Form1();
            home.Close();
        }
    }
}
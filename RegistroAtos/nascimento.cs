using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;



namespace RegistroAtos
{
    public partial class nascimento : Form
    {
        public nascimento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
           bd conexao = new bd();

            conexao.nascimento(data_registro.Text,data_nascimento.Text,nome_registro.Text,nome_pai.Text,nome_mae.Text,nascimento_pai.Text,nascimento_mae.Text,cpf_mae.Text,cpf_pai.Text);
            
              
               
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();

            this.Close();
        }
    }
}

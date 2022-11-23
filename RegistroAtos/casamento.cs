using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAtos
{
    public partial class casamento : Form
    {
        public casamento()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bd conexao = new bd();
            //conjuge1 
            conexao.conjuge(cpf_conjuge1.Text, nome_conjuge1.Text, nome_pai_conjuge1.Text, nome_mae_conjuge1.Text, nascimento_mae_conjuge1.Text, cpf_mae_conjuge1.Text, cpf_pai_conjuge1.Text);
            //conjuge2
            conexao.conjuge(cpf_conjuge2.Text, nome_conjuge2.Text, nome_pai_conjuge2.Text, nome_mae_conjuge2.Text, nascimento_mae_conjuge2.Text, cpf_mae_conjuge2.Text, cpf_pai_conjuge2.Text);
            //casamento
            conexao.casamento(data_registro.Text, data_casamento.Text, cpf_conjuge1.Text, cpf_conjuge2.Text);
        }
    }
}

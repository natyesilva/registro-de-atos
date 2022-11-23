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
    public partial class obito : Form
    {
        public obito()
        {
            InitializeComponent();
        }

        private void obito_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bd conexao= new bd();

            conexao.obito(data_registro.Text,data_obito.Text,nome_falecido.Text,data_nascimento.Text,nome_pai.Text,nome_mae.Text,nascimento_pai.Text,nascimento_mae.Text);
        }
    }
}

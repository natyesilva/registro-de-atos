using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace RegistroAtos
{
    internal class bd
    {
        private MySqlConnection bdConn; //MySQL
        private MySqlDataAdapter bdAdapter;
        private DataSet bdDataSet; //MySQL
        public bd() {

            bdDataSet = new DataSet();
            bdConn = new MySqlConnection("Persist Security  Info=False;server=localhost;database=registro;uid=root;server=localhost;database=registro;uid=root;pwd='1234'");

            try{
 	            bdConn.Open();
            }
            catch{
             MessageBox.Show("Impossível estabelecer conexão");
            }
            


        }
        public void nascimento(String data_registro,String data_nascimento,String nome_registro,String nome_pai,String nome_mae,String nascimento_pai,String nascimento_mae,String cpf_mae,String cpf_pai)
        {
            //Verifica se a conexão está aberta
            if (bdConn.State == ConnectionState.Open)
            {
                //Se estiver aberta insere os dados na BD
                MySqlCommand commS = new MySqlCommand("INSERT INTO nascimento (`id`,`data_registro`,`data_nascimento`,`nome_registro`,`nome_pai`,`nome_mae`,`data_nascimento_pai`,`data_nascimento_mae`,`cpf_pai`,`cpf_mae`) " +
                    "VALUES('',\\'" + data_registro  + "\\',\\'" + data_nascimento + "\\',\\'"+nome_registro+"\\',\\'"+nome_pai+"\\'',\\'"+nome_mae+"\\',\\'"+nascimento_pai+"\\',\\'"+nascimento_mae+"\\',\\'"+cpf_pai+"\\',\\'"+cpf_mae+"\\')", bdConn);
                commS.BeginExecuteNonQuery();
            }
        }
        public void conjuge(String cpf,String nome,String data_nascimento, String nome_pai, String nome_mae, String nascimento_pai, String nascimento_mae, String cpf_mae, String cpf_pai)
        {
            //Verifica se a conexão está aberta
            if (bdConn.State == ConnectionState.Open)
            {
                //Se estiver aberta insere os dados na BD
                MySqlCommand commS = new MySqlCommand("INSERT INTO conjuge (`cpf`,`nome`,`data_nascimento`,`nome_pai`,`nome_mae`,`data_nascimento_pai`,`data_nascimento_mae`,`cpf_pai`,`cpf_mae`)" +
                    "VALUES('',\\'" + cpf + "\\',\\'" + nome + "\\',\\'" + data_nascimento + "\\',\\'" + nome_pai + "\\'',\\'" + nome_mae + "\\',\\'" + nascimento_pai + "\\',\\'" + nascimento_mae + "\\',\\'" + cpf_pai + "\\',\\'" + cpf_mae + "\\')", bdConn);
                commS.BeginExecuteNonQuery();
            }
        }
        public void casamento(String data_registro, String data_casamento, String cpf_conjuge1, String cpf_conjuge2)
        {
            //Verifica se a conexão está aberta
            if (bdConn.State == ConnectionState.Open)
            {
                //Se estiver aberta insere os dados na BD
                MySqlCommand commS = new MySqlCommand("INSERT INTO casamento (`id`,`data_registro`,`data_casamento`,`conjuge_um`,`conjuge_dois`)" +
                    "VALUES('',\\'" +data_registro + "\\',\\'" + data_casamento + "\\',\\'" +cpf_conjuge1 + "\\',\\'" +cpf_conjuge2 + "\\'')", bdConn);
                commS.BeginExecuteNonQuery();
            }
        }
        public void obito(String data_registro, String data_obito, String nome_falecido,String data_nascimento, String nome_pai, String nome_mae, String nascimento_pai, String nascimento_mae)
        {
            //Verifica se a conexão está aberta
            if (bdConn.State == ConnectionState.Open)
            {
                //Se estiver aberta insere os dados na BD
                MySqlCommand commS = new MySqlCommand("INSERT INTO obito (`id`,`data_registro`,`data_obito`,`nome_falecido`,`data_nascimento`,`nome_pai`,`nome_mae`,`data_nascimento_pai`,`data_nascimento_mae`) " +
                    "VALUES('',\\'" + data_registro + "\\',\\'" + data_obito + "\\',\\'" + nome_falecido + "\\',\\'" + nome_pai + "\\'',\\'" + nome_mae + "\\',\\'" + nascimento_pai + "\\',\\'" + nascimento_mae + "\\')", bdConn);
                commS.BeginExecuteNonQuery();
            }
        }

    }
}

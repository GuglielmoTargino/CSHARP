using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindoFormAtv3.global;

namespace WindoFormAtv3
{
    public partial class TelaDoc : Form
    {
        public TelaDoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTela3_Click(object sender, EventArgs e)
        {
            DadosPessoais dadosPessoais = new DadosPessoais();
            dadosPessoais.Show();
            this.Close();
        }

        private void btnTela2_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.rg = textBoxRG.Text;
            VariaveisGlobais.cpr = textBoxCPF.Text;
            MessageBox.Show($"RG: {VariaveisGlobais.rg}, CPF: {VariaveisGlobais.cpr}, Sexo: {VariaveisGlobais.sexo}");
      
        }

        private void btnTela4_Click(object sender, EventArgs e)
        {
            Interesses interesses = new Interesses();
            interesses.Show();
            this.Close();
        }

        private void radioButtonMas_CheckedChanged(object sender, EventArgs e)
        {
            VariaveisGlobais.sexo = "Masculino";
        }

        private void radioButtonFem_CheckedChanged(object sender, EventArgs e)
        {
            VariaveisGlobais.sexo = "Feminino";
        }

        private void textBoxRG_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cpr = textBoxCPF.Text;

            string dados = "datasource=localhost; username=ght; password=4004; database=carro";
            //criar connec
            var Conexao = new MySqlConnection(dados);


            string sql = "SELECT rg, sexo, nome, dtnasc, interesse, cpr FROM atv3 WHERE cpr = @cpr";
            MySqlCommand comando = new MySqlCommand(sql, Conexao);
            comando.Parameters.AddWithValue("@cpr", cpr); // variável cpr deve estar preenchida

            Conexao.Open();
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                string rg = reader["rg"].ToString();
                string sexo = reader["sexo"].ToString();
                string nome = reader["nome"].ToString();
                string dtnasc = reader["dtnasc"].ToString(); // ou DateTime.Parse se quiser como data
                string interesse = reader["interesse"].ToString();
                string cpf = reader["cpr"].ToString();

                // Agora você pode usar essas variáveis como quiser
                MessageBox.Show($"Nome: {nome}, Sexo: {sexo}");

                textBoxRG.Text = rg;
            
                VariaveisGlobais.rg = rg;
                VariaveisGlobais.sexo = sexo;
                VariaveisGlobais.nome = nome;
                VariaveisGlobais.dtnasc= dtnasc;
                VariaveisGlobais.interesse = interesse;
                VariaveisGlobais.cpr = textBoxCPF.Text;

            }
            else
            {
                MessageBox.Show("CPF não encontrado.");
            }

            reader.Close();
            Conexao.Close();

        }
    }
}

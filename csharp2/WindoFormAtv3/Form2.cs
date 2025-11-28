using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindoFormAtv3.global;
using WindoFormAtv3.SistemaDao;

/*
 Atividade-IV (em grupo) desenvolvida em sala de aula valendo nota da AV1.

Prof: Joao Vagner Pereira Da Silva

Alunos: Guglielmo Henriques Targino
RA: 2222104623

Marcelo Vitor Duarte Ramos de Jesus
RA:2223100385

Data: 08Nov25.
Versão: v4

Escopo;
Conforme demostrado e projetado em sala de aula :

crie um pequeno formulário que escreva em um Banco de dados, dê preferença ao SQLite portable

Obs: O SGBD SQLite portable se encontra instalado na pasta resources.
 
 */

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

            string conexaoString = "";
            ConexaoBD conn = new ConexaoBD();
            conexaoString=conn.ConectarBD();

            using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
            {
                try
                {
                    conexao.Open();    
                    Console.WriteLine("Conexão estabelecida com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                string sql = "SELECT rg, sexo, nome, dtnasc, interesse, cpr FROM atv3 WHERE cpr = @cpr";

                using (SQLiteCommand comando = new SQLiteCommand(sql, conexao))
                {
                    comando.Parameters.AddWithValue("@cpr", cpr);
                    using (SQLiteDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Carrega os valores do banco
                            string rg = reader["rg"].ToString();
                            string sexo = reader["sexo"].ToString();
                            string nome = reader["nome"].ToString();
                            string dtnasc = reader["dtnasc"].ToString();
                            string interesse = reader["interesse"].ToString();

                            // Exibe nos textboxes
                            textBoxRG.Text = rg;
                            // Se quiser guardar em variáveis globais também
                            VariaveisGlobais.rg = rg;
                            VariaveisGlobais.nome = nome;
                            VariaveisGlobais.sexo = sexo;
                            VariaveisGlobais.dtnasc = dtnasc;
                            VariaveisGlobais.interesse = interesse;
                            VariaveisGlobais.cpr = reader["cpr"].ToString();

                            MessageBox.Show("Registro encontrado!");
                        }
                        else
                        {
                            MessageBox.Show("CPF não encontrado no banco de dados.");
                        }
                    }
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
      
        }
    }
}

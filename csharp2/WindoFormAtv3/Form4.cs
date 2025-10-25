using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindoFormAtv3.global;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace WindoFormAtv3
{
    public partial class Interesses : Form
    {
        public Interesses()
        {
            InitializeComponent();
            comboBox1.Items.Add("Lazer");
            comboBox1.Items.Add("Trabalho");

            lblRg.Text = "-" + VariaveisGlobais.rg.ToString();
            lblCpf.Text = "-" + VariaveisGlobais.cpr.ToString();
            lblSexo.Text = "-" + VariaveisGlobais.sexo.ToString();
            lblNome.Text = "-" + VariaveisGlobais.nome.ToString();
            lblNasc.Text = "-" + VariaveisGlobais.dtnasc.ToString();
        }

        private void btnTela2_Click(object sender, EventArgs e)
        {            
            TelaDoc telaDoc = new TelaDoc();
            telaDoc.Show();
            this.Close();
        }

        private void btnTela3_Click(object sender, EventArgs e)
        {
            DadosPessoais dadosPessoais = new DadosPessoais();
            dadosPessoais.Show();
            this.Close( );

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.SalvarEmArquivo();
     
            lblInteres.Text = "intereses:" + VariaveisGlobais.interesse.ToString();
        }

        private void viagem_CheckedChanged(object sender, EventArgs e)
        {
            VariaveisGlobais.interesse = "Viagens";
            lblInteres.Text = "intereses:" + VariaveisGlobais.interesse.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            VariaveisGlobais.interesse = "Cinema";
            lblInteres.Text = "intereses:" + VariaveisGlobais.interesse.ToString();
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {

            try
            {
                string caminhoBanco = @"H:/csharp2/WindoFormAtv3/Resources/bdmysqlite/SQLiteDatabaseBrowserPortable/carro.db";
                string conexaoString = $"Data Source={caminhoBanco};Version=3;";
                Console.WriteLine("Usando banco em: " + caminhoBanco);

                using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
                {
                    conexao.Open();

                    string sql = "UPDATE atv3 SET nome = @nome, sexo = @sexo, rg = @rg, dtnasc = @dtnasc, interesse = @interesse WHERE cpr = @cpr";
                    using (SQLiteCommand comando = new SQLiteCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@rg", VariaveisGlobais.rg);
                        comando.Parameters.AddWithValue("@sexo", VariaveisGlobais.sexo);
                        comando.Parameters.AddWithValue("@cpr", VariaveisGlobais.cpr);
                        comando.Parameters.AddWithValue("@dtnasc", VariaveisGlobais.dtnasc);
                        comando.Parameters.AddWithValue("@interesse", VariaveisGlobais.interesse);
                        comando.Parameters.AddWithValue("@nome", VariaveisGlobais.nome);

                        int linhas = comando.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0 ? "Registro atualizado!" : "Nenhum registro encontrado para atualizar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }




        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

          

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            

            try
            {
                string caminhoBanco = @"H:/csharp2/WindoFormAtv3/Resources/bdmysqlite/SQLiteDatabaseBrowserPortable/carro.db";
                string conexaoString = $"Data Source={caminhoBanco};Version=3;";
                Console.WriteLine("Usando banco em: " + caminhoBanco);

                using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
                {
                    conexao.Open();
                    Console.WriteLine("Conexão estabelecida com sucesso!");

                    // Dados a serem inseridos
                    string nome = VariaveisGlobais.nome;
                    string rg = VariaveisGlobais.rg;
                    string cpr = VariaveisGlobais.cpr;
                    string sexo = VariaveisGlobais.sexo;
                    string dtnasc = VariaveisGlobais.dtnasc;
                    string interesse = VariaveisGlobais.interesse;

                    // Comando INSERT
                    string sql = "DELETE FROM atv3 WHERE cpr= @cpr";

                    using (SQLiteCommand comando = new SQLiteCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@cpr", cpr);        
                        int linhasAfetadas = comando.ExecuteNonQuery();
                        MessageBox.Show($"REGISTRO DELETADO");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocorreu um erro: " + ex.Message);
                Console.WriteLine("Detalhes: " + ex.StackTrace);
                MessageBox.Show("Erro ao salvar no SQLite: " + ex.Message);
                Console.WriteLine("STACKTRACE => " + ex.StackTrace);
            }
        }





    }
    
}

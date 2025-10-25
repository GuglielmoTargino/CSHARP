using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindoFormAtv3.global
{
    public static class VariaveisGlobais
    {
        public static string rg, cpr, sexo, nome, dtnasc, interesse = "0";

       private static string caminhoArquivo = "H:/csharp2/WindoFormAtv3/Resources/dados_formulario.txt";
        //private static string caminhoArquivo = "C:/GIT_REP_CSHARP/CSHARP/WindoFormAtv3/WindoFormAtv3/Resources/dados_formulario.txt";


        // Método para salvar no arquivo
        public static void SalvarEmArquivo()
        {
            Console.WriteLine("=== DEBUG SQLITE ===");
            Console.WriteLine("Arquivo existe? " + System.IO.File.Exists(caminhoArquivo));
            Console.WriteLine("SQLite DLL carregada? Tentando conexão...");

            string[] linhas = {
                $"RG={rg}",
                $"CPF={cpr}",
                $"SEXO ={sexo }",
                $"NOME = {nome}",
                $"DATA_NASC={dtnasc}",
                $"INRETSSES={interesse}"           
                
             };

            System.IO.File.WriteAllLines(caminhoArquivo, linhas);

            // Salvar no bd aqui

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
                    string sql = "INSERT INTO atv3 (nome,rg,cpr,sexo,dtnasc,interesse) VALUES (@nome,@rg,@cpr,@sexo,@dtnasc,@interesse)";

                    using (SQLiteCommand comando = new SQLiteCommand(sql, conexao))
                    {
                        comando.Parameters.AddWithValue("@rg", rg);
                        comando.Parameters.AddWithValue("@cpr", cpr);
                        comando.Parameters.AddWithValue("@sexo", sexo);
                        comando.Parameters.AddWithValue("@nome", nome);
                        comando.Parameters.AddWithValue("@dtnasc", dtnasc);
                        comando.Parameters.AddWithValue("@interesse", interesse);

                        int linhasAfetadas = comando.ExecuteNonQuery();
                       // Console.WriteLine($"{linhasAfetadas} registro(s) inserido(s) com sucesso.");
                        MessageBox.Show("DADOS CADASTRADOS");
                    }
                }
            }
            catch (Exception ex)
            {   

                MessageBox.Show("Erro ao salvar no SQLite: " + ex.Message);
                
            }
        }
        }
}

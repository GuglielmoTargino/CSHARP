using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

namespace WindoFormAtv3.global
{
 
    public static class VariaveisGlobais
    {
        public static string rg, cpr, sexo, nome, dtnasc, interesse = "0";

        public static void SalvarEmArquivo()
        {
            
            ConexaoBD conn = new ConexaoBD();
            string caminhoArquivo = conn.GetConexaoString();


            // Método para salvar no arquivo


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
                string conexaoString = "";
                //ConexaoBD conn = new ConexaoBD();
                conexaoString = conn.ConectarBD();

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

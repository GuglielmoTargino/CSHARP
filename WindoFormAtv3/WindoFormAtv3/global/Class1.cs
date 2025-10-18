using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindoFormAtv3.global
{
    public static class VariaveisGlobais
    {
        public static string rg, cpr, sexo, nome, dtnasc, interesse = "0";

      


       // private static string caminhoArquivo = "E:/WindoFormAtv3/WindoFormAtv3/Resources/dados_formulario.txt";
        private static string caminhoArquivo = "C:/GIT_REP_CSHARP/CSHARP/WindoFormAtv3/WindoFormAtv3/Resources/dados_formulario.txt";


        // Método para salvar no arquivo
        public static void SalvarEmArquivo()
        {
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
                string dados = " datasource=localhost; username=ght; password=4004; database=carro";
                //criar connec
                var Conexao = new MySqlConnection(dados);
                Conexao.Close();

                /// exec query

                string sql = " INSERT INTO atv3 (rg, cpr, sexo, nome, dtnasc, interesse) VALUES(@rg, @cpr, @sexo, @nome, @dtnasc, @interesse)";

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                comando.Parameters.AddWithValue("@rg", rg);
                comando.Parameters.AddWithValue("@cpr", cpr);
                comando.Parameters.AddWithValue("@sexo", sexo);
                comando.Parameters.AddWithValue("@nome", nome);
                comando.Parameters.AddWithValue("@dtnasc", dtnasc);
                comando.Parameters.AddWithValue("@interesse", interesse);

                Conexao.Open();
                comando.ExecuteReader();
             
                MessageBox.Show("Dados cadastrados");

                Conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
           
            //////////////////fim aqui
        }
        
    }
}

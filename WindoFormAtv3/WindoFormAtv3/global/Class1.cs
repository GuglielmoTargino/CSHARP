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
        public static string rg, cpr, sexo, nome, dtnasc, interesse;

      
        //public static string cpr;
        //public static string sexo;
        //public static string nome;
        //public static string dtnasc;
        //public static string interesse;


        private static string caminhoArquivo = "E:/WindoFormAtv3/WindoFormAtv3/Resources/dados_formulario.txt";
       // private static string caminhoArquivo = "C:/GIT_REP_CSHARP/CSHARP/WindoFormAtv3/WindoFormAtv3/Resources/dados_formulario.txt";


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
        }
    }
}

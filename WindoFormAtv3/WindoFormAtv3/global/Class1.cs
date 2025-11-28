
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 Atividade-3 desenvolvida em sala de aula valendo nota da AV1.

Prof: Joao Vagner Pereira Da Silva
Aluno: Guglielmo Henriques Targino
RA: 2222104623
Data: 08Nov25.
Versão: v2

Escopo;
construa um sistema de cadastro com os seguintes formulários:

tela inicial
dados pessoais ( com radio buttons - sexo)
documentação
interesses ( checkbox)
 botões de SAIR, INICIAL,  CONTINUA, ENVIA
e gravar os dados em arquivo de historico ( logger) 
Obs: Arquivo de logger fica na pasta Resources (dados_formulario.txt) 
 
 */

namespace WindoFormAtv3.global
{
    public static class VariaveisGlobais
    {
        public static string rg, cpr, sexo, nome, dtnasc, interesse = "0";

     
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

            
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindoFormAtv3.global;

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

namespace WindoFormAtv3.SistemaDao
{

    internal class ConexaoBD
    {
        private string conexaoString;
        private string getform;
        public ConexaoBD()
        {
            string caminhoBanco = @"H:/csharp2/WindoFormAtv3/Resources/bdmysqlite/SQLiteDatabaseBrowserPortable/carro.db";
            conexaoString = $"Data Source={caminhoBanco};Version=3;";

        }

        public string ConectarBD()
        {
            return conexaoString;
        }

        public string GetConexaoString()
           
        {
            getform = "H:/csharp2/WindoFormAtv3/Resources/dados_formulario.txt";

            return getform;
        }






        /*
           public bool TestarConexao()
           {
               try
               {
                   using (SQLiteConnection conexao = new SQLiteConnection(conexaoString))
                   {
                       conexao.Open();
                       return true; // Conexão bem-sucedida
                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show($"Erro ao conectar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   return false;
               }
           }*/




    }
}
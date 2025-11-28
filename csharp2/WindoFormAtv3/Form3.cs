using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

namespace WindoFormAtv3
{
    public partial class DadosPessoais : Form
    {
        public DadosPessoais()
        {
            InitializeComponent();
        }

        private void Tela2_Click(object sender, EventArgs e)
        {
            TelaDoc telaDoc = new TelaDoc();
            telaDoc.Show();
            this.Close();
        }

        private void Tela4_Click(object sender, EventArgs e)
        {
            Interesses interesses = new Interesses();
            interesses.Show();
            this.Close();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.nome = tboxNome.Text;
            VariaveisGlobais.dtnasc = tBoxNasc.Text;
            MessageBox.Show($"NOME: {VariaveisGlobais.nome}, DATA_NASC: {VariaveisGlobais.dtnasc}");
            //VariaveisGlobais.SalvarEmArquivo();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

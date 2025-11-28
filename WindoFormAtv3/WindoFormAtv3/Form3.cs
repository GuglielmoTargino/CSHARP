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
Obs: Arquivo de logger fica na pasta Resources (dados_formulario.txt) 
 
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

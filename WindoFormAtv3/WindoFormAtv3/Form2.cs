
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
         }
    }
}

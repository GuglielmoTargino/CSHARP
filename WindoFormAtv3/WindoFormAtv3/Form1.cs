using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

namespace WindoFormAtv3
{
    public partial class TelaLogin : Form
    {

       
        public TelaLogin()
        {
            InitializeComponent();
        }

        private void btnContinua_Click(object sender, EventArgs e)
        {
           

           
            string usu = textBoxNome.Text;
            string senh = textBoxSenha.Text;


            if (usu == "admin" && senh == "1234")
            {
               
                TelaDoc Docu = new TelaDoc();             
                Docu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");

            }

        }

    }
}

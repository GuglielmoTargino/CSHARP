using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

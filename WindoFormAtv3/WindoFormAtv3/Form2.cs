using MySql.Data.MySqlClient;
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
            //this.Close();
            //this.Hide();
           
            

            DadosPessoais dadosPessoais = new DadosPessoais();
            dadosPessoais.Show();
            this.Close();

        }

        private void btnTela2_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.rg = textBoxRG.Text;
            VariaveisGlobais.cpr = textBoxCPF.Text;
            MessageBox.Show($"RG: {VariaveisGlobais.rg}, CPF: {VariaveisGlobais.cpr}, Sexo: {VariaveisGlobais.sexo}");
            //VariaveisGlobais.SalvarEmArquivo();



            try
            {
                string dados = " datasource=localhost; username=ght; password=4004; database=carro";
                //criar connec
                var Conexao = new MySqlConnection(dados);

                /// exec query

                string sql = " INSERT INTO atv3 (rg, cpr, sexo, nome, dtnasc, interesse) VALUES('guga', 'gugu','gugu','ugg','gugu','gugu')";

                MySqlCommand comando = new MySqlCommand(sql,Conexao);
                Conexao.Open();
                comando.ExecuteReader();
                MessageBox.Show("Dados cadastrados");

                Conexao.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );

              
            }

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
    }
}

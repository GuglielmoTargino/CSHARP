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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace WindoFormAtv3
{
    public partial class Interesses : Form
    {


       

        public Interesses()
        {
            InitializeComponent();
            comboBox1.Items.Add("Lazer");
            comboBox1.Items.Add("Trabalho");

            lblRg.Text = "RG:" + VariaveisGlobais.rg.ToString();
            lblCpf.Text = "CPF:" + VariaveisGlobais.cpr.ToString();
            lblSexo.Text = "SEXO:" + VariaveisGlobais.sexo.ToString();
            lblNome.Text = "Nome:" + VariaveisGlobais.nome.ToString();
            lblNasc.Text = "Data Nasc.:" + VariaveisGlobais.dtnasc.ToString();
        }

        String vbox;







        private void btnTela2_Click(object sender, EventArgs e)
        {            
            TelaDoc telaDoc = new TelaDoc();
            telaDoc.Show();
            this.Close();
        }





        private void btnTela3_Click(object sender, EventArgs e)
        {
            DadosPessoais dadosPessoais = new DadosPessoais();
            dadosPessoais.Show();
            this.Close( );

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.SalvarEmArquivo();
            MessageBox.Show($"INTERESSE: {VariaveisGlobais.interesse}");
            lblInteres.Text = "intereses:" + VariaveisGlobais.interesse.ToString();
        }

        private void viagem_CheckedChanged(object sender, EventArgs e)
        {
            VariaveisGlobais.interesse = "Viagens";
            lblInteres.Text = "intereses:" + VariaveisGlobais.interesse.ToString();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            VariaveisGlobais.interesse = "Cinema";
            lblInteres.Text = "intereses:" + VariaveisGlobais.interesse.ToString();
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

          

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   


            try
            {
                string dados = "datasource=localhost; username=ght; password=4004; database=carro";
                using (MySqlConnection Conexao = new MySqlConnection(dados))
                {
                    Conexao.Open();

                    string sql = "DELETE FROM atv3 WHERE cpr = @cpr";
                    using (MySqlCommand comando = new MySqlCommand(sql, Conexao))
                    {
                        comando.Parameters.AddWithValue("@cpr", VariaveisGlobais.cpr);

                        int linhas = comando.ExecuteNonQuery();
                        MessageBox.Show(linhas > 0 ? "Registro deletado!" : "Nenhum registro encontrado.");
                        Conexao.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
    }
}

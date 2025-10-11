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
        }

        private void viagem_CheckedChanged(object sender, EventArgs e)
        {
            VariaveisGlobais.interesse = "Viagens";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            VariaveisGlobais.interesse = "Cinema";
        }

        private void btnEnviar_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)

        {

          

        }
    }
}

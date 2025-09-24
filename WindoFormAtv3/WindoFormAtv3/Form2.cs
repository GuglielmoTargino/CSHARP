using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void btnTela4_Click(object sender, EventArgs e)
        {
            Interesses interesses = new Interesses();
            interesses.Show();

            this.Close();   


        }
    }
}

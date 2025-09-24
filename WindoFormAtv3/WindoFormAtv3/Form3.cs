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
    }
}

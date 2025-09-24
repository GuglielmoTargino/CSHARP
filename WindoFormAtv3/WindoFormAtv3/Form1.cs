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

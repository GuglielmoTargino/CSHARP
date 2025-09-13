using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoFormsIMC
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            float resu, peso, altu;

            pictureBox1.Image = Image.FromFile("E:/visualstddio/gordo.jpg");
            // Ou, para um recurso local mais robusto:
            // pictureBox1.Image = Properties.Resources.NomeDaSuaImagem;

            if (resu<1)
            {
                // Code to be executed if condition1 is true
            }
            else if (resu<11)
            {
                // Code to be executed if condition1 is false and condition2 is true
            }
            else if (resu<13)
            {
                // Code to be executed if condition1 is false and condition2 is true
            }
            else if (resu<14)
            {
                // Code to be executed if condition1 is false and condition2 is true
            }
            else if (resu<15)
            {
                // Code to be executed if condition1 is false and condition2 is true
            }
            else if (resu<19)
            {
                // Code to be executed if condition1 is false and condition2 is true
            }
            else
            {
                // Code to be executed if all preceding conditions are false
            }



        }
    }
}

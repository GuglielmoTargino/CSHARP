
/*
 
 Programa desenvolvido em sala de aula para calcular Indice de massa corpórea-IMC.

Prof: João Vagner.
Aluno: Guglielmo Henriques Targino.
RA: 2222104623.
Data: 15/set/25
versão: v2. 

O Índice de Massa Corporal (IMC) é calculado dividindo o peso em quilogramas pela altura ao quadrado em metros. A fórmula é: IMC = peso / (altura x altura).

A tabela do IMC (Índice de Massa Corporal) relaciona o valor do IMC com a classificação de peso.

IMC Classificação

Menor que 18,5 - Abaixo do peso
entre 18,5–24,9 - Peso normal
entre 25,0–29,9 - Sobrepeso
entre 30,0–34,9 - Obesidade grau I
entre 35,0–39,9 - Obesidade grau II
entre 40,0 e acima - Obesidade grau III ou mórbida
 
 */





//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using System;

using System.Drawing;

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

            
                float resu = 0, peso = 0, altu = 0;           
            peso = float.Parse(textBoxPeso.Text);
            altu = float.Parse(textBoxAltu.Text);

            resu = peso / (altu * altu);

        

            if (resu <= 18.5)
            {                // Code to be executed if condition1 is true
                pictureBox1.Image = Image.FromFile("C:/GIT_REP_CSHARP/CSHARP/atv2IMC/magro.jpg");
                textBoxAviso.Text = resu.ToString("F2");
                texboxalerta.Text = "Abaixo do peso";
            }
            else if (resu<25)
            {
                // Code to be executed if condition1 is false and condition2 is true
                pictureBox1.Image = Image.FromFile("C:/GIT_REP_CSHARP/CSHARP/atv2IMC/normal.jpg");
                textBoxAviso.Text = resu.ToString("f2");
                texboxalerta.Text = "Peso normal";
            }
            else if (resu<30)
            {
                // Code to be executed if condition1 is false and condition2 is true
                pictureBox1.Image = Image.FromFile("C:/GIT_REP_CSHARP/CSHARP/atv2IMC/normal.jpg");
                textBoxAviso.Text = resu.ToString("f2");
                texboxalerta.Text = "Sobrepeso";
            }
            else if (resu<35)
            {
                // Code to be executed if condition1 is false and condition2 is true
                pictureBox1.Image = Image.FromFile("C:/GIT_REP_CSHARP/CSHARP/atv2IMC/gordo.jpg");
                textBoxAviso.Text = resu.ToString("f2");
                texboxalerta.Text = "Obesidade grau 1";
            }
            else if (resu < 40)
            {
                // Code to be executed if condition1 is false and condition2 is true
                pictureBox1.Image = Image.FromFile("C:/GIT_REP_CSHARP/CSHARP/atv2IMC/gordo.jpg");
                textBoxAviso.Text = resu.ToString("f2");
                texboxalerta.Text = "Obesidade grau 2";
            }


            else
            {
                // Code to be executed if all preceding conditions are false
                pictureBox1.Image = Image.FromFile("C:/GIT_REP_CSHARP/CSHARP/atv2IMC/gordo.jpg");
                textBoxAviso.Text = resu.ToString("f2");
                texboxalerta.Text = "Obesidade grau III ou mórbida";
            }



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

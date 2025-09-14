
/*Programa desenvolvido como tarefa em sala de aula.
 * Prof: Joao Vagner Pereira Da Silva.
 * Aluno: Guglielmo Henriques Targino.
 * RA: 2222104623
 * Data: 14/set/25
 * Versão: v2
 * 
 
Objetivo: 
 Desenvolver um programa/tela  em C# que solicita 3 notas e calcula a media com 1 casa decimal.
se esta media for > 6 mostrar aprovado
caso contrario reprovado
 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppGuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtMedia_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            float media, n1, n2, n3;

            n1 = float.Parse(txtNota1.Text);
            n2 = float.Parse(txtNota2.Text);
            n3 = float.Parse(txtNota3.Text);

            media = (n1 + n2 + n3) / 3;

            txtMedia.Text = media.ToString("f2");


            if (media>=6)
            {
                txtMedia.Text = "Aprovado";
                txtMedia.Visible = true;

            }
            else
            {
                txtMedia.Text = "Reprovado";
                txtMedia.Visible = true;
            }


        }
    }
}

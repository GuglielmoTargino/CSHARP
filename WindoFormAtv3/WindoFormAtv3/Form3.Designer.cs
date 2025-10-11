namespace WindoFormAtv3
{
    partial class DadosPessoais
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Sair = new System.Windows.Forms.Button();
            this.Enviar = new System.Windows.Forms.Button();
            this.Tela2 = new System.Windows.Forms.Button();
            this.Tela4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxNome = new System.Windows.Forms.TextBox();
            this.tBoxNasc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Sair
            // 
            this.Sair.Location = new System.Drawing.Point(413, 12);
            this.Sair.Name = "Sair";
            this.Sair.Size = new System.Drawing.Size(75, 23);
            this.Sair.TabIndex = 0;
            this.Sair.Text = "Sair";
            this.Sair.UseVisualStyleBackColor = true;
            this.Sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // Enviar
            // 
            this.Enviar.Location = new System.Drawing.Point(92, 232);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 23);
            this.Enviar.TabIndex = 1;
            this.Enviar.Text = "Salvar";
            this.Enviar.UseVisualStyleBackColor = true;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // Tela2
            // 
            this.Tela2.Location = new System.Drawing.Point(413, 92);
            this.Tela2.Name = "Tela2";
            this.Tela2.Size = new System.Drawing.Size(75, 23);
            this.Tela2.TabIndex = 2;
            this.Tela2.Text = "Tela2";
            this.Tela2.UseVisualStyleBackColor = true;
            this.Tela2.Click += new System.EventHandler(this.Tela2_Click);
            // 
            // Tela4
            // 
            this.Tela4.Location = new System.Drawing.Point(413, 135);
            this.Tela4.Name = "Tela4";
            this.Tela4.Size = new System.Drawing.Size(75, 23);
            this.Tela4.TabIndex = 3;
            this.Tela4.Text = "Tela4";
            this.Tela4.UseVisualStyleBackColor = true;
            this.Tela4.Click += new System.EventHandler(this.Tela4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Nasc.";
            // 
            // tboxNome
            // 
            this.tboxNome.Location = new System.Drawing.Point(138, 97);
            this.tboxNome.Name = "tboxNome";
            this.tboxNome.Size = new System.Drawing.Size(196, 20);
            this.tboxNome.TabIndex = 6;
            // 
            // tBoxNasc
            // 
            this.tBoxNasc.Location = new System.Drawing.Point(197, 151);
            this.tBoxNasc.Name = "tBoxNasc";
            this.tBoxNasc.Size = new System.Drawing.Size(137, 20);
            this.tBoxNasc.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dados Pessoais";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DadosPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 325);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tBoxNasc);
            this.Controls.Add(this.tboxNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tela4);
            this.Controls.Add(this.Tela2);
            this.Controls.Add(this.Enviar);
            this.Controls.Add(this.Sair);
            this.Name = "DadosPessoais";
            this.Text = "DadosPessoais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Sair;
        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button Tela2;
        private System.Windows.Forms.Button Tela4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxNome;
        private System.Windows.Forms.TextBox tBoxNasc;
        private System.Windows.Forms.Label label3;
    }
}
namespace WindoFormAtv3
{
    partial class Interesses
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnTela2 = new System.Windows.Forms.Button();
            this.btnTela3 = new System.Windows.Forms.Button();
            this.viagem = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(508, 33);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(37, 243);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar tudo";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnTela2
            // 
            this.btnTela2.Location = new System.Drawing.Point(508, 99);
            this.btnTela2.Name = "btnTela2";
            this.btnTela2.Size = new System.Drawing.Size(75, 23);
            this.btnTela2.TabIndex = 2;
            this.btnTela2.Text = "Tela2";
            this.btnTela2.UseVisualStyleBackColor = true;
            this.btnTela2.Click += new System.EventHandler(this.btnTela2_Click);
            // 
            // btnTela3
            // 
            this.btnTela3.Location = new System.Drawing.Point(508, 161);
            this.btnTela3.Name = "btnTela3";
            this.btnTela3.Size = new System.Drawing.Size(75, 23);
            this.btnTela3.TabIndex = 3;
            this.btnTela3.Text = "Tela3";
            this.btnTela3.UseVisualStyleBackColor = true;
            this.btnTela3.Click += new System.EventHandler(this.btnTela3_Click);
            // 
            // viagem
            // 
            this.viagem.AutoSize = true;
            this.viagem.Location = new System.Drawing.Point(37, 161);
            this.viagem.Name = "viagem";
            this.viagem.Size = new System.Drawing.Size(61, 17);
            this.viagem.TabIndex = 6;
            this.viagem.Text = "Viagem";
            this.viagem.UseVisualStyleBackColor = true;
            this.viagem.CheckedChanged += new System.EventHandler(this.viagem_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(158, 161);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Cinema";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Interesses/Intertenimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Escolha uma opção";
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(189, 243);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 11;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(263, 163);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Interesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 320);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.viagem);
            this.Controls.Add(this.btnTela3);
            this.Controls.Add(this.btnTela2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnSair);
            this.Name = "Interesses";
            this.Text = "Interesses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnTela2;
        private System.Windows.Forms.Button btnTela3;
        private System.Windows.Forms.CheckBox viagem;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
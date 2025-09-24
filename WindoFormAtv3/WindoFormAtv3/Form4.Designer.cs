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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnTela2 = new System.Windows.Forms.Button();
            this.btnTela3 = new System.Windows.Forms.Button();
            this.viagem = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(713, 32);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(119, 388);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // btnTela2
            // 
            this.btnTela2.Location = new System.Drawing.Point(713, 86);
            this.btnTela2.Name = "btnTela2";
            this.btnTela2.Size = new System.Drawing.Size(75, 23);
            this.btnTela2.TabIndex = 2;
            this.btnTela2.Text = "Tela2";
            this.btnTela2.UseVisualStyleBackColor = true;
            this.btnTela2.Click += new System.EventHandler(this.btnTela2_Click);
            // 
            // btnTela3
            // 
            this.btnTela3.Location = new System.Drawing.Point(713, 139);
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
            this.viagem.Location = new System.Drawing.Point(113, 107);
            this.viagem.Name = "viagem";
            this.viagem.Size = new System.Drawing.Size(61, 17);
            this.viagem.TabIndex = 6;
            this.viagem.Text = "Viagem";
            this.viagem.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(251, 107);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(54, 17);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "Jogos";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(403, 107);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(61, 17);
            this.checkBox3.TabIndex = 8;
            this.checkBox3.Text = "Cinema";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // Interesses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.viagem);
            this.Controls.Add(this.btnTela3);
            this.Controls.Add(this.btnTela2);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnSair);
            this.Name = "Interesses";
            this.Text = "Interesses";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnTela2;
        private System.Windows.Forms.Button btnTela3;
        private System.Windows.Forms.CheckBox viagem;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}
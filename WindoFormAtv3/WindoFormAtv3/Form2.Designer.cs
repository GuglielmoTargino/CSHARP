namespace WindoFormAtv3
{
    partial class TelaDoc
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
            this.doc = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnTela3 = new System.Windows.Forms.Button();
            this.textBoxRG = new System.Windows.Forms.TextBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButtonMas = new System.Windows.Forms.RadioButton();
            this.radioButtonFem = new System.Windows.Forms.RadioButton();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnTela4 = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doc
            // 
            this.doc.AutoSize = true;
            this.doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc.Location = new System.Drawing.Point(83, 9);
            this.doc.Name = "doc";
            this.doc.Size = new System.Drawing.Size(320, 29);
            this.doc.TabIndex = 0;
            this.doc.Text = "Documentação de Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "RG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(41, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(442, 31);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTela3
            // 
            this.btnTela3.Location = new System.Drawing.Point(442, 76);
            this.btnTela3.Name = "btnTela3";
            this.btnTela3.Size = new System.Drawing.Size(75, 23);
            this.btnTela3.TabIndex = 5;
            this.btnTela3.Text = "Tela 3";
            this.btnTela3.UseVisualStyleBackColor = true;
            this.btnTela3.Click += new System.EventHandler(this.btnTela3_Click);
            // 
            // textBoxRG
            // 
            this.textBoxRG.Location = new System.Drawing.Point(103, 76);
            this.textBoxRG.Name = "textBoxRG";
            this.textBoxRG.Size = new System.Drawing.Size(203, 20);
            this.textBoxRG.TabIndex = 6;
            this.textBoxRG.TextChanged += new System.EventHandler(this.textBoxRG_TextChanged);
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Location = new System.Drawing.Point(103, 129);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(134, 20);
            this.textBoxCPF.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sexo";
            // 
            // radioButtonMas
            // 
            this.radioButtonMas.AutoSize = true;
            this.radioButtonMas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMas.Location = new System.Drawing.Point(128, 190);
            this.radioButtonMas.Name = "radioButtonMas";
            this.radioButtonMas.Size = new System.Drawing.Size(89, 21);
            this.radioButtonMas.TabIndex = 11;
            this.radioButtonMas.TabStop = true;
            this.radioButtonMas.Text = "Masculino";
            this.radioButtonMas.UseVisualStyleBackColor = true;
            this.radioButtonMas.CheckedChanged += new System.EventHandler(this.radioButtonMas_CheckedChanged);
            // 
            // radioButtonFem
            // 
            this.radioButtonFem.AutoSize = true;
            this.radioButtonFem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFem.Location = new System.Drawing.Point(264, 190);
            this.radioButtonFem.Name = "radioButtonFem";
            this.radioButtonFem.Size = new System.Drawing.Size(83, 21);
            this.radioButtonFem.TabIndex = 12;
            this.radioButtonFem.TabStop = true;
            this.radioButtonFem.Text = "Feminino";
            this.radioButtonFem.UseVisualStyleBackColor = true;
            this.radioButtonFem.CheckedChanged += new System.EventHandler(this.radioButtonFem_CheckedChanged);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(103, 239);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 13;
            this.btnEnviar.Text = "Alterar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnTela2_Click);
            // 
            // btnTela4
            // 
            this.btnTela4.Location = new System.Drawing.Point(442, 126);
            this.btnTela4.Name = "btnTela4";
            this.btnTela4.Size = new System.Drawing.Size(75, 23);
            this.btnTela4.TabIndex = 14;
            this.btnTela4.Text = "Tela 4";
            this.btnTela4.UseVisualStyleBackColor = true;
            this.btnTela4.Click += new System.EventHandler(this.btnTela4_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(264, 126);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TelaDoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 298);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnTela4);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.radioButtonFem);
            this.Controls.Add(this.radioButtonMas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxCPF);
            this.Controls.Add(this.textBoxRG);
            this.Controls.Add(this.btnTela3);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.doc);
            this.Name = "TelaDoc";
            this.Text = "TelaDoc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label doc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnTela3;
        private System.Windows.Forms.TextBox textBoxRG;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonMas;
        private System.Windows.Forms.RadioButton radioButtonFem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnTela4;
        private System.Windows.Forms.Button btnBuscar;
    }
}
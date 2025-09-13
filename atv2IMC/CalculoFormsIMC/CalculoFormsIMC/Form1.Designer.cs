namespace CalculoFormsIMC
{
    partial class form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPeso = new System.Windows.Forms.TextBox();
            this.textBoxAltu = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.textBoxAviso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.texboxalerta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IInforme o Peso em Kg";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Informe Altura em M.";
            // 
            // textBoxPeso
            // 
            this.textBoxPeso.Location = new System.Drawing.Point(227, 60);
            this.textBoxPeso.MaxLength = 50;
            this.textBoxPeso.Name = "textBoxPeso";
            this.textBoxPeso.Size = new System.Drawing.Size(50, 20);
            this.textBoxPeso.TabIndex = 2;
            // 
            // textBoxAltu
            // 
            this.textBoxAltu.Location = new System.Drawing.Point(227, 95);
            this.textBoxAltu.Name = "textBoxAltu";
            this.textBoxAltu.Size = new System.Drawing.Size(50, 20);
            this.textBoxAltu.TabIndex = 3;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(133, 165);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular IMC";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // textBoxAviso
            // 
            this.textBoxAviso.Location = new System.Drawing.Point(227, 132);
            this.textBoxAviso.Name = "textBoxAviso";
            this.textBoxAviso.ReadOnly = true;
            this.textBoxAviso.Size = new System.Drawing.Size(100, 20);
            this.textBoxAviso.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor de IMC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CalculoFormsIMC.Properties.Resources.normal;
            this.pictureBox1.Location = new System.Drawing.Point(497, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 326);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // texboxalerta
            // 
            this.texboxalerta.Location = new System.Drawing.Point(497, 366);
            this.texboxalerta.MaximumSize = new System.Drawing.Size(500, 40);
            this.texboxalerta.Name = "texboxalerta";
            this.texboxalerta.ReadOnly = true;
            this.texboxalerta.Size = new System.Drawing.Size(220, 20);
            this.texboxalerta.TabIndex = 9;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CalculoFormsIMC.Properties.Resources.Super_Mario_Bros_CD;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.texboxalerta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAviso);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBoxAltu);
            this.Controls.Add(this.textBoxPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "form1";
            this.Text = "Formulario Calculo IMC";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPeso;
        private System.Windows.Forms.TextBox textBoxAltu;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox textBoxAviso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox texboxalerta;
    }
}


namespace Desafio_IMC
{
    partial class Form1
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
            this.label1IMC = new System.Windows.Forms.Label();
            this.label2Peso = new System.Windows.Forms.Label();
            this.label3Altura = new System.Windows.Forms.Label();
            this.textBox1peso = new System.Windows.Forms.TextBox();
            this.textBox2altura = new System.Windows.Forms.TextBox();
            this.button1Cal = new System.Windows.Forms.Button();
            this.button2Sair = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1IMC
            // 
            this.label1IMC.AutoSize = true;
            this.label1IMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1IMC.Location = new System.Drawing.Point(385, 29);
            this.label1IMC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1IMC.Name = "label1IMC";
            this.label1IMC.Size = new System.Drawing.Size(53, 25);
            this.label1IMC.TabIndex = 0;
            this.label1IMC.Text = "IMC";
            // 
            // label2Peso
            // 
            this.label2Peso.AutoSize = true;
            this.label2Peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2Peso.Location = new System.Drawing.Point(85, 131);
            this.label2Peso.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2Peso.Name = "label2Peso";
            this.label2Peso.Size = new System.Drawing.Size(65, 25);
            this.label2Peso.TabIndex = 1;
            this.label2Peso.Text = "Peso";
            // 
            // label3Altura
            // 
            this.label3Altura.AutoSize = true;
            this.label3Altura.Location = new System.Drawing.Point(95, 197);
            this.label3Altura.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3Altura.Name = "label3Altura";
            this.label3Altura.Size = new System.Drawing.Size(74, 25);
            this.label3Altura.TabIndex = 2;
            this.label3Altura.Text = "Altura";
            // 
            // textBox1peso
            // 
            this.textBox1peso.Location = new System.Drawing.Point(202, 131);
            this.textBox1peso.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox1peso.Name = "textBox1peso";
            this.textBox1peso.Size = new System.Drawing.Size(194, 31);
            this.textBox1peso.TabIndex = 3;
            // 
            // textBox2altura
            // 
            this.textBox2altura.Location = new System.Drawing.Point(202, 197);
            this.textBox2altura.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.textBox2altura.Name = "textBox2altura";
            this.textBox2altura.Size = new System.Drawing.Size(194, 31);
            this.textBox2altura.TabIndex = 4;
            // 
            // button1Cal
            // 
            this.button1Cal.Location = new System.Drawing.Point(192, 263);
            this.button1Cal.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button1Cal.Name = "button1Cal";
            this.button1Cal.Size = new System.Drawing.Size(143, 41);
            this.button1Cal.TabIndex = 5;
            this.button1Cal.Text = "CALCULAR";
            this.button1Cal.UseVisualStyleBackColor = true;
            this.button1Cal.Click += new System.EventHandler(this.button1Cal_Click);
            // 
            // button2Sair
            // 
            this.button2Sair.Location = new System.Drawing.Point(598, 411);
            this.button2Sair.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.button2Sair.Name = "button2Sair";
            this.button2Sair.Size = new System.Drawing.Size(161, 44);
            this.button2Sair.TabIndex = 6;
            this.button2Sair.Text = "Sair";
            this.button2Sair.UseVisualStyleBackColor = true;
            this.button2Sair.Click += new System.EventHandler(this.button2Sair_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(508, 86);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 229);
            this.listBox1.TabIndex = 7;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 478);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2Sair);
            this.Controls.Add(this.button1Cal);
            this.Controls.Add(this.textBox2altura);
            this.Controls.Add(this.textBox1peso);
            this.Controls.Add(this.label3Altura);
            this.Controls.Add(this.label2Peso);
            this.Controls.Add(this.label1IMC);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1IMC;
        private System.Windows.Forms.Label label2Peso;
        private System.Windows.Forms.Label label3Altura;
        private System.Windows.Forms.TextBox textBox1peso;
        private System.Windows.Forms.TextBox textBox2altura;
        private System.Windows.Forms.Button button1Cal;
        private System.Windows.Forms.Button button2Sair;
        private System.Windows.Forms.ListBox listBox1;
    }
}


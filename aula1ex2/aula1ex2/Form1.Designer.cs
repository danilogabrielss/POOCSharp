namespace aula1ex2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.catetoOpostoTextBox = new System.Windows.Forms.TextBox();
            this.catetoAdjTextBox = new System.Windows.Forms.TextBox();
            this.hipotenusaTextBox = new System.Windows.Forms.TextBox();
            this.CalcularTriangulo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cateto Oposto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cateto Adjascente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hipotenusa";
            // 
            // catetoOpostoTextBox
            // 
            this.catetoOpostoTextBox.Location = new System.Drawing.Point(136, 19);
            this.catetoOpostoTextBox.Name = "catetoOpostoTextBox";
            this.catetoOpostoTextBox.Size = new System.Drawing.Size(100, 20);
            this.catetoOpostoTextBox.TabIndex = 3;
            // 
            // catetoAdjTextBox
            // 
            this.catetoAdjTextBox.Location = new System.Drawing.Point(136, 51);
            this.catetoAdjTextBox.Name = "catetoAdjTextBox";
            this.catetoAdjTextBox.Size = new System.Drawing.Size(100, 20);
            this.catetoAdjTextBox.TabIndex = 4;
            // 
            // hipotenusaTextBox
            // 
            this.hipotenusaTextBox.Location = new System.Drawing.Point(136, 82);
            this.hipotenusaTextBox.Name = "hipotenusaTextBox";
            this.hipotenusaTextBox.Size = new System.Drawing.Size(100, 20);
            this.hipotenusaTextBox.TabIndex = 5;
            // 
            // CalcularTriangulo
            // 
            this.CalcularTriangulo.Location = new System.Drawing.Point(82, 121);
            this.CalcularTriangulo.Name = "CalcularTriangulo";
            this.CalcularTriangulo.Size = new System.Drawing.Size(104, 23);
            this.CalcularTriangulo.TabIndex = 6;
            this.CalcularTriangulo.Text = "Calcular triangulo";
            this.CalcularTriangulo.UseVisualStyleBackColor = true;
            this.CalcularTriangulo.Click += new System.EventHandler(this.CalcularTriangulo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "O triangulo é um";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(129, 176);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(22, 13);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "     ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 244);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalcularTriangulo);
            this.Controls.Add(this.hipotenusaTextBox);
            this.Controls.Add(this.catetoAdjTextBox);
            this.Controls.Add(this.catetoOpostoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox catetoOpostoTextBox;
        private System.Windows.Forms.TextBox catetoAdjTextBox;
        private System.Windows.Forms.TextBox hipotenusaTextBox;
        private System.Windows.Forms.Button CalcularTriangulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultado;
    }
}


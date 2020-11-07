namespace Aula2Ex1
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
            this.alturaTextBox = new System.Windows.Forms.TextBox();
            this.larguraTextBox = new System.Windows.Forms.TextBox();
            this.comprimetoTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Comprimento";
            // 
            // alturaTextBox
            // 
            this.alturaTextBox.Location = new System.Drawing.Point(151, 21);
            this.alturaTextBox.Name = "alturaTextBox";
            this.alturaTextBox.Size = new System.Drawing.Size(100, 20);
            this.alturaTextBox.TabIndex = 3;
            // 
            // larguraTextBox
            // 
            this.larguraTextBox.Location = new System.Drawing.Point(151, 57);
            this.larguraTextBox.Name = "larguraTextBox";
            this.larguraTextBox.Size = new System.Drawing.Size(100, 20);
            this.larguraTextBox.TabIndex = 4;
            // 
            // comprimetoTextBox
            // 
            this.comprimetoTextBox.Location = new System.Drawing.Point(151, 96);
            this.comprimetoTextBox.Name = "comprimetoTextBox";
            this.comprimetoTextBox.Size = new System.Drawing.Size(100, 20);
            this.comprimetoTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calcular volume";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(27, 178);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(224, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Clique no botão acima para exibiro o resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 220);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comprimetoTextBox);
            this.Controls.Add(this.larguraTextBox);
            this.Controls.Add(this.alturaTextBox);
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
        private System.Windows.Forms.TextBox alturaTextBox;
        private System.Windows.Forms.TextBox larguraTextBox;
        private System.Windows.Forms.TextBox comprimetoTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblResultado;
    }
}


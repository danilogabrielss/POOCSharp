namespace aula03Ex01
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.primeiroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.segundoTextBox = new System.Windows.Forms.TextBox();
            this.terceiroTextBox = new System.Windows.Forms.TextBox();
            this.labelResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Primeiro número";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Calcular somas dos quadrados";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // primeiroTextBox
            // 
            this.primeiroTextBox.Location = new System.Drawing.Point(139, 21);
            this.primeiroTextBox.Name = "primeiroTextBox";
            this.primeiroTextBox.Size = new System.Drawing.Size(59, 20);
            this.primeiroTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segundo número";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Terceiro número";
            // 
            // segundoTextBox
            // 
            this.segundoTextBox.Location = new System.Drawing.Point(139, 56);
            this.segundoTextBox.Name = "segundoTextBox";
            this.segundoTextBox.Size = new System.Drawing.Size(59, 20);
            this.segundoTextBox.TabIndex = 5;
            // 
            // terceiroTextBox
            // 
            this.terceiroTextBox.Location = new System.Drawing.Point(139, 92);
            this.terceiroTextBox.Name = "terceiroTextBox";
            this.terceiroTextBox.Size = new System.Drawing.Size(59, 20);
            this.terceiroTextBox.TabIndex = 6;
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(31, 166);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(178, 13);
            this.labelResultado.TabIndex = 7;
            this.labelResultado.Text = "Clique no botão para exibir resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 204);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.terceiroTextBox);
            this.Controls.Add(this.segundoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.primeiroTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox primeiroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox segundoTextBox;
        private System.Windows.Forms.TextBox terceiroTextBox;
        private System.Windows.Forms.Label labelResultado;
    }
}


namespace Taller2ControlesWinForms
{
    partial class For_TextBox
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
            labelTitulo = new Label();
            textBox1 = new TextBox();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(20, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(245, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Escribe en el siguiente cuadro";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(28, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "Algo";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 13F);
            labelResultado.Location = new Point(28, 99);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(240, 25);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "Acá aparece lo que escribiste";
            // 
            // For_TextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 141);
            Controls.Add(labelResultado);
            Controls.Add(textBox1);
            Controls.Add(labelTitulo);
            Name = "For_TextBox";
            Text = "For_TextBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox textBox1;
        private Label labelResultado;
    }
}
namespace Taller2ControlesWinForms
{
    partial class For_ListView
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
            listView1 = new ListView();
            Numero = new ColumnHeader();
            Multiplo = new ColumnHeader();
            Resultado = new ColumnHeader();
            buttonHacer = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(16, 12);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(246, 50);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Hago una tabla de multiplicar\nIngresa un número";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 13F);
            textBox1.Location = new Point(16, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 31);
            textBox1.TabIndex = 1;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Numero, Multiplo, Resultado });
            listView1.Location = new Point(16, 137);
            listView1.Name = "listView1";
            listView1.Size = new Size(246, 236);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Numero
            // 
            Numero.Text = "Número";
            // 
            // Multiplo
            // 
            Multiplo.Text = "Multiplo";
            // 
            // Resultado
            // 
            Resultado.Text = "Resultado";
            Resultado.Width = 80;
            // 
            // buttonHacer
            // 
            buttonHacer.Font = new Font("Segoe UI", 13F);
            buttonHacer.Location = new Point(135, 82);
            buttonHacer.Name = "buttonHacer";
            buttonHacer.Size = new Size(127, 38);
            buttonHacer.TabIndex = 3;
            buttonHacer.Text = "Hacer";
            buttonHacer.UseVisualStyleBackColor = true;
            buttonHacer.Click += buttonHacer_Click;
            // 
            // For_ListView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 378);
            Controls.Add(buttonHacer);
            Controls.Add(listView1);
            Controls.Add(textBox1);
            Controls.Add(labelTitulo);
            Name = "For_ListView";
            Text = "For_ListView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private TextBox textBox1;
        private ListView listView1;
        private Button buttonHacer;
        private ColumnHeader Numero;
        private ColumnHeader Multiplo;
        private ColumnHeader Resultado;
    }
}
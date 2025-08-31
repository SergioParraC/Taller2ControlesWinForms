namespace Taller2ControlesWinForms
{
    partial class For_DataGridView
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
            dataGridViewTabla = new DataGridView();
            textBoxInput = new TextBox();
            labelNumero = new Label();
            buttonHacer = new Button();
            labelTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTabla
            // 
            dataGridViewTabla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTabla.Location = new Point(12, 140);
            dataGridViewTabla.Name = "dataGridViewTabla";
            dataGridViewTabla.Size = new Size(325, 314);
            dataGridViewTabla.TabIndex = 0;
            // 
            // textBoxInput
            // 
            textBoxInput.Font = new Font("Segoe UI", 13F);
            textBoxInput.Location = new Point(27, 81);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 31);
            textBoxInput.TabIndex = 1;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Segoe UI", 13F);
            labelNumero.Location = new Point(27, 34);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(162, 25);
            labelNumero.TabIndex = 2;
            labelNumero.Text = "Ingresa un número";
            // 
            // buttonHacer
            // 
            buttonHacer.Font = new Font("Segoe UI", 13F);
            buttonHacer.Location = new Point(167, 75);
            buttonHacer.Name = "buttonHacer";
            buttonHacer.Size = new Size(119, 45);
            buttonHacer.TabIndex = 3;
            buttonHacer.Text = "Hacer";
            buttonHacer.UseVisualStyleBackColor = true;
            buttonHacer.Click += buttonHacer_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(27, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(246, 25);
            labelTitulo.TabIndex = 4;
            labelTitulo.Text = "Hago una tabla de multiplicar";
            // 
            // For_DataGridView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 466);
            Controls.Add(labelTitulo);
            Controls.Add(buttonHacer);
            Controls.Add(labelNumero);
            Controls.Add(textBoxInput);
            Controls.Add(dataGridViewTabla);
            Name = "For_DataGridView";
            Text = "For_DataGridView";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTabla;
        private TextBox textBoxInput;
        private Label labelNumero;
        private Button buttonHacer;
        private Label labelTitulo;
    }
}
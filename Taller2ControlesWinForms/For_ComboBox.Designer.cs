namespace Taller2ControlesWinForms
{
    partial class For_ComboBox
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
            comboBox1 = new ComboBox();
            labelTitulo = new Label();
            labelTitulo2 = new Label();
            labelOpcionSeleccionada = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Opción 1", "Opción 2", "Opción 3", "Opción 4", "Opción 5", "Opción 6", "Opción 7", "Opción 8", "Opción 9", "Opción 10" });
            comboBox1.Location = new Point(12, 53);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 23);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(12, 18);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(256, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Seleccione una de las opciones";
            // 
            // labelTitulo2
            // 
            labelTitulo2.AutoSize = true;
            labelTitulo2.Font = new Font("Segoe UI", 13F);
            labelTitulo2.Location = new Point(12, 93);
            labelTitulo2.Name = "labelTitulo2";
            labelTitulo2.Size = new Size(149, 25);
            labelTitulo2.TabIndex = 2;
            labelTitulo2.Text = "Usted seleccionó:";
            // 
            // labelOpcionSeleccionada
            // 
            labelOpcionSeleccionada.AutoSize = true;
            labelOpcionSeleccionada.Font = new Font("Segoe UI", 13F);
            labelOpcionSeleccionada.Location = new Point(18, 132);
            labelOpcionSeleccionada.Name = "labelOpcionSeleccionada";
            labelOpcionSeleccionada.Size = new Size(0, 25);
            labelOpcionSeleccionada.TabIndex = 3;
            // 
            // For_ComboBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(273, 181);
            Controls.Add(labelOpcionSeleccionada);
            Controls.Add(labelTitulo2);
            Controls.Add(labelTitulo);
            Controls.Add(comboBox1);
            Name = "For_ComboBox";
            Text = "For_ColorDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label labelTitulo;
        private Label labelTitulo2;
        private Label labelOpcionSeleccionada;
    }
}
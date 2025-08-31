namespace Taller2ControlesWinForms
{
    partial class For_DateTimePicker
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
            dateTimePicker1 = new DateTimePicker();
            labelTitulo = new Label();
            labelFecha = new Label();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 13F);
            dateTimePicker1.Location = new Point(23, 62);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(29, 20);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(179, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Seleccione una fecha:";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 13F);
            labelFecha.Location = new Point(23, 247);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(185, 25);
            labelFecha.TabIndex = 2;
            labelFecha.Text = "Aquí muestro la fecha";
            // 
            // For_DateTimePicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 275);
            Controls.Add(labelFecha);
            Controls.Add(labelTitulo);
            Controls.Add(dateTimePicker1);
            Name = "For_DateTimePicker";
            Text = "For_DateTimePicker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Label labelTitulo;
        private Label labelFecha;
    }
}
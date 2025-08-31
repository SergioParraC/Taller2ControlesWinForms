namespace Taller2ControlesWinForms
{
    partial class For_MonthCalendar
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
            monthCalendar1 = new MonthCalendar();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(49, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(175, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Selecciona una fecha";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(23, 43);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 1;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 13F);
            labelResultado.Location = new Point(12, 214);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(256, 25);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "Acá se ve la fecha seleccionada";
            // 
            // For_MonthCalendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(278, 282);
            Controls.Add(labelResultado);
            Controls.Add(monthCalendar1);
            Controls.Add(labelTitulo);
            Name = "For_MonthCalendar";
            Text = "For_MonthCalendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private MonthCalendar monthCalendar1;
        private Label labelResultado;
    }
}
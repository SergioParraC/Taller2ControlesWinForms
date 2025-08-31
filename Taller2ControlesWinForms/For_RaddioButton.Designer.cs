namespace Taller2ControlesWinForms
{
    partial class For_RaddioButton
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
            panel1 = new Panel();
            radioButtonOpcion5 = new RadioButton();
            radioButtonOpcion4 = new RadioButton();
            radioButtonOpcion3 = new RadioButton();
            radioButtonOpcion2 = new RadioButton();
            radioButtonOpcion1 = new RadioButton();
            labelTitulo = new Label();
            labelOpcion = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(radioButtonOpcion5);
            panel1.Controls.Add(radioButtonOpcion4);
            panel1.Controls.Add(radioButtonOpcion3);
            panel1.Controls.Add(radioButtonOpcion2);
            panel1.Controls.Add(radioButtonOpcion1);
            panel1.Location = new Point(12, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(118, 151);
            panel1.TabIndex = 0;
            // 
            // radioButtonOpcion5
            // 
            radioButtonOpcion5.AutoSize = true;
            radioButtonOpcion5.Location = new Point(20, 113);
            radioButtonOpcion5.Name = "radioButtonOpcion5";
            radioButtonOpcion5.Size = new Size(73, 19);
            radioButtonOpcion5.TabIndex = 4;
            radioButtonOpcion5.TabStop = true;
            radioButtonOpcion5.Text = "Opción 5";
            radioButtonOpcion5.UseVisualStyleBackColor = true;
            radioButtonOpcion5.CheckedChanged += radioButtonOpcion5_CheckedChanged;
            // 
            // radioButtonOpcion4
            // 
            radioButtonOpcion4.AutoSize = true;
            radioButtonOpcion4.Location = new Point(20, 88);
            radioButtonOpcion4.Name = "radioButtonOpcion4";
            radioButtonOpcion4.Size = new Size(73, 19);
            radioButtonOpcion4.TabIndex = 3;
            radioButtonOpcion4.TabStop = true;
            radioButtonOpcion4.Text = "Opción 4";
            radioButtonOpcion4.UseVisualStyleBackColor = true;
            radioButtonOpcion4.CheckedChanged += radioButtonOpcion4_CheckedChanged;
            // 
            // radioButtonOpcion3
            // 
            radioButtonOpcion3.AutoSize = true;
            radioButtonOpcion3.Location = new Point(20, 63);
            radioButtonOpcion3.Name = "radioButtonOpcion3";
            radioButtonOpcion3.Size = new Size(73, 19);
            radioButtonOpcion3.TabIndex = 2;
            radioButtonOpcion3.TabStop = true;
            radioButtonOpcion3.Text = "Opción 3";
            radioButtonOpcion3.UseVisualStyleBackColor = true;
            radioButtonOpcion3.CheckedChanged += radioButtonOpcion3_CheckedChanged;
            // 
            // radioButtonOpcion2
            // 
            radioButtonOpcion2.AutoSize = true;
            radioButtonOpcion2.Location = new Point(20, 38);
            radioButtonOpcion2.Name = "radioButtonOpcion2";
            radioButtonOpcion2.Size = new Size(73, 19);
            radioButtonOpcion2.TabIndex = 1;
            radioButtonOpcion2.TabStop = true;
            radioButtonOpcion2.Text = "Opción 2";
            radioButtonOpcion2.UseVisualStyleBackColor = true;
            radioButtonOpcion2.CheckedChanged += radioButtonOpcion2_CheckedChanged;
            // 
            // radioButtonOpcion1
            // 
            radioButtonOpcion1.AutoSize = true;
            radioButtonOpcion1.Location = new Point(20, 13);
            radioButtonOpcion1.Name = "radioButtonOpcion1";
            radioButtonOpcion1.Size = new Size(70, 19);
            radioButtonOpcion1.TabIndex = 0;
            radioButtonOpcion1.TabStop = true;
            radioButtonOpcion1.Text = "Opción1";
            radioButtonOpcion1.UseVisualStyleBackColor = true;
            radioButtonOpcion1.CheckedChanged += radioButtonOpcion1_CheckedChanged;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(15, 6);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(188, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Seleccione una opción";
            // 
            // labelOpcion
            // 
            labelOpcion.AutoSize = true;
            labelOpcion.Font = new Font("Segoe UI", 13F);
            labelOpcion.Location = new Point(12, 208);
            labelOpcion.Name = "labelOpcion";
            labelOpcion.Size = new Size(270, 25);
            labelOpcion.TabIndex = 2;
            labelOpcion.Text = "Acá veras la opción seleccionada";
            // 
            // For_RaddioButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(289, 236);
            Controls.Add(labelOpcion);
            Controls.Add(labelTitulo);
            Controls.Add(panel1);
            Name = "For_RaddioButton";
            Text = "For_RaddioButton";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelTitulo;
        private RadioButton radioButtonOpcion5;
        private RadioButton radioButtonOpcion4;
        private RadioButton radioButtonOpcion3;
        private RadioButton radioButtonOpcion2;
        private RadioButton radioButtonOpcion1;
        private Label labelOpcion;
    }
}
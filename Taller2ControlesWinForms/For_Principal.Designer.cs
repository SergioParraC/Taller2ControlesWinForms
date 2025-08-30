namespace Taller2ControlesWinForms
{
    partial class For_Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonBoton = new Button();
            labelTitulo = new Label();
            buttonLabel = new Button();
            SuspendLayout();
            // 
            // buttonBoton
            // 
            buttonBoton.Location = new Point(12, 52);
            buttonBoton.Name = "buttonBoton";
            buttonBoton.Size = new Size(93, 27);
            buttonBoton.TabIndex = 0;
            buttonBoton.Text = "Botón";
            buttonBoton.UseVisualStyleBackColor = true;
            buttonBoton.Click += buttonBoton_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 16F);
            labelTitulo.Location = new Point(13, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(446, 30);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Solución taller Controles de WinForms en C#";
            // 
            // buttonLabel
            // 
            buttonLabel.Location = new Point(123, 52);
            buttonLabel.Name = "buttonLabel";
            buttonLabel.Size = new Size(93, 27);
            buttonLabel.TabIndex = 2;
            buttonLabel.Text = "Label";
            buttonLabel.UseVisualStyleBackColor = true;
            // 
            // For_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 452);
            Controls.Add(buttonLabel);
            Controls.Add(labelTitulo);
            Controls.Add(buttonBoton);
            Name = "For_Principal";
            Text = "Solución taller Controles WinForms";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonBoton;
        private Label labelTitulo;
        private Button buttonLabel;
    }
}

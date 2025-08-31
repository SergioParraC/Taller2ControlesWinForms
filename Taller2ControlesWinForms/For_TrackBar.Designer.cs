namespace Taller2ControlesWinForms
{
    partial class For_TrackBar
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
            trackBar1 = new TrackBar();
            labelTitulo = new Label();
            labelResultado = new Label();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(12, 46);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(385, 45);
            trackBar1.TabIndex = 0;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(116, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(190, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Mueve la barra inferior";
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Font = new Font("Segoe UI", 13F);
            labelResultado.Location = new Point(114, 93);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(198, 25);
            labelResultado.TabIndex = 2;
            labelResultado.Text = "El valor se mostrará acá";
            // 
            // For_TrackBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 139);
            Controls.Add(labelResultado);
            Controls.Add(labelTitulo);
            Controls.Add(trackBar1);
            Name = "For_TrackBar";
            Text = "For_TrackBar";
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trackBar1;
        private Label labelTitulo;
        private Label labelResultado;
    }
}
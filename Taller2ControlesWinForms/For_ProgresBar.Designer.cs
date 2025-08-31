namespace Taller2ControlesWinForms
{
    partial class For_ProgresBar
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
            hScrollBar1 = new HScrollBar();
            progressBar1 = new ProgressBar();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(14, 57);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(576, 24);
            hScrollBar1.TabIndex = 0;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(14, 93);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(576, 20);
            progressBar1.TabIndex = 1;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(19, 13);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(129, 25);
            labelTitulo.TabIndex = 2;
            labelTitulo.Text = "Mueve la barra";
            // 
            // For_ProgresBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 134);
            Controls.Add(labelTitulo);
            Controls.Add(progressBar1);
            Controls.Add(hScrollBar1);
            Name = "For_ProgresBar";
            Text = "For_ProgresBar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HScrollBar hScrollBar1;
        private ProgressBar progressBar1;
        private Label labelTitulo;
    }
}
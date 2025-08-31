namespace Taller2ControlesWinForms
{
    partial class For_ScrollBar
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
            labelTexto = new Label();
            SuspendLayout();
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(20, 14);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(286, 21);
            hScrollBar1.TabIndex = 0;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Segoe UI", 13F);
            labelTexto.Location = new Point(20, 54);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(288, 25);
            labelTexto.TabIndex = 1;
            labelTexto.Text = "Mueve la barra y acá estará el valor";
            // 
            // For_ScrollBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 92);
            Controls.Add(labelTexto);
            Controls.Add(hScrollBar1);
            Name = "For_ScrollBar";
            Text = "For_ScrollBar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HScrollBar hScrollBar1;
        private Label labelTexto;
    }
}
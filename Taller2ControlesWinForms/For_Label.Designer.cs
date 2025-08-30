namespace Taller2ControlesWinForms
{
    partial class For_Label
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
            labelTexto = new Label();
            SuspendLayout();
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Location = new Point(12, 9);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(439, 15);
            labelTexto.TabIndex = 0;
            labelTexto.Text = "Este label solo muestra texto, pero si pasa con el mouse cambia de color otro label";
            // 
            // For_Label
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 102);
            Controls.Add(labelTexto);
            Name = "For_Label";
            Text = "For_Label";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTexto;
    }
}
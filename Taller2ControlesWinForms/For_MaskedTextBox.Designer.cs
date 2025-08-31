namespace Taller2ControlesWinForms
{
    partial class For_MaskedTextBox
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
            labelTotilo = new Label();
            maskedTextBox1 = new MaskedTextBox();
            SuspendLayout();
            // 
            // labelTotilo
            // 
            labelTotilo.AutoSize = true;
            labelTotilo.Font = new Font("Segoe UI", 13F);
            labelTotilo.Location = new Point(15, 13);
            labelTotilo.Name = "labelTotilo";
            labelTotilo.Size = new Size(250, 25);
            labelTotilo.TabIndex = 0;
            labelTotilo.Text = "Ingreesa tu número telefonico";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Font = new Font("Segoe UI", 13F);
            maskedTextBox1.Location = new Point(25, 50);
            maskedTextBox1.Mask = "000-000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(188, 31);
            maskedTextBox1.TabIndex = 1;
            // 
            // For_MaskedTextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 106);
            Controls.Add(maskedTextBox1);
            Controls.Add(labelTotilo);
            Name = "For_MaskedTextBox";
            Text = "For_MaskedTextBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTotilo;
        private MaskedTextBox maskedTextBox1;
    }
}
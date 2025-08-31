namespace Taller2ControlesWinForms
{
    partial class For_NumericPuDown
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
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            labelValor = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 1;
            numericUpDown1.Font = new Font("Segoe UI", 13F);
            numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            numericUpDown1.Location = new Point(26, 50);
            numericUpDown1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(116, 31);
            numericUpDown1.TabIndex = 0;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(26, 11);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 1;
            label1.Text = "Cambia el valor";
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Segoe UI", 13F);
            labelValor.Location = new Point(26, 107);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(188, 25);
            labelValor.TabIndex = 2;
            labelValor.Text = "Acá vez el nuevo valor";
            // 
            // For_NumericPuDown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(245, 161);
            Controls.Add(labelValor);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Name = "For_NumericPuDown";
            Text = "For_NumericPuDown";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label labelValor;
    }
}
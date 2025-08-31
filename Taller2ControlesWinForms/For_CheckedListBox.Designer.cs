namespace Taller2ControlesWinForms
{
    partial class For_CheckedListBox
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
            checkedListBox1 = new CheckedListBox();
            labelListado = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(10, 6);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(208, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Selecciona los Check Box";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 13F);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Opción 1", "Opción 2", "Opción 3", "Opción 4", "Opción 5", "Opción 6", "Opción 7", "Opción 8", "Opción 9", "Opción 10" });
            checkedListBox1.Location = new Point(21, 49);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(187, 264);
            checkedListBox1.TabIndex = 1;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // labelListado
            // 
            labelListado.AutoSize = true;
            labelListado.Font = new Font("Segoe UI", 13F);
            labelListado.Location = new Point(214, 49);
            labelListado.Name = "labelListado";
            labelListado.Size = new Size(69, 25);
            labelListado.TabIndex = 2;
            labelListado.Text = "Listado";
            // 
            // For_CheckedListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(535, 378);
            Controls.Add(labelListado);
            Controls.Add(checkedListBox1);
            Controls.Add(labelTitulo);
            Name = "For_CheckedListBox";
            Text = "For_CheckedListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private CheckedListBox checkedListBox1;
        private Label labelListado;
    }
}
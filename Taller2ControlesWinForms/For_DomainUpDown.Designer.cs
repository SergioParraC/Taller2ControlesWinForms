namespace Taller2ControlesWinForms
{
    partial class For_DomainUpDown
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
            domainUpDown1 = new DomainUpDown();
            labelTitulo = new Label();
            labelSeleccion = new Label();
            SuspendLayout();
            // 
            // domainUpDown1
            // 
            domainUpDown1.Font = new Font("Segoe UI", 13F);
            domainUpDown1.Items.Add("Opción 1");
            domainUpDown1.Items.Add("Opción 2");
            domainUpDown1.Items.Add("Opción 3");
            domainUpDown1.Items.Add("Opción 4");
            domainUpDown1.Items.Add("Opción 5");
            domainUpDown1.Location = new Point(12, 79);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(135, 31);
            domainUpDown1.TabIndex = 0;
            domainUpDown1.Text = "Seleccioname";
            domainUpDown1.Wrap = true;
            domainUpDown1.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(21, 23);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(167, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Selecciona un valor:";
            // 
            // labelSeleccion
            // 
            labelSeleccion.AutoSize = true;
            labelSeleccion.Font = new Font("Segoe UI", 13F);
            labelSeleccion.Location = new Point(12, 134);
            labelSeleccion.Name = "labelSeleccion";
            labelSeleccion.Size = new Size(175, 50);
            labelSeleccion.TabIndex = 2;
            labelSeleccion.Text = "Acá está el valor que\nseleccionaste";
            // 
            // For_DomainUpDown
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(205, 207);
            Controls.Add(labelSeleccion);
            Controls.Add(labelTitulo);
            Controls.Add(domainUpDown1);
            Name = "For_DomainUpDown";
            Text = "For_DomainUpDown";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown domainUpDown1;
        private Label labelTitulo;
        private Label labelSeleccion;
    }
}
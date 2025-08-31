namespace Taller2ControlesWinForms
{
    partial class For_CheckBox
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
            checkBoxElemento = new CheckBox();
            labelSeleccionActiva = new Label();
            labelSeleccionDesactivado = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(19, 14);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(341, 25);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "Selecciona y des selecciona este checkBox";
            // 
            // checkBoxElemento
            // 
            checkBoxElemento.AutoSize = true;
            checkBoxElemento.Font = new Font("Segoe UI", 13F);
            checkBoxElemento.Location = new Point(96, 55);
            checkBoxElemento.Name = "checkBoxElemento";
            checkBoxElemento.Size = new Size(138, 29);
            checkBoxElemento.TabIndex = 1;
            checkBoxElemento.Text = "Seleccioname";
            checkBoxElemento.UseVisualStyleBackColor = true;
            checkBoxElemento.CheckStateChanged += checkBox_CheckStateChanged;
            // 
            // labelSeleccionActiva
            // 
            labelSeleccionActiva.AutoSize = true;
            labelSeleccionActiva.Font = new Font("Segoe UI", 13F);
            labelSeleccionActiva.Location = new Point(48, 101);
            labelSeleccionActiva.Name = "labelSeleccionActiva";
            labelSeleccionActiva.Size = new Size(0, 25);
            labelSeleccionActiva.TabIndex = 2;
            // 
            // labelSeleccionDesactivado
            // 
            labelSeleccionDesactivado.AutoSize = true;
            labelSeleccionDesactivado.Font = new Font("Segoe UI", 13F);
            labelSeleccionDesactivado.ForeColor = Color.Red;
            labelSeleccionDesactivado.Location = new Point(30, 136);
            labelSeleccionDesactivado.Name = "labelSeleccionDesactivado";
            labelSeleccionDesactivado.Size = new Size(287, 25);
            labelSeleccionDesactivado.TabIndex = 3;
            labelSeleccionDesactivado.Text = "El Check Box NO está seleccionado";
            // 
            // For_CheckBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(377, 182);
            Controls.Add(labelSeleccionDesactivado);
            Controls.Add(labelSeleccionActiva);
            Controls.Add(checkBoxElemento);
            Controls.Add(labelTitulo);
            Name = "For_CheckBox";
            Text = "For_CheckBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private CheckBox checkBoxElemento;
        private Label labelSeleccionActiva;
        private Label labelSeleccionDesactivado;
    }
}
namespace Taller2ControlesWinForms
{
    partial class For_ListBox
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
            listBoxIzquierda = new ListBox();
            listBoxDerecha = new ListBox();
            buttonDrecha = new Button();
            buttonIzquierda = new Button();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // listBoxIzquierda
            // 
            listBoxIzquierda.FormattingEnabled = true;
            listBoxIzquierda.ItemHeight = 15;
            listBoxIzquierda.Items.AddRange(new object[] { "Elemento 1 derecha", "Elemento 2 derecha", "Elemento 3 derecha", "Elemento 4 derecha", "Elemento 5 derecha", "Elemento 6 derecha", "Elemento 7 derecha" });
            listBoxIzquierda.Location = new Point(16, 51);
            listBoxIzquierda.Name = "listBoxIzquierda";
            listBoxIzquierda.Size = new Size(129, 169);
            listBoxIzquierda.TabIndex = 0;
            // 
            // listBoxDerecha
            // 
            listBoxDerecha.FormattingEnabled = true;
            listBoxDerecha.ItemHeight = 15;
            listBoxDerecha.Items.AddRange(new object[] { "Elemento 11 izquieda", "Elemento 12 izquieda", "Elemento 13 izquieda", "Elemento 14 izquieda", "Elemento 15 izquieda", "Elemento 16 izquieda", "Elemento 17 izquieda" });
            listBoxDerecha.Location = new Point(318, 51);
            listBoxDerecha.Name = "listBoxDerecha";
            listBoxDerecha.Size = new Size(127, 169);
            listBoxDerecha.TabIndex = 1;
            // 
            // buttonDrecha
            // 
            buttonDrecha.Location = new Point(159, 55);
            buttonDrecha.Name = "buttonDrecha";
            buttonDrecha.Size = new Size(142, 23);
            buttonDrecha.TabIndex = 2;
            buttonDrecha.Text = "Mover a la derecha >>";
            buttonDrecha.UseVisualStyleBackColor = true;
            buttonDrecha.Click += buttonDrecha_Click;
            // 
            // buttonIzquierda
            // 
            buttonIzquierda.Location = new Point(159, 98);
            buttonIzquierda.Name = "buttonIzquierda";
            buttonIzquierda.Size = new Size(142, 23);
            buttonIzquierda.TabIndex = 3;
            buttonIzquierda.Text = "<< Mover a la izquierda";
            buttonIzquierda.UseVisualStyleBackColor = true;
            buttonIzquierda.Click += buttonIzquierda_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(21, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(268, 25);
            labelTitulo.TabIndex = 4;
            labelTitulo.Text = "Selecciona un elemento a mover";
            // 
            // For_ListBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 237);
            Controls.Add(labelTitulo);
            Controls.Add(buttonIzquierda);
            Controls.Add(buttonDrecha);
            Controls.Add(listBoxDerecha);
            Controls.Add(listBoxIzquierda);
            Name = "For_ListBox";
            Text = "For_ListBox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxIzquierda;
        private ListBox listBoxDerecha;
        private Button buttonDrecha;
        private Button buttonIzquierda;
        private Label labelTitulo;
    }
}
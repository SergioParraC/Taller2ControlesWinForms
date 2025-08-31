namespace Taller2ControlesWinForms
{
    partial class For_ToolTip
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            labelTitulo = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 13F);
            button1.Location = new Point(59, 44);
            button1.Name = "button1";
            button1.Size = new Size(168, 46);
            button1.TabIndex = 0;
            button1.Text = "Pasame";
            toolTip1.SetToolTip(button1, "Esto es un cuadro de información");
            button1.UseVisualStyleBackColor = true;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(15, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(255, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Deja el puntero sobre el botón";
            // 
            // For_ToolTip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 115);
            Controls.Add(labelTitulo);
            Controls.Add(button1);
            Name = "For_ToolTip";
            Text = "For_ToolTip";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ToolTip toolTip1;
        private Label labelTitulo;
    }
}
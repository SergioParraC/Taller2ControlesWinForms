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
            labelColor = new Label();
            linkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // labelTexto
            // 
            labelTexto.AutoSize = true;
            labelTexto.Font = new Font("Segoe UI", 13F);
            labelTexto.Location = new Point(12, 9);
            labelTexto.Name = "labelTexto";
            labelTexto.Size = new Size(286, 75);
            labelTexto.TabIndex = 0;
            labelTexto.Text = "Este label solo muestra texto,\npero si pasa con el mouse cambia \nde color otro label";
            labelTexto.MouseLeave += labelTexto_MouseLeave;
            labelTexto.MouseHover += labelTexto_MouseHover;
            // 
            // labelColor
            // 
            labelColor.AutoSize = true;
            labelColor.Font = new Font("Segoe UI", 13F);
            labelColor.Location = new Point(12, 104);
            labelColor.Name = "labelColor";
            labelColor.Size = new Size(218, 25);
            labelColor.TabIndex = 1;
            labelColor.Text = "Este label cambia de color";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Font = new Font("Segoe UI", 13F);
            linkLabel.Location = new Point(12, 155);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new Size(237, 25);
            linkLabel.TabIndex = 2;
            linkLabel.TabStop = true;
            linkLabel.Text = "Este label cierra esta ventana";
            linkLabel.LinkClicked += linkLabel_LinkClicked;
            // 
            // For_Label
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 232);
            Controls.Add(linkLabel);
            Controls.Add(labelColor);
            Controls.Add(labelTexto);
            Name = "For_Label";
            Text = "For_Label";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTexto;
        private Label labelColor;
        private LinkLabel linkLabel;
    }
}
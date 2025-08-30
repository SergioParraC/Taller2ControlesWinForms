namespace Taller2ControlesWinForms
{
    partial class For_Boton
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
            button1 = new Button();
            labelClick = new Label();
            labelPasaMouse = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(11, 12);
            button1.Name = "button1";
            button1.Size = new Size(183, 23);
            button1.TabIndex = 0;
            button1.Text = "Pesiona o pasa sobre el boton";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.MouseLeave += button1_MouseLeave;
            button1.MouseHover += button1_MouseHover;
            // 
            // labelClick
            // 
            labelClick.AutoSize = true;
            labelClick.Location = new Point(12, 49);
            labelClick.Name = "labelClick";
            labelClick.Size = new Size(0, 15);
            labelClick.TabIndex = 1;
            // 
            // labelPasaMouse
            // 
            labelPasaMouse.AutoSize = true;
            labelPasaMouse.BackColor = SystemColors.Control;
            labelPasaMouse.ForeColor = Color.Black;
            labelPasaMouse.Location = new Point(12, 83);
            labelPasaMouse.Name = "labelPasaMouse";
            labelPasaMouse.Size = new Size(154, 30);
            labelPasaMouse.TabIndex = 2;
            labelPasaMouse.Text = "Si pasas sobre el boton este \nstexto cambia de color";
            // 
            // For_Boton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(207, 134);
            Controls.Add(labelPasaMouse);
            Controls.Add(labelClick);
            Controls.Add(button1);
            Name = "For_Boton";
            Text = "For_Boton";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label labelClick;
        private Label labelPasaMouse;
    }
}
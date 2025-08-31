namespace Taller2ControlesWinForms
{
    partial class For_StatusStrip
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
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            labelTitulo = new Label();
            button1 = new Button();
            button2 = new Button();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 102);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(262, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(111, 17);
            toolStripStatusLabel1.Text = "Aquí mostraré texto";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(18, 10);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(226, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Da click en cualquier botón";
            // 
            // button1
            // 
            button1.Location = new Point(18, 38);
            button1.Name = "button1";
            button1.Size = new Size(104, 23);
            button1.TabIndex = 2;
            button1.Text = "Primer boton";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(18, 67);
            button2.Name = "button2";
            button2.Size = new Size(104, 23);
            button2.TabIndex = 3;
            button2.Text = "Segundo boton";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // For_StatusStrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 124);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelTitulo);
            Controls.Add(statusStrip1);
            Name = "For_StatusStrip";
            Text = "For_StatusStrip";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private Label labelTitulo;
        private Button button1;
        private Button button2;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
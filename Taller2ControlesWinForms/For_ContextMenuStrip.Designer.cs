namespace Taller2ControlesWinForms
{
    partial class For_ContextMenuStrip
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            opción1ToolStripMenuItem = new ToolStripMenuItem();
            opción2ToolStripMenuItem = new ToolStripMenuItem();
            hija1Opción2ToolStripMenuItem = new ToolStripMenuItem();
            hija2Opción2ToolStripMenuItem = new ToolStripMenuItem();
            hija21Opción2ToolStripMenuItem = new ToolStripMenuItem();
            hija3Opción2ToolStripMenuItem = new ToolStripMenuItem();
            opción3ToolStripMenuItem = new ToolStripMenuItem();
            hija1Opción3ToolStripMenuItem = new ToolStripMenuItem();
            opción4ToolStripMenuItem = new ToolStripMenuItem();
            labelTitulo = new Label();
            labelOpcion = new Label();
            buttonClick = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { opción1ToolStripMenuItem, opción2ToolStripMenuItem, opción3ToolStripMenuItem, opción4ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.Size = new Size(123, 92);
            // 
            // opción1ToolStripMenuItem
            // 
            opción1ToolStripMenuItem.Name = "opción1ToolStripMenuItem";
            opción1ToolStripMenuItem.Size = new Size(122, 22);
            opción1ToolStripMenuItem.Text = "Opción 1";
            opción1ToolStripMenuItem.Click += opción1ToolStripMenuItem_Click;
            // 
            // opción2ToolStripMenuItem
            // 
            opción2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hija1Opción2ToolStripMenuItem, hija2Opción2ToolStripMenuItem, hija3Opción2ToolStripMenuItem });
            opción2ToolStripMenuItem.Name = "opción2ToolStripMenuItem";
            opción2ToolStripMenuItem.Size = new Size(122, 22);
            opción2ToolStripMenuItem.Text = "Opción 2";
            // 
            // hija1Opción2ToolStripMenuItem
            // 
            hija1Opción2ToolStripMenuItem.Name = "hija1Opción2ToolStripMenuItem";
            hija1Opción2ToolStripMenuItem.Size = new Size(155, 22);
            hija1Opción2ToolStripMenuItem.Text = "Hija 1 Opción 2";
            hija1Opción2ToolStripMenuItem.Click += hija1Opción2ToolStripMenuItem_Click;
            // 
            // hija2Opción2ToolStripMenuItem
            // 
            hija2Opción2ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hija21Opción2ToolStripMenuItem });
            hija2Opción2ToolStripMenuItem.Name = "hija2Opción2ToolStripMenuItem";
            hija2Opción2ToolStripMenuItem.Size = new Size(155, 22);
            hija2Opción2ToolStripMenuItem.Text = "Hija 2 Opción 2";
            // 
            // hija21Opción2ToolStripMenuItem
            // 
            hija21Opción2ToolStripMenuItem.Name = "hija21Opción2ToolStripMenuItem";
            hija21Opción2ToolStripMenuItem.Size = new Size(166, 22);
            hija21Opción2ToolStripMenuItem.Text = "Hija 2-1 Opción 2";
            hija21Opción2ToolStripMenuItem.Click += hija21Opción2ToolStripMenuItem_Click;
            // 
            // hija3Opción2ToolStripMenuItem
            // 
            hija3Opción2ToolStripMenuItem.Name = "hija3Opción2ToolStripMenuItem";
            hija3Opción2ToolStripMenuItem.Size = new Size(155, 22);
            hija3Opción2ToolStripMenuItem.Text = "Hija 3 Opción 2";
            hija3Opción2ToolStripMenuItem.Click += hija3Opción2ToolStripMenuItem_Click;
            // 
            // opción3ToolStripMenuItem
            // 
            opción3ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hija1Opción3ToolStripMenuItem });
            opción3ToolStripMenuItem.Name = "opción3ToolStripMenuItem";
            opción3ToolStripMenuItem.Size = new Size(122, 22);
            opción3ToolStripMenuItem.Text = "Opción 3";
            // 
            // hija1Opción3ToolStripMenuItem
            // 
            hija1Opción3ToolStripMenuItem.Name = "hija1Opción3ToolStripMenuItem";
            hija1Opción3ToolStripMenuItem.Size = new Size(155, 22);
            hija1Opción3ToolStripMenuItem.Text = "Hija 1 Opción 3";
            hija1Opción3ToolStripMenuItem.Click += hija1Opción3ToolStripMenuItem_Click;
            // 
            // opción4ToolStripMenuItem
            // 
            opción4ToolStripMenuItem.Name = "opción4ToolStripMenuItem";
            opción4ToolStripMenuItem.Size = new Size(122, 22);
            opción4ToolStripMenuItem.Text = "Opción 4";
            opción4ToolStripMenuItem.Click += opción4ToolStripMenuItem_Click;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(29, 193);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(298, 75);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Despliega y selecciona una opción,\nel siguiente texto indica cual opción \nseleccionasste";
            // 
            // labelOpcion
            // 
            labelOpcion.AutoSize = true;
            labelOpcion.Font = new Font("Segoe UI", 13F);
            labelOpcion.Location = new Point(45, 281);
            labelOpcion.Name = "labelOpcion";
            labelOpcion.Size = new Size(85, 25);
            labelOpcion.TabIndex = 2;
            labelOpcion.Text = "Selección";
            // 
            // buttonClick
            // 
            buttonClick.Font = new Font("Segoe UI", 13F);
            buttonClick.Location = new Point(25, 17);
            buttonClick.Name = "buttonClick";
            buttonClick.Size = new Size(285, 104);
            buttonClick.TabIndex = 3;
            buttonClick.Text = "Dame click";
            buttonClick.UseVisualStyleBackColor = true;
            buttonClick.Click += buttonClick_Click;
            // 
            // For_ContextMenuStrip
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 334);
            Controls.Add(buttonClick);
            Controls.Add(labelOpcion);
            Controls.Add(labelTitulo);
            Name = "For_ContextMenuStrip";
            Text = "For_ContextMenuStrip";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem opción1ToolStripMenuItem;
        private ToolStripMenuItem opción2ToolStripMenuItem;
        private ToolStripMenuItem hija1Opción2ToolStripMenuItem;
        private ToolStripMenuItem hija2Opción2ToolStripMenuItem;
        private ToolStripMenuItem hija21Opción2ToolStripMenuItem;
        private ToolStripMenuItem hija3Opción2ToolStripMenuItem;
        private ToolStripMenuItem opción3ToolStripMenuItem;
        private ToolStripMenuItem hija1Opción3ToolStripMenuItem;
        private ToolStripMenuItem opción4ToolStripMenuItem;
        private Label labelTitulo;
        private Label labelOpcion;
        private Button buttonClick;
    }
}
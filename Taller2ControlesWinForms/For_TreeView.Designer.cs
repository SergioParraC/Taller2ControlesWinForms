namespace Taller2ControlesWinForms
{
    partial class For_TreeView
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
            TreeNode treeNode1 = new TreeNode("Introducción");
            TreeNode treeNode2 = new TreeNode("Portada");
            TreeNode treeNode3 = new TreeNode("Titulo");
            TreeNode treeNode4 = new TreeNode("Presentación", new TreeNode[] { treeNode1, treeNode2, treeNode3 });
            TreeNode treeNode5 = new TreeNode("Objetivo General");
            TreeNode treeNode6 = new TreeNode("Objetivo 1");
            TreeNode treeNode7 = new TreeNode("Objetivo 2");
            TreeNode treeNode8 = new TreeNode("Objetivo 3");
            TreeNode treeNode9 = new TreeNode("Objetivos Especificos", new TreeNode[] { treeNode6, treeNode7, treeNode8 });
            TreeNode treeNode10 = new TreeNode("Objetivos", new TreeNode[] { treeNode5, treeNode9 });
            TreeNode treeNode11 = new TreeNode("Marco de referencia");
            TreeNode treeNode12 = new TreeNode("Marco Legal");
            TreeNode treeNode13 = new TreeNode("Tema 1");
            TreeNode treeNode14 = new TreeNode("Sub tema 1");
            TreeNode treeNode15 = new TreeNode("Sub tema 2");
            TreeNode treeNode16 = new TreeNode("Tema 2", new TreeNode[] { treeNode14, treeNode15 });
            TreeNode treeNode17 = new TreeNode("Tema 3");
            TreeNode treeNode18 = new TreeNode("Marco teórico", new TreeNode[] { treeNode13, treeNode16, treeNode17 });
            TreeNode treeNode19 = new TreeNode("Proyecto", new TreeNode[] { treeNode10, treeNode11, treeNode12, treeNode18 });
            TreeNode treeNode20 = new TreeNode("Inicio", new TreeNode[] { treeNode4, treeNode19 });
            treeView1 = new TreeView();
            labelTitulo = new Label();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 43);
            treeView1.Name = "treeView1";
            treeNode1.Name = "Nodo2";
            treeNode1.Text = "Introducción";
            treeNode2.Name = "Nodo5";
            treeNode2.Text = "Portada";
            treeNode3.Name = "Titulo";
            treeNode3.Text = "Titulo";
            treeNode4.Name = "Nodo1";
            treeNode4.Text = "Presentación";
            treeNode5.Name = "Nodo9";
            treeNode5.Text = "Objetivo General";
            treeNode6.Name = "Nodo11";
            treeNode6.Text = "Objetivo 1";
            treeNode7.Name = "Nodo12";
            treeNode7.Text = "Objetivo 2";
            treeNode8.Name = "Nodo13";
            treeNode8.Text = "Objetivo 3";
            treeNode9.Name = "Nodo10";
            treeNode9.Text = "Objetivos Especificos";
            treeNode10.Name = "Nodo8";
            treeNode10.Text = "Objetivos";
            treeNode11.Name = "Nodo14";
            treeNode11.Text = "Marco de referencia";
            treeNode12.Name = "Nodo15";
            treeNode12.Text = "Marco Legal";
            treeNode13.Name = "Nodo17";
            treeNode13.Text = "Tema 1";
            treeNode14.Name = "Nodo20";
            treeNode14.Text = "Sub tema 1";
            treeNode15.Name = "Nodo21";
            treeNode15.Text = "Sub tema 2";
            treeNode16.Name = "Nodo19";
            treeNode16.Text = "Tema 2";
            treeNode17.Name = "Nodo18";
            treeNode17.Text = "Tema 3";
            treeNode18.Name = "Nodo16";
            treeNode18.Text = "Marco teórico";
            treeNode19.Name = "Nodo4";
            treeNode19.Text = "Proyecto";
            treeNode20.Name = "Nodo0";
            treeNode20.Text = "Inicio";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode20 });
            treeView1.Size = new Size(186, 233);
            treeView1.TabIndex = 0;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 13F);
            labelTitulo.Location = new Point(21, 8);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(115, 25);
            labelTitulo.TabIndex = 1;
            labelTitulo.Text = "Despliegame";
            // 
            // For_TreeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(215, 292);
            Controls.Add(labelTitulo);
            Controls.Add(treeView1);
            Name = "For_TreeView";
            Text = "For_TreeView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label labelTitulo;
    }
}
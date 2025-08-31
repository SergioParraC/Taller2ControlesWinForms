using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller2ControlesWinForms
{
    public partial class For_ContextMenuStrip : Form
    {
        public For_ContextMenuStrip()
        {
            InitializeComponent();
        }

        private void opción1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelOpcion.Text = "Seleccionaste la opción 1";
        }

        private void hija1Opción2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelOpcion.Text = "Seleccionaste la Hija 1 Opción 2";
        }

        private void hija21Opción2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelOpcion.Text = "Seleccionaste la Hija 2-2 de la \nOpción 2 ";
        }

        private void hija3Opción2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelOpcion.Text = "Seleccionaste la Hija 3 Opcón 2";
        }

        private void hija1Opción3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelOpcion.Text = "Seleccionaste la Hija 1 Opción 3";
        }

        private void opción4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelOpcion.Text = "Seleccionaste la Opción 4";
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(buttonClick, 0, buttonClick.Height);
        }
    }
}

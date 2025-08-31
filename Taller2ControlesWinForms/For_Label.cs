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
    public partial class For_Label : Form
    {
        public For_Label()
        {
            InitializeComponent();
        }

        private void labelTexto_MouseHover(object sender, EventArgs e)
        {
            labelColor.BackColor = Color.Black;
            labelColor.ForeColor = Color.Yellow;
        }

        private void labelTexto_MouseLeave(object sender, EventArgs e)
        {
            labelColor.BackColor = SystemColors.Control;
            labelColor.ForeColor = Color.Black;
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}

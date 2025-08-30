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
    public partial class For_Boton : Form
    {
        public For_Boton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(labelClick.Text.Length > 0)
            {
                labelClick.Text = "";
            }
            else
            {
                labelClick.Text = "Ha realizado click sobre el boton";
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            labelPasaMouse.BackColor = SystemColors.ActiveCaptionText;
            labelPasaMouse.ForeColor = Color.Yellow;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            labelPasaMouse.BackColor = SystemColors.Control;
            labelPasaMouse.ForeColor = Color.Black;
        }
    }
}

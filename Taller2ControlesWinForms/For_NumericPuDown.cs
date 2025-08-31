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
    public partial class For_NumericPuDown : Form
    {
        public For_NumericPuDown()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            labelValor.Text = "El nuevo valor es: " + numericUpDown1.Value.ToString();
        }
    }
}

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
    public partial class For_ComboBox : Form
    {
        public For_ComboBox()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelOpcionSeleccionada.Text = "Opción " +  comboBox1.SelectedIndex.ToString();
        }
    }
}

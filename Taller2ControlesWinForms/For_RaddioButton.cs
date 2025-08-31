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
    public partial class For_RaddioButton : Form
    {
        public For_RaddioButton()
        {
            InitializeComponent();
        }

        private void radioButtonOpcion1_CheckedChanged(object sender, EventArgs e)
        {
            labelOpcion.Text = "Opción 1 seleccionada";
        }
        private void radioButtonOpcion2_CheckedChanged(object sender, EventArgs e)
        {
            labelOpcion.Text = "Opción 2 seleccionada";
        }

        private void radioButtonOpcion3_CheckedChanged(object sender, EventArgs e)
        {
            labelOpcion.Text = "Opción 3 seleccionada";
        }

        private void radioButtonOpcion4_CheckedChanged(object sender, EventArgs e)
        {
            labelOpcion.Text = "Opción 4 seleccionada";
        }

        private void radioButtonOpcion5_CheckedChanged(object sender, EventArgs e)
        {
            labelOpcion.Text = "Opción 5 seleccionada";
        }
    }
}

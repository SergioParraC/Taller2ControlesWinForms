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
    public partial class For_CheckBox : Form
    {
        public For_CheckBox()
        {
            InitializeComponent();
        }

        private void checkBox_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBoxElemento.Checked)
            {
                labelSeleccionActiva.Text = "El Check Box está seleccionado";
                labelSeleccionDesactivado.Text = string.Empty;
            }
            else
            {
                labelSeleccionDesactivado.Text = "El Check Box NO está seleccionado";
                labelSeleccionActiva.Text = string.Empty;
            }
        }
    }
}

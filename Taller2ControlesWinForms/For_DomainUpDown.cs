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
    public partial class For_DomainUpDown : Form
    {
        public For_DomainUpDown()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            labelSeleccion.Text = domainUpDown1.Text;
        }
    }
}

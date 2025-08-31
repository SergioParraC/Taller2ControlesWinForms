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
    public partial class For_MonthCalendar : Form
    {
        public For_MonthCalendar()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            labelResultado.Text = "La fecha seleccionada es:\n" + monthCalendar1.SelectionStart.ToString();
        }
    }
}

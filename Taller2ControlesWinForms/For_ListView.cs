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
    public partial class For_ListView : Form
    {
        private class TablaMultiplicar
        {
            public int Numero { get; set; }
            public int Multiplo { get; set; }
            public int Resultado { get; set; }
        }
        public For_ListView()
        {
            InitializeComponent();
        }
        private void buttonHacer_Click(object sender, EventArgs e)
        {
            List<TablaMultiplicar> tabla = new List<TablaMultiplicar>();
            int numero = Convert.ToInt32(textBox1.Text);
            for (int i = 1; i <= 10; i++)
            {
                TablaMultiplicar multiplo = new TablaMultiplicar();
                multiplo.Numero = i;
                multiplo.Multiplo = numero;
                multiplo.Resultado = numero * i;
                tabla.Add(multiplo);
                ListViewItem lista = new ListViewItem(multiplo.Numero.ToString()); // primer valor
                lista.SubItems.Add(multiplo.Multiplo.ToString()); // segunda columna
                lista.SubItems.Add(multiplo.Resultado.ToString()); // tercera columna
                listView1.Items.Add(lista);


            }

        }
    }
}

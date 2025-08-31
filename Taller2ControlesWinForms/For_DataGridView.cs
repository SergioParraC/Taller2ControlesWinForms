using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Taller2ControlesWinForms
{
    public partial class For_DataGridView : Form
    {
        private class TablaMultiplicar
        {
            public int Numero {  get; set; }
            public int Multiplo { get; set; }
            public int Resultado {  get; set; }
        }

        public For_DataGridView()
        {
            InitializeComponent();
        }

        private void buttonHacer_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(textBoxInput.Text);
                List <TablaMultiplicar> tablaMulti = new List <TablaMultiplicar>();
                DataTable tabla = new DataTable();
                for (int i = 1; i <= 10; i++)
                {
                    TablaMultiplicar valor = new TablaMultiplicar();
                    valor.Numero = numero;
                    valor.Multiplo = i;
                    valor.Resultado = numero * i;
                    tablaMulti.Add(valor);
                }
                dataGridViewTabla.DataSource = tablaMulti;
            }
            catch 
            {
                MessageBox.Show("Ingrese un número");
            }
        }
    }
}

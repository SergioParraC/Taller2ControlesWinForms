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
    public partial class For_ListBox : Form
    {
        public For_ListBox()
        {
            InitializeComponent();
        }

        private void buttonDrecha_Click(object sender, EventArgs e)
        {
            MoverElementos(listBoxIzquierda, listBoxDerecha);
        }

        private void buttonIzquierda_Click(object sender, EventArgs e)
        {
            MoverElementos(listBoxDerecha, listBoxIzquierda);
        }

        private void MoverElementos(ListBox origen, ListBox destino)
        {
            if (origen.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona al menos un elemento");
                return;
            }

            List<object> itemsParaMover = origen.SelectedItems.Cast<object>().ToList();

            foreach (var item in itemsParaMover)
            {
                destino.Items.Add(item);
                origen.Items.Remove(item);
            }
        }
    }
}

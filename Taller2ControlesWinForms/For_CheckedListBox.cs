﻿using System;
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
    public partial class For_CheckedListBox : Form
    {
        public For_CheckedListBox()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string listado = "Estas son las opciones seleccionadas:";
            foreach (var item in checkedListBox1.CheckedItems)
            {
                listado = listado + "\n" + item.ToString();
            }
            labelListado.Text = listado;
        }
    }
}

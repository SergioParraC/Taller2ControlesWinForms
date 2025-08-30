namespace Taller2ControlesWinForms
{
    public partial class For_Principal : Form
    {
        public For_Principal()
        {
            InitializeComponent();
        }

        private void buttonBoton_Click(object sender, EventArgs e)
        {
            For_Boton ventana = new For_Boton();
            ventana.ShowDialog();
        }
    }
}

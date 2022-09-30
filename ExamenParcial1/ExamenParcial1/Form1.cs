namespace ExamenParcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            SelecDivisa selecDivisa = new SelecDivisa();
            selecDivisa.ShowDialog();
        }

        public void MenuMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
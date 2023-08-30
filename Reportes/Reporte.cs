namespace Reportes
{

    public partial class Reporte : Form
    {
        LogIn log = new LogIn();

        public Reporte()
        {
            InitializeComponent();
        }


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
            log.Show();
        }
    }
}
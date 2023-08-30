using System.Drawing.Text;

namespace Reportes
{
    public partial class LogIn : Form {
        public LogIn() {
            InitializeComponent();
        }
        public int xClick = 0, yClick = 0;
        string a = "hola";
        Reporte re = new Reporte();


        private void pictureBox6_Click(object sender, EventArgs e) {
            Application.Exit();
        }
        private void pictureBox5_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }
        private void label1_MouseMove(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left) {
                xClick = e.X; yClick = e.Y;
            } else {
                this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e) {
            Entrar();
        }
        private void LogIn_Load(object sender, EventArgs e){
            txtContra.Text = "contraseña";
            txtContra.Focus();
        }
        private void txtContra_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyValue == (char)Keys.Enter) {
                Entrar();
            }else { }
        }
        public void Entrar() {
            if (a == txtContra.Text) {
                this.Hide();
                re.Show();
            } else {
                MessageBox.Show("Contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContra.Text = "";
                txtContra.Focus();
            }
        }
    }
}